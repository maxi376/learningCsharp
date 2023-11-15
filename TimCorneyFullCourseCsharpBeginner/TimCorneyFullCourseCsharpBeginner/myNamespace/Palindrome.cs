using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Palindrome
    {
        public bool checkPalindrome(int n)
        {
            string s=Convert.ToString(n);
            for (int i = 0; i < s.Length / 2; i++)
                if (s[s.Length - i-1] != s[i])
                    return false;
            return true;
        }
    }
}
