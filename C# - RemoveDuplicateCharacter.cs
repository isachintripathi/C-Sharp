using System;

namespace RemoveDuplicateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
			string str;
            Console.WriteLine(" Enter string");  
            str = (Console.ReadLine()).ToLower();  
			string result = string.Empty;  
			for (int i = 0; i < str.Length; i++)  
			{  
				 if (!result.Contains(str[i]))  
				 {  
					 result += str[i];  
				 }  
			}  
			Console.WriteLine(result);  
        }
    }
}
