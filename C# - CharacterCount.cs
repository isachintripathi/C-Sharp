using System;
using System.Collections.Generic;
namespace CharCount
{
    class Program
    {
        static void Main(string[] args)
        {
			string str;
			
			Console.WriteLine(" Enter string : ");  
            str = Console.ReadLine().ToLower();  
			
			Dictionary<char, int> characterCount = new Dictionary<char, int>();  
		  
			foreach (var character in str)  
			{  
				if (character != ' ')  
				{  
					if (!characterCount.ContainsKey(character))  
					{  
						characterCount.Add(character, 1);  
					}  
					else  
					{  
						characterCount[character]++;  
					}  
				}  
		  
			}  
			foreach (var character in characterCount)  
			{  
				Console.WriteLine("Count for {0} is {1}", character.Key, character.Value);  
			}  
        }
    }
}
