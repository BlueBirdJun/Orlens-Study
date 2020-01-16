namespace PS.Common.Crypto
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public abstract class SymmetricCryptoProviderBase
    {
        protected readonly SymmetricAlgorithm Algorithm;

        protected SymmetricCryptoProviderBase(SymmetricAlgorithm algorithm)
            => Algorithm = algorithm
                ?? throw new ArgumentNullException(nameof(algorithm));


        protected abstract byte[] GenerateInitializeVector();

        private void EnsureSourceTextIsValid(string source)
        {
            if (String.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source));
            }
        }

        private byte[] CreateSafeKey(string key)
        {
            // check if key is valid 
            if (String.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            var keySize = Algorithm.KeySize / 8;

            // ensure key size is sufficient
            if (key.Length < keySize)
            {
                throw new CryptographicException(
                    $"Insufficient encryption key size. Expected: {keySize}, Actual: {key.Length}"
                );
            }

            return Encoding.UTF8.GetBytes(key.Substring(0, keySize));
        }

        protected string EncryptCore(string plainText, string key)
        {
            EnsureSourceTextIsValid(plainText);

            var keyBytes = CreateSafeKey(key);
            var iv = GenerateInitializeVector();

            using (var encryptor = Algorithm.CreateEncryptor(keyBytes, iv))
            {
                var sourceData = Encoding.UTF8.GetBytes(plainText);
                var result = encryptor
                    .TransformFinalBlock(sourceData, 0, sourceData.Length);

                return Convert.ToBase64String(result);
            }
        }

        protected string DecryptCore(string cypherText, string key)
        {

            EnsureSourceTextIsValid(cypherText);

            var keyBytes = CreateSafeKey(key);
            var iv = GenerateInitializeVector();

            var bytesToDecrypt = Convert.FromBase64String(cypherText);
            using (var encryptor = Algorithm.CreateDecryptor(keyBytes, iv))
            {
                var decrypted = encryptor
                    .TransformFinalBlock(bytesToDecrypt, 0, bytesToDecrypt.Length);

                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}