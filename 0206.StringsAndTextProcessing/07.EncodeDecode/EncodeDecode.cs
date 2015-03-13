using System;
using System.Collections.Generic;
using System.Text;
class EncodeDecode
{
    static void Main()
    {
        string source = "Hello, World.\nHow are you?";
        string key = "hide!";
        List<char> sourceAsList = new List<char>(source.ToCharArray());
        List<char> encryptedData = EncryptDecrypt(sourceAsList, key);
        Console.WriteLine(string.Join("", encryptedData));
        List<char> encrypted = encryptedData;
        List<char> decryptedData = EncryptDecrypt(encrypted, key);
        Console.WriteLine(string.Join("", decryptedData));

    }

    private static List<char> EncryptDecrypt(List<char> source, string key)
    {
        List<char> returnValue = new List<char>();
        for (int i = 0, j = 0; i < source.Count; i++, j++)
        {
                returnValue.Add((char)(source[i] ^ key[j]));
                if (j == key.Length - 1)
                {
                    j = 0;
                }
        }
        return returnValue;
    }
}