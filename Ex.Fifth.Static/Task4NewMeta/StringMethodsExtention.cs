using System;

namespace Ex.Fifth.Static
{
    static class StringMethodsExtention
    {
        public static string ExtentionSubstring(this string value,int start, int count)
        {
            char[] tmp = value.ToCharArray();
            string returnedValue = "";

            if (start >= 0 && count >= 0 && (start + count) <= tmp.Length)
            {
                for(int i = start; i < start + count; i++)
                {
                    returnedValue += tmp[i];
                }
            }
            return returnedValue;
        }

        public static int ExtentionIndexOf(this string value, string find)
        {
            for(int i = 0; i + find.Length - 1 < value.Length; i++)
            {
                if (find == value.ExtentionSubstring(i, find.Length))
                    return i;
            }
            return -1;
        }

        public static string ExtentionReplace(this string value, string find, string replace)
        {
            int startIndex = value.ExtentionIndexOf(find);

            if (startIndex != -1)
            {
                value = value.Remove(startIndex, find.Length);
                return value.Insert(startIndex, replace);
            }
            return value;
        }
    }
}
