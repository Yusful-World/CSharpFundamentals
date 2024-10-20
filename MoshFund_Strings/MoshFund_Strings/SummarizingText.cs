using System.Collections.Generic;

namespace MoshFund_Strings
{
    public class SummarizingText
    {
        public  static string SummarizeText(string text, int maxLength)
        {
            var totalCharacters = 0;
            var words = text.Split(' ');
            var summarizedWords = new List<string>();

            if (text.Length < maxLength)
            {
                return text;
            }
            
            foreach (var word in words)
            {
                summarizedWords.Add(word);
                    
                totalCharacters += word.Length + 1; //whitespace should be added
                if (totalCharacters > maxLength)
                    break;
            }

            return string.Join(" ", summarizedWords) + ("...");
        }
    }
}
