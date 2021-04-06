using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
			string str;
			Console.WriteLine(" Enter string : ");  
            str = Console.ReadLine();  
			char[] chars = str.ToCharArray();
			for (int i = 0, j = str.Length - 1; i < j; i++, j--)
			{
				chars[i] = str[j];
				chars[j] = str[i];
			}
			Console.WriteLine(chars);  
        }
	}
}
