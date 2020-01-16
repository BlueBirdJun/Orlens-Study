namespace PS.Common.Crypto
{
    using System;
    using System.Security.Cryptography;
    using System.Linq;

    public class RijndaelCryptoProvider
        : SymmetricCryptoProviderBase
        , ICryptoProvider
    {
        private readonly int vectorSize;
        private readonly string defaultKey;

        public RijndaelCryptoProvider(string _defaultKey)
            : base(Rijndael.Create())
        {
            vectorSize = 16;

            defaultKey = _defaultKey
                ?? throw new ArgumentNullException(nameof(defaultKey));
        }

        protected override byte[] GenerateInitializeVector()
        {
            return Enumerable
                .Range(0, vectorSize)
                .Select(b => (byte)b)
                .ToArray();
        }

        public string Encrypt(string source)
        {
            return EncryptCore(source, defaultKey);
        }

        public string Encrypt(string source, string key)
        {
            return EncryptCore(source, key);
        }

        public string Decrypt(string source)
        {
            return DecryptCore(source, defaultKey);
        }

        public string Decrypt(string source, string key)
        {
            return DecryptCore(source, key);
        }
    }
}