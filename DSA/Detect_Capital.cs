using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Detect_Capital
    {
        public bool DetectCapitalUse(string word)
        {
            bool isFirstCapital = word[0] >= 'A' && word[0] <= 'Z';
            bool isLastCapital = word[word.Length - 1] >= 'A' && word[word.Length - 1] <= 'Z';

            if(!isFirstCapital && isLastCapital)
            {
                return false;
            }
            else if(isFirstCapital && !isLastCapital)
            {
                for(int i=1; i< word.Length-1; i++)
                {
                    if (word[i] >= 'A' && word[i] <= 'Z')
                    {
                        return false;
                    }
                }
            }
            else if (!isFirstCapital && !isLastCapital)
            {
                for (int i = 1; i < word.Length - 1; i++)
                {
                    if (word[i] >= 'A' && word[i] <= 'Z')
                    {
                        return false;
                    }
                }
            }
            else if(isFirstCapital && isLastCapital)
            {
                for (int i = 1; i < word.Length - 1; i++)
                {
                    if (word[i] >= 'a' && word[i] <= 'z')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
