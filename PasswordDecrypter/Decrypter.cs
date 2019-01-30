using System;
using System.Linq;

namespace PasswordDecrypter
{
    public class Decrypter
    {
        private string alphabet = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";
        private string decryptedPassword = "";

        public string Decrypt(string passwordToDecrypt)
        {
            decryptedPassword = "";
            foreach (char @char in passwordToDecrypt)
            {
                if (alphabet.Contains(@char))
                {
                    decryptedPassword += alphabet[minusTen(alphabet.IndexOf(@char))];
                }
                else decryptedPassword += @char;
            }
            return decryptedPassword;
        }

        private int minusTen(int number)
        {
            int x = number - 10;
            if (number - 10 < 0)
            {
                return (number - 10) + 62;
            }
            else return number -= 10;
        }
    }
}
