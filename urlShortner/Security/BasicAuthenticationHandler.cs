
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using UrlShortner.Helper;
using System.Security.Cryptography;
namespace UrlShortner.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder) : base(options, logger, encoder)
        {
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers.Authorization!);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter!);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var email = credentials[0];
                var enteredPassword = credentials[1];
                var user = DataMock.Users.FirstOrDefault(u => u.Email!.Equals(email, StringComparison.OrdinalIgnoreCase));
                
                if (user == null)
                {
                    return AuthenticateResult.Fail("User not found");
                }
                
                var hashedPassword = HashPassword(enteredPassword, user.PasswordSalt);
                
                if (hashedPassword == user.Password)
                {
                    var claims = new[] { new Claim("emails", email) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);
                    return AuthenticateResult.Success(ticket);
                }
                else
                {
                    return AuthenticateResult.Fail("Invalid Username or Password");
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }
        }

        public string HashPassword(string password, string salt)
        {
            using var sha512 = new SHA512Managed();
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var saltedPassword = passwordBytes.Concat(saltBytes).ToArray();
            var hashedBytes = sha512.ComputeHash(saltedPassword);
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
