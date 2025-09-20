class CryptoTest : Test
{
    public override void RunTest()
    {
        // Encryption Test
        Console.WriteLine("Encrypted Text: " + Crypto.CaeserEncryption("ibrahim", 3));

        // Decryption Test 
        Console.WriteLine("Decrypted Test: "+Crypto.CaeserDecryption("leudklp",3));
    }
}