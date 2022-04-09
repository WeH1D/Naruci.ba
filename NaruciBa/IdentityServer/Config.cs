// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;
using static IdentityModel.OidcConstants;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("WinAppScope", "WinAppScope"),
                new ApiScope("MobileAppScope", "MobileAppScope"),
            };

        public static IEnumerable<ApiResource> ApiResources =>
         new ApiResource[]
         {
                new ApiResource("NaruciBaApi", "Naruci.ba api")
                {
                    Scopes = { "WinAppScope", "MobileAppScope" }
                },
         };


        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "WinApp",
                    ClientSecrets =
                    {
                        new Secret("WinAppPassword".Sha256())
                    },
                    AllowedGrantTypes = IdentityServer4.Models.GrantTypes.ResourceOwnerPassword,

                    AllowOfflineAccess = true,
                    AccessTokenLifetime = 1700,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,

                    //In the scopes, Observe that we've added both an ApiResource "WinAppScope" and the standard "openid" scope.
                    //This indicates that the resultant token is an id_token which contains profile information of the resource owner and can also be used
                    //to access an API which represents the "WinAppScope" ApiResource.
                    AllowedScopes = { "WinAppScope", StandardScopes.OpenId }
                },
                 new Client
                {
                    ClientId = "MobileApp",
                    ClientSecrets =
                    {
                        new Secret("MobileAppPassword".Sha256())
                    },
                    AllowedGrantTypes = IdentityServer4.Models.GrantTypes.ResourceOwnerPassword,

                    AllowOfflineAccess = true,
                    AccessTokenLifetime = 1700,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,

                    AllowedScopes = { "MobileAppScope", StandardScopes.OpenId }
                }
            };
    }
}