using System;
using System.Collections.Generic;
using System.Text;

namespace PKT.GoogleAuthenticator.Test.Utils
{
    public class AuthenticatorUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountTitle"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static string Generate(string accountTitle, string secretKey)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
            var setupCode = tfA.GenerateSetupCode(accountTitle, accountTitle, secretKey, false, 50);

            return setupCode.QrCodeSetupImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool Verification(string secretKey,string code)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();

            return tfA.ValidateTwoFactorPIN(secretKey, code);
        }
    }
}
