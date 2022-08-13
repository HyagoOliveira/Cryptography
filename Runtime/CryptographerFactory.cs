using ActionCode.AsyncIO;

namespace ActionCode.Cryptography
{
    /// <summary>
    /// Static factory class for <see cref="ICryptographer"/>.
    /// </summary>
    public static class CryptographerFactory
    {
        /// <summary>
        /// Creates an instance of <see cref="ICryptographer"/> based on the given type.
        /// </summary>
        /// <param name="type">The Cryptographer type to use.</param>
        /// <param name="key">The key to use with the Cryptographer.</param>
        /// <returns>An Cryptographer implementation.</returns>
        public static ICryptographer Create(CryptographerType type, string key) =>
            Create(type, key, StreamFactory.Create());

        /// <summary>
        /// <inheritdoc cref="Create(CryptographerType, string)"/>
        /// </summary>
        /// <param name="type"><inheritdoc cref="Create(CryptographerType, string)"/></param>
        /// <param name="key"><inheritdoc cref="Create(CryptographerType, string)"/></param>
        /// <param name="strem">The stream instance to use.</param>
        /// <returns><inheritdoc cref="Create(CryptographerType, string)"/></returns>
        public static ICryptographer Create(CryptographerType type, string key, IStream strem)
        {
            return type switch
            {
                CryptographerType.None => null,
                CryptographerType.AES => new AESCryptographer(key, strem),
                _ => null,
            };
        }
    }
}