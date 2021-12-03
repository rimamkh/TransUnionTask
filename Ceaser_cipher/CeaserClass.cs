using System;
using System.Text.RegularExpressions;

namespace Ceaser_cipher
{
    
    public class CeaserClass
    {
        private string input;
        private int k;
        public CeaserClass()
        {
           
        }
        public CeaserClass(String Input, int Key)
        {
            this.input = Input;
            this.k = Key;
        }
        public string Input 
        {
            get { return input; } 

        }

        public string Encipher(string input, int key)
        {
            string Myoutput = string.Empty;

            foreach (char c in input)
                Myoutput += cipher(c, key);

            return Myoutput;
        }
        public char cipher(char c, int key)
        {
            if (!char.IsLetter(c))
            {

                return c;
            }

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + key) - d) % 26) + d);


        }
    }
}