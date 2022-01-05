using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using NaruciBa.Database;
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public NaruciBaContext Context { get; set; }

        public ResourceOwnerPasswordValidator(NaruciBaContext context)
        {
            Context = context;
        }


        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var username = context.UserName;
            var password = context.Password;

            var korisnik = Context.Korisniks.FirstOrDefault(a => a.Email == username);

            if (korisnik == null)
            {
                context.Result = new GrantValidationResult(
                  TokenRequestErrors.UnauthorizedClient, "Invalid username or password.");

                return Task.FromResult(0);
            }

            var hash = GenerateHash(korisnik.PasswordSalt, password);

            if (hash != korisnik.PasswordHash)
            {
                context.Result = new GrantValidationResult(
                   TokenRequestErrors.UnauthorizedClient, "Invalid username or password.");

                return Task.FromResult(0);
            }

            context.Result = new GrantValidationResult(
                subject: username,
                authenticationMethod: "custom",
                claims: new Claim[] {
                    new Claim(ClaimTypes.NameIdentifier, username)
                }
            );

            return Task.FromResult(0);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
    }
}
