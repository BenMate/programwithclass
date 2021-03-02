/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //output file needs to be called output.txt 
            //first file is called words.txt
            
            //make list of words
            List<string> words = new List<string>();
            //calls function that Loads words from words.txt
            LoadWords("./words.txt", words);
            //calls function that sorts the words          
            SortWords(words);        
            //calls function that saves the words to file output.txt
            SaveWords("./output.txt", words);
        }

        //load words from file
        public static List<string> LoadWords(string filename, List<string> words)
        {
            using (StreamReader sr = File.OpenText(filename))
            {                
                int numWords = int.Parse(sr.ReadLine());
                for (int i = 0; i < numWords; i++)
                {
                    words.Add(sr.ReadLine()); 
                }
            }
            return words;
        }

            //sort words alphabetically
        public static void  SortWords(List<string> words)
        {
            words.Sort();
        }

        //save words to new file
        public static void SaveWords(string filename, List<string> words)
        {            
            using (StreamWriter sw = File.CreateText(filename))
            {
                for (int i = 0; i < words.Count; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
        }
    }
}
