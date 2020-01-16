namespace PS.Common.Crypto
{
    public interface ICryptoProvider
    {
        string Encrypt(string source);

        string Encrypt(string source, string key);

        string Decrypt(string source);

        string Decrypt(string source, string key);
    }
}