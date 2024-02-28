using System;
using System.Linq;
using System.Text;

public class SimpleCipher
{
    private readonly string _abc = "abcdefghijklmnopqrstuvwxyz";
    private readonly string _key;

    public SimpleCipher()
    {
        _key = new string(Enumerable.Range(0, 10).Select(x => 'a').ToArray());
    }

    public SimpleCipher(string key)
    {
        _key = key;
    }

    public string Key => _key;

    public string Encode(string plaintext)
    {
        var result = new StringBuilder();
        var keyIndex = 0;
        foreach (var character in plaintext)
        {
            var indexMinus = _abc.IndexOf(character);
            if (indexMinus == -1)
            {
                result.Append(character);
                continue;
            }

            if (indexMinus != -1)
            {
                result.Append(_abc[(indexMinus + _abc.IndexOf(Key[keyIndex])) % _abc.Length]);
            }
            keyIndex++;
            keyIndex = keyIndex < Key.Length ? keyIndex : 0;
        }
        return result.ToString();
    }

    public string Decode(string ciphertext)
    {
        var result = new StringBuilder();
        var keyIndex = 0;
        foreach (var character in ciphertext)
        {
            var indexMinus = _abc.IndexOf(character);
            if (indexMinus == -1)
            {
                result.Append(character);
                continue;
            }

            if (indexMinus != -1)
            {
                var indexToDecrypt = (indexMinus - _abc.IndexOf(Key[keyIndex])) % _abc.Length;
                result.Append(_abc[indexToDecrypt < 0 ? _abc.Length - Math.Abs(indexToDecrypt) : indexToDecrypt]);
            }
            keyIndex++;
            keyIndex = keyIndex < Key.Length ? keyIndex : 0;
        }
        return result.ToString();
    }
}