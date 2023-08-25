using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word) 
        {
            for (int i = 0, j = word.Length - 1; i < j; i++, j--) 
           
            if (word[i] == word[j])
             {
                 return true;
             }
             return false;
          
        }
    }
}