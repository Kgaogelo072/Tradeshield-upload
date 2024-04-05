
namespace TS.TechnicalTest;
using System;
using System.Linq;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        string[] sentences = s.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        int maxLength = 0;       
        foreach (string sentence in sentences)
        {
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sentenceLength = words.Length;
            if (sentenceLength > maxLength)
            {
                maxLength = sentenceLength;
            }
        }
        return maxLength;
    }
}
