using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetSpeak
{
    class LeetSpeak
    {
        public string LeetSpeakTranslator(string word)
        {
            char[] wordArr = word.ToCharArray();

            for(int i = 0; i < wordArr.Length; i++)
            {
                if(wordArr[i] == 'e')
                {
                    wordArr[i] = '3';
                }
                else if(wordArr[i] == 'o')
                {
                    wordArr[i] = '0';
                }
                else if(wordArr[i] =='I')
                {
                    wordArr[i] = '1';

                }
                else if(wordArr[i] =='t')
                {
                    wordArr[i] = '7';
                }
                else if(wordArr[i] =='s')
                {
                    wordArr[i] = 'Z';
                }
            }
            string result = string.Join("", wordArr);
            return result;
        }
    }
}
