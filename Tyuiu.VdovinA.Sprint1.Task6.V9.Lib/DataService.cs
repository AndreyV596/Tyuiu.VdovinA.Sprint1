using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovinA.Sprint1.Task6.V9.Lib
{
    public class DataService 
    {
        public string MoveLastLetterToStart(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t', '\n' },
                                      StringSplitOptions.RemoveEmptyEntries);

            List<string> resultWords = new List<string>();

            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    // Переносим последнюю букву в начало
                    string transformedWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                    resultWords.Add(transformedWord);
                }
                else if (word.Length == 1)
                {
                    // Если слово состоит из одной буквы, оставляем как есть
                    resultWords.Add(word);
                }
            }

            return string.Join(" ", resultWords);
        }
    }
}