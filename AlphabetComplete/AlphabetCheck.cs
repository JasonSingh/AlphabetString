using System;

namespace AlphabetComplete
{
    /*
     You will receive a string as input, potentially a mixture of upper and lower case, numbers, special characters etc. 
     The task is to determine if the string contains at least one of each letter of the alphabet. 
     Return true if all are found and false if not. 
     Write it as a RESTful web service (no authentication necessary) in any language/framework you choose and document the service. 
     Please bring your laptop on the day of your interview to present your information.     
    */

        // Ensure this is only accessed by a single thread.
    public class AlphabetCheck
    {
        private const int ALPHABET_TOTAL = 26;
        private bool [] AlphabetArray = new bool[ALPHABET_TOTAL];
        private int UniqueCount = 0;

        public AlphabetCheck()
        {
            for (int i = 0; i < ALPHABET_TOTAL; i++)
                AlphabetArray[i] = false;
        }

        // Set the index in the array.
        // If all 26 characters have occurred, exit and return true.
        private bool SetIndex(int index)
        {
            bool result = false;

            if (!AlphabetArray[index])
            {
                UniqueCount++;
                AlphabetArray[index] = true;
                if (UniqueCount >= ALPHABET_TOTAL)
                    result = true;
            }

            return result;
        }

        public bool ContainsEntireAlphabet(string input)
        {
            bool result = false;
            int index = -1;

            if (string.IsNullOrEmpty(input))
                return false;

            if (input.Length < ALPHABET_TOTAL)
                return false;

            foreach (char ch in input)
            {
                index = -1;

                if (ch >= 'a' && ch <= 'z')
                    index = ch - 'a';
                if (ch >= 'A' && ch <= 'Z')
                    index = ch - 'A';

                if (index > -1)
                {
                    result = SetIndex(index);
                    if (result)
                        break;
                }
            }

            return result;
        }
    }
}
