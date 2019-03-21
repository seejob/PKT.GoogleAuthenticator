using PKT.GoogleAuthenticator.Test.Utils;
using System;

namespace PKT.GoogleAuthenticator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountTitle = "account";

            var secretKey = "f68f1fe894d548a1bbc66165c46e61eb"; //Guid.NewGuid().ToString().Replace("-", "");

           var ImageUrl= AuthenticatorUtil.Generate(accountTitle, secretKey);
            
            Console.WriteLine(ImageUrl);
        }
    }
}
