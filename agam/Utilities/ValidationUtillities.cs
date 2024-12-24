using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace agam.Utilities
{
    public static class ValidationUtilites
    {
        //public static bool LegalId(string s)
        //{
        //    int x;
        //    if (!int.TryParse(s, out x))
        //        return false;
        //    if (s.Length < 5 || s.Length > 9)
        //        return false;
        //    for (int i = s.Length; i < 9; i++)
        //        s = "0" + s;
        //    int sum = 0;
        //    for (int i = 0; i < 9; i++)
        //    {
        //        char c = s[i]; ;
        //        int k = ((i % 2) + 1) * (c - '0');
        //        if (k > 9)
        //            k -= 9;
        //        sum += k;

        //    }
        //    return sum % 10 == 0;
        //}
        public static bool IsCreditNum(string creditNum)
        {
            if (creditNum.Length != 16)
                return false;
            return true;
        }

        public static bool IsCreditDate(string creditDate)
        {
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int month = dt.Month;

            if (Convert.ToInt32(creditDate.Substring(3, 4)) < year)
                return false;
            return true;
        }
        public static bool IsAtAge(DateTime birthDay)//בדיקה האם מעל גיל 13
        {
            DateTime birthDate = birthDay;
            DateTime toDayDate = DateTime.Now;
            if (toDayDate.Year - birthDate.Year < 13)
                return false;
            return true;
        }
        public static bool IsLegalPhonNum(string word)//בדיקה אם מספר טלפון חוקי אורך 7 ורק ספרות 
        {
            foreach (char c in word)
                if (!(IsDigits(c)) || (!(word.Length == 10)))
                    return false;
            return true;
        }
        public static bool IsLegalAdd(string word)// בדיקת חוקיות כתובת
        {
            foreach (char c in (word))
                if (IsHebrewLetter(c) == false && IsDigits(c) == false && c != ' ')
                    return false;
            return true;
        }
        public static string SubPhone(string phone)// הפרדת הקידומת ממספר הטלפון הכללי
        {
            string sub;
            string c = phone.Substring(2, 1);// התו השלישי במחרוזת של המספר
            if (c == "-")  // אם התו השלישי הוא מקף אז הקידומת היא של שתי ספרות
            {
                sub = phone.Substring(0, 2);
                return sub;
            }
            else  //אחרת הקידומת היא של 3 ספרות
            {

                sub = phone.Substring(0, 3);
                return sub;

            }

        }
        public static string PhoneNum(string phone) // החזרת מספר הטלפון ללא קידומת
        {

            string c = phone.Substring(2, 1);
            if (c == "-")
            {
                string phoneNoSub = phone.Substring(3);
                return phoneNoSub;
            }
            else
            {
                string phoneNoSub = phone.Substring(4);
                return phoneNoSub;
            }
        }
        public static bool PhoneNumber(string num)
        {
            string pattern = @"\b0[2-4 7-9]-[2-9]\d{6}";
            Regex r = new Regex(pattern);
            return r.IsMatch(num);
        }
        public static bool LegalName(string name)
        {
            string pattern = @"\b[א-ת- ]+";
            Regex r = new Regex(pattern);
            return r.IsMatch(name);
        }
        public static int GetAge(DateTime d)
        {
            DateTime t = DateTime.Today;
            int age = t.Year - d.Year;
            if (t < d.AddYears(age)) age--;
            return age;
        }


        /// ///////////////////////////////////
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool GreaterThanZero(int num)
        {
            return num > 0;
        }

        public static bool IsHebrewLetter(char c)
        {
            string otiyot = "'אבגדהוזחטיכלמנסעפצקרשתךםןףץ";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsEnglishLetter(char c)
        {
            string otiyot = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsDigits(char c)
        {
            string digits = "0123456789";
            if (digits.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsLegalItemName(string word)
        {
            foreach (char c in word)
                if (IsDigits(c) == false && IsHebrewLetter(c) == false && c != '-' && c != ' ' && IsEnglishLetter(c) == false)
                    return false;
            return true;
        }

        public static bool IsLegalName(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-')
                    return false;
            return true;
        }

        public static bool IsLegalCity(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-' && c != ' ')
                    return false;
            return true;
        }
        public static bool IsLegalIdNum(string word)//בדיקת מספר פריט חוקי
        {
            foreach (char c in word)
                if (!(IsDigits(c)) && (!(word.Length == 9)))
                    return false;
            return true;
        }
        public static bool IsLegalId(string id)
        {
            string word = id;
            if (word.Length != 9)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalDigit(string dig)
        {
            string digit = dig;
            foreach (char c in digit)
                if (digit.IndexOf(c) == -1)
                    return false;
            return true;
        }
        public static bool IsLegalZipcode(string zip)
        {
            string zipcode = zip;
            if (zipcode.Length != 5)
                return false;
            foreach (char c in zipcode)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberVisa(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 16)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberAmericanexpress(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 8)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalThreeDig(string tdig)
        {
            string threedig = tdig;
            if (threedig.Length != 3)
                return false;
            foreach (char c in threedig)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalItemId(string id)
        {
            string word = id;
            if (word.Length != 5)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }




        internal static bool IsOnlyDigits(string p)
        {
            throw new NotImplementedException();
        }
    }
}
