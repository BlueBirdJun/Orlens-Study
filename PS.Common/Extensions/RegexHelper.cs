using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PS.Common.Extensions
{
    public class RegexHelper
    {
        bool invalid = false;
        /// <summary>
        ///  휴대폰번호여부
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsMobileNumber(object strIn)
        {
            return new Regex(@"^01[0689][0-9\-]{8,10}$").IsMatch(Convert.ToString(strIn));
            //return new Regex(@"^[0-9\-]{11,13}$").IsMatch(Convert.ToString(strIn));
        }

        /// <summary>
        /// 전화번호여부
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidPhoneNumber(string strIn)
        {
            Regex regex = new Regex(@"^(\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*$");
            return regex.IsMatch(strIn);
        }

        /// <summary>
        /// 이메일 여부
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string strIn)
        {
            RegexHelper helper = new RegexHelper();
            return helper.IsValidEmailFormat(strIn);
        }


        public bool IsValidEmailFormat(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper);
            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase);
        }



        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
