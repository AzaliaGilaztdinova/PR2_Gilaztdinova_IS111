using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
       
            public class Encrypter
        {
            public static string Encrypt(string input)
            {
                char[] encryptedChars = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    encryptedChars[i] = (char)(input[i] + 1);
                }
                return new string(encryptedChars);
            }

            public static string Decrypt(string input)
            {
                char[] decryptedChars = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    decryptedChars[i] = (char)(input[i] - 1);
                }
                return new string(decryptedChars);
            }
        }
    }
    }

