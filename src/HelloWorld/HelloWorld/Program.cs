using System;
using System.Security.Cryptography;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SymmetricAlgorithm serviceProvider = new DESCryptoServiceProvider();
            byte[] key = { 16, 22, 240, 11, 18, 150, 192, 21 };
            serviceProvider.Key = key;
            ICryptoTransform encryptor = serviceProvider.CreateEncryptor();

            string unUsedMesage = "No Used";
            String message = "Hello World";
            byte[] messageB = System.Text.Encoding.ASCII.GetBytes(message);
            var encrypted = encryptor.TransformFinalBlock(messageB, 0, messageB.Length);
            
            string testStr = null;
            if (unUsedMesage != null )
            {
                testStr = unUsedMesage;
            }
            else
            {
                testStr = null;
            }
        }
    }
}
