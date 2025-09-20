public class Crypto
{
    // Caeser Encryption Algorithm Implementation 
    public static string CaeserEncryption(string str, int key)
    {
        if (key.GetType() != typeof(int))
        {
            throw new ArgumentException("Key cannot be of any datatype other than integer");
        }
        if (key == null || str == null)
        {
            throw new ArgumentException("Text or Key Caannot be Null");
        }

        string chars = "abcdefghijklmnopqrstuvwxyz";
        string encrypted = "";
        
        for (int i = 0; i < str.Length; i++)
        {
            int index = chars.IndexOf(str[i]);
            int encryptedIdnex = (index + key) % chars.Length;
            encrypted += chars[encryptedIdnex];
        }
        return encrypted;
    }

    // Caeser Decryption Algorithm Implementation 
    public static string CaeserDecryption(string str, int key)
    {
        return CaeserEncryption(str, -key);
    }

    
}