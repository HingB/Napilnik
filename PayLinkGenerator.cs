using System;

namespace Store
{
    class PayLinkGenerator
    {
        private char[] _alphabet = { 'a', 'b', 'c', 'd', 'e',
                             'f', 'g', 'h', 'i', 'j',
                             'k', 'l', 'm', 'n', 'o',
                             'p', 'q', 'r', 's', 't',
                             'u', 'v', 'w', 'x', 'y', 'z' };

        public string GenerateString(int linkLength)
        {
            Random random = new Random();
            char[] genetatedChars = new char[linkLength];

            for (int i = 0; i < linkLength; i++)
            {
                genetatedChars[i] = _alphabet[random.Next(0, _alphabet.Length)];
            }

            return new string(genetatedChars);
        }
    }
}
