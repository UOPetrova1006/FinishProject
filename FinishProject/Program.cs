using System;
using System.Linq;
    class Program
    {
        static void Main (string[] args)
        {
            string [] array = new string [] {"now", "7", "wensday", "23"};
            string [] NewArray = new string [array.Length];
            CountLetters(array, NewArray);              
        }
    
    static void CountLetters (string [] array, string [] NewArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i];
                int numberOfLetters = word.ToCharArray().Count();
                if (numberOfLetters <= 3)
                    {
                        NewArray [i] = word;
                        Console.WriteLine(NewArray[i]);
                    }
            }  
        }
}