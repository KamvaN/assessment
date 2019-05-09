/*
 *Name           : Kamva Neli
 *Student number : 217034360 
 *Task           : Practical assignment 3
 *Due date       : 09/05/2019
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017034360
{
    class Program
    {
        static string sAlphabets = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Console.Write("=>");
            string sUserStr = Console.ReadLine().ToLower();

            int[] LetterCounter = new int[26];
            int iIndex;
            foreach (char cChar in sUserStr)
            {
                if (sAlphabets.Contains(cChar.ToString()))
                {
                    iIndex = sAlphabets.IndexOf(cChar.ToString());
                    LetterCounter[iIndex]++;
                }
            }

            for (int i = 0; i < LetterCounter.Length; i++)
            {
                Console.Write(sAlphabets[i].ToString().ToUpper() + ": ");
                for (int j = 0; j < LetterCounter[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            int iTotalLetter = GetNumLetters(sUserStr);
            int iNumberOfWords;

            Console.WriteLine("STATISTICS");
            Console.WriteLine("==========");
            Console.WriteLine("Number of leeter: " + iTotalLetter);
            Console.ReadKey();
        }

        static int GetNumLetters(string _sUserStr)
        {
            int iNumLetter = 0;
            foreach (char cCharacter in _sUserStr)
                iNumLetter += (sAlphabets.Contains(cCharacter.ToString())) ? 1: 0;
            return iNumLetter;
        }

        static int GetNumWords(string sStr)
        {
            int iNumWords = 0;
            bool isSpaceAvailable = true;
            int iIndex;
            while(isSpaceAvailable)
            {
                iIndex = sStr.IndexOf(" ");
                isSpaceAvailable = (iIndex == -1)? false: true;
                if(isSpaceAvailable)
                sStr = sStr.Substring(iIndex + 2);
                iNumWords++;
            }
            return iNumWords;
      }
    }
}
