using System;
namespace PalindromeExercise;

	public class WordSmith
	{
		public WordSmith()
		{
		}

		public bool IsAPalindrome(string word)
        {
			var reversed = "";

			for(var i = word.Length - 1; i >=0; i--)
            {
				reversed += word.ToLower()[i];
            }

			if(reversed == word.ToLower())

			{
				return true;
            }

            else
            {
				return false;
            }
        }
	}

//another way to do it is refactor- return reversed == word.ToLower(); after the if
// or using .linq return word.ToLower().SequenceEqual(word.ToLower().Reverse());