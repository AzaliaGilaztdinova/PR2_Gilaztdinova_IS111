using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3.Program;

namespace _3
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            string originalText = "Hello";
            string encryptedText = Encrypter.Encrypt(originalText);
            string decryptedText = Encrypter.Decrypt(encryptedText);

            Console.WriteLine($"Original Text: {originalText}");           // Output: Original Text: Hello
            Console.WriteLine($"Encrypted Text: {encryptedText}");         // Output: Encrypted Text: Ifmmp
            Console.WriteLine($"Decrypted Text: {decryptedText}");         // Output: Decrypted Text: Hello
        }
    }
}
