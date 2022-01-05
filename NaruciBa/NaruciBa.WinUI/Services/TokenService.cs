using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NaruciBa.WinUI.Services
{
    public class TokenService
    {
        private DiscoveryDocumentResponse _discDocument { get; set; }
        HttpClient client = new HttpClient();

        public TokenService()
        {
            using (var client = new HttpClient())
            {
                _discDocument = client.GetDiscoveryDocumentAsync(Properties.Settings.Default.IdentityServerApi).Result;
            }
        }

        public async Task<string> setAccessToken(string email, string password)
        {
            Properties.Settings.Default.AccessToken = "";
            Properties.Settings.Default.RefreshToken = "";
            Properties.Settings.Default.Save();

            TokenResponse token = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = _discDocument.TokenEndpoint,
                ClientId = "WinApp",
                ClientSecret = "WinAppPassword",
                UserName = email,
                Password = password,
                Scope = "WinAppScope openid offline_access",
                GrantType = "password",
            });

            if (token.IsError)
            {
                throw new Exception("Invalid token");
            }

            Properties.Settings.Default.AccessToken = token.AccessToken;
            Properties.Settings.Default.RefreshToken = token.RefreshToken;
            Properties.Settings.Default.Save();

            return token.AccessToken;
        }

        public async Task<string> setRefreshToken()
        {
            TokenResponse refreshTokenResponse = await client.RequestRefreshTokenAsync(new RefreshTokenRequest()
            {
                RefreshToken = Properties.Settings.Default.RefreshToken,
                Address = _discDocument.TokenEndpoint,
                ClientId = "WinApp",
                ClientSecret = "WinAppPassword",
                Scope = "WinAppScope openid offline_access",
                GrantType = "password",
            });

            if (refreshTokenResponse.IsError)
            {
                throw new Exception("Invalid token");
            }

            Properties.Settings.Default.AccessToken = refreshTokenResponse.AccessToken;
            Properties.Settings.Default.RefreshToken = refreshTokenResponse.RefreshToken;

            Properties.Settings.Default.Save();

            return refreshTokenResponse.AccessToken;
        }

        public async Task<string> setToken(string email, string password)
        {
            // No access token present
            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                return await setAccessToken(email, password);
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.ReadJwtToken(Properties.Settings.Default.AccessToken);

                // Token expired, refresh it
                if (token.ValidTo < DateTime.UtcNow)
                {
                    return await setRefreshToken();
                }

                // There already is a valid access token
                return Properties.Settings.Default.AccessToken;
            }
        }
    }
}
