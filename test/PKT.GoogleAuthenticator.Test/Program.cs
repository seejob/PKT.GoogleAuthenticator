using System;

namespace PKT.GoogleAuthenticator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountTitle = "account";

            var secretKey = "f68f1fe894d548a1bbc66165c46e61eb"; //Guid.NewGuid().ToString().Replace("-", "");

            var ImageUrl = Generate(accountTitle, secretKey);

            Console.ReadKey();
        }

        /// <summary>
        /// 生成设置代码。
        /// </summary>
        /// <param name="accountTitle"></param>
        /// <param name="secretKey"></param>
        /// <returns>QrCodeImageUrl</returns>
        public static string Generate(string accountTitle, string secretKey)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
            var setupCode = tfA.GenerateSetupCode(accountTitle, accountTitle, secretKey, false, 50);

            return setupCode.QrCodeSetupImageUrl;
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool Verification(string secretKey, string code)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();

            return tfA.ValidateTwoFactorPIN(secretKey, code);
        }
    }
}
