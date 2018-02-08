/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string palindromeCandidate;
            
            List<int> palindromesList = new List<int>();
            
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {                                            
                    if (j <= i) 
                    {                        
                        if (IsPalindrome((i*j).ToString()))
                        {                                                        
		 	    Console.WriteLine("{0} x {1} = {2} is a palindrome!", i, j, i*j);
                            palindromesList.Add(i*j);                            
                            break;
                        }
                    }
                }
            }
            
            palindromesList.Sort();
            palindromesList.Reverse();
            
            Console.WriteLine("5 highest 4 -digit palindromes:");
            for (int i = 0; i < 5; i++) Console.WriteLine(palindromesList[i]);
                                                 
        }
        
        public static bool IsPalindrome (string candidate)
        {            
            //reversing candidate
            char[] tempChArray = candidate.ToCharArray();
            Array.Reverse(tempChArray);
            string candidateReversed = new string(tempChArray);            
            
            if (candidateReversed.Equals(candidate)) return true;
            else return false;
        }    
    }
}