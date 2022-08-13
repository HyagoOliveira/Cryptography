namespace ActionCode.Cryptography
{
    public static class CryptographerFactory
    {
        /// <summary>
        /// Creates an instance of ICryptographer based on the given type.
        /// </summary>
        /// <param name="type">The Cryptographer type to use.</param>
        /// <param name="key">The key to use with the Cryptographer.</param>
        /// <returns>An implementation of ICryptographer.</returns>
        public static ICryptographer Create(CryptographerType type, string key)
        {
            return type switch
            {
                CryptographerType.None => null,
                CryptographerType.AES => new AESCryptographer(key),
                _ => null,
            };
        }
    }
}