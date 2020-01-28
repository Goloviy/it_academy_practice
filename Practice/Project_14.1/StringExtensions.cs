using System;
using System.Text;
using System.Collections.Generic;


namespace Project_14._1
{
    public static class StringExtensions
    {
        public static string StringFive (this string str)
        {
            return str = str.Substring(0, 5)+"...";
        }
    }
}
