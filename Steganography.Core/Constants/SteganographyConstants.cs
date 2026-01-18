namespace Steganography.Core.Constants
{
    /// <summary>
    /// Constants used in steganography operations
    /// </summary>
    public static class SteganographyConstants
    {
        /// <summary>
        /// Marker appended to messages to indicate end of hidden text
        /// </summary>
        public const string MESSAGE_TERMINATOR = "*#*";

        /// <summary>
        /// Mask for extracting 2 bits (binary: 00000011)
        /// </summary>
        public const int BITS_MASK_2 = 0x3;

        /// <summary>
        /// Mask for clearing the last 2 bits (binary: 11111100)
        /// </summary>
        public const int BITS_CLEAR_2 = 0xfc;

        /// <summary>
        /// Maximum message length to prevent infinite loops
        /// </summary>
        public const int MAX_MESSAGE_LENGTH = 10000;

        /// <summary>
        /// Number of bits in a standard character
        /// </summary>
        public const int BITS_PER_CHARACTER = 8;
    }
}