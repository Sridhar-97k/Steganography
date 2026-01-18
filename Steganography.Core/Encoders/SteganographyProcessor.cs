using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steganography.Core.Constants;

namespace Steganography.Core.Encoders
{
    /// <summary>
    /// Unified processor for LSB steganography encoding and decoding
    /// </summary>
    public class SteganographyProcessor
    {
        /// <summary>
        /// Encodes a text message into an image using LSB steganography
        /// </summary>
        /// <param name="sourceImage">The carrier image</param>
        /// <param name="message">The message to hide</param>
        /// <returns>A new bitmap with the encoded message</returns>
        public Bitmap Encode(Bitmap sourceImage, string message)
        {
            // Validation
            if (sourceImage == null)
                throw new ArgumentNullException(nameof(sourceImage));

            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException(nameof(message));

            // Check if image is large enough
            if (!CanEncode(sourceImage, message))
            {
                int required = CalculateRequiredPixels(message);
                int available = CalculateAvailablePixels(sourceImage);
                throw new InvalidOperationException(
                    $"Image is too small for this message.\n" +
                    $"Required: {required} pixels\n" +
                    $"Available: {available} pixels\n\n" +
                    $"Please use a larger image or shorten your message.");
            }

            // Create a copy to avoid modifying the original
            Bitmap result = new Bitmap(sourceImage);

            // Add terminator
            string messageWithTerminator = message + SteganographyConstants.MESSAGE_TERMINATOR;
            char[] characters = messageWithTerminator.ToCharArray();

            // Encode each character
            int pixelOffset = 0;
            for (int i = 0; i < characters.Length; i++)
            {
                EncodeCharacter(result, characters[i], pixelOffset);
                pixelOffset += 2; // 2 pixels per character
            }

            return result;
        }

        /// <summary>
        /// Decodes a hidden message from an image
        /// </summary>
        /// <param name="encodedImage">The image containing the hidden message</param>
        /// <returns>The decoded message</returns>
        public string Decode(Bitmap encodedImage)
        {
            if (encodedImage == null)
                throw new ArgumentNullException(nameof(encodedImage));

            StringBuilder result = new StringBuilder();
            int pixelOffset = 0;
            int maxChars = GetMaxMessageLength(encodedImage);

            while (pixelOffset / 2 < maxChars)
            {
                try
                {
                    char c = DecodeCharacter(encodedImage, pixelOffset);
                    result.Append(c);

                    // Check for terminator
                    string currentString = result.ToString();
                    if (currentString.EndsWith(SteganographyConstants.MESSAGE_TERMINATOR))
                    {
                        // Remove terminator and return
                        return currentString.Substring(0,
                            currentString.Length - SteganographyConstants.MESSAGE_TERMINATOR.Length);
                    }

                    pixelOffset += 2;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidOperationException(
                        "No valid message found in the image. " +
                        "The image may not contain an encoded message or is corrupted.");
                }
            }

            throw new InvalidOperationException(
                "Message exceeds maximum length. The image may be corrupted.");
        }

        /// <summary>
        /// Checks if an image can accommodate a message
        /// </summary>
        public bool CanEncode(Bitmap image, string message)
        {
            if (image == null || string.IsNullOrEmpty(message))
                return false;

            int required = CalculateRequiredPixels(message);
            int available = CalculateAvailablePixels(image);

            return available >= required;
        }

        /// <summary>
        /// Gets the maximum message length an image can hold
        /// </summary>
        public int GetMaxMessageLength(Bitmap image)
        {
            if (image == null)
                return 0;

            int availablePixels = CalculateAvailablePixels(image);
            int pixelPairs = availablePixels / 2;

            // Subtract terminator length
            return pixelPairs - SteganographyConstants.MESSAGE_TERMINATOR.Length;
        }

        #region Private Helper Methods

        /// <summary>
        /// Encodes a single character into two pixels
        /// </summary>
        private void EncodeCharacter(Bitmap bitmap, char character, int pixelOffset)
        {
            var (x, y) = CalculatePixelPosition(bitmap, pixelOffset);

            Color pixel1 = bitmap.GetPixel(x, y);
            Color pixel2 = bitmap.GetPixel(x, y + 1);

            int charValue = (int)character;

            // Encode lower 4 bits into pixel1
            int red1 = (pixel1.R & SteganographyConstants.BITS_CLEAR_2) |
                       (charValue & SteganographyConstants.BITS_MASK_2);
            int green1 = (pixel1.G & SteganographyConstants.BITS_CLEAR_2) |
                         ((charValue >> 2) & SteganographyConstants.BITS_MASK_2);

            // Encode upper 4 bits into pixel2
            int red2 = (pixel2.R & SteganographyConstants.BITS_CLEAR_2) |
                       ((charValue >> 4) & SteganographyConstants.BITS_MASK_2);
            int green2 = (pixel2.G & SteganographyConstants.BITS_CLEAR_2) |
                         ((charValue >> 6) & SteganographyConstants.BITS_MASK_2);

            // Create modified colors
            Color modifiedPixel1 = Color.FromArgb(pixel1.A, red1, green1, pixel1.B);
            Color modifiedPixel2 = Color.FromArgb(pixel2.A, red2, green2, pixel2.B);

            // Write back
            bitmap.SetPixel(x, y, modifiedPixel1);
            bitmap.SetPixel(x, y + 1, modifiedPixel2);
        }

        /// <summary>
        /// Decodes a character from two pixels
        /// </summary>
        private char DecodeCharacter(Bitmap bitmap, int pixelOffset)
        {
            var (x, y) = CalculatePixelPosition(bitmap, pixelOffset);

            Color pixel1 = bitmap.GetPixel(x, y);
            Color pixel2 = bitmap.GetPixel(x, y + 1);

            int charValue = 0;

            // Extract bits 6-7 from pixel2 green
            charValue |= (pixel2.G & SteganographyConstants.BITS_MASK_2);
            charValue <<= 2;

            // Extract bits 4-5 from pixel2 red
            charValue |= (pixel2.R & SteganographyConstants.BITS_MASK_2);
            charValue <<= 2;

            // Extract bits 2-3 from pixel1 green
            charValue |= (pixel1.G & SteganographyConstants.BITS_MASK_2);
            charValue <<= 2;

            // Extract bits 0-1 from pixel1 red
            charValue |= (pixel1.R & SteganographyConstants.BITS_MASK_2);

            return (char)charValue;
        }

        /// <summary>
        /// Calculates pixel position from offset
        /// </summary>
        private (int x, int y) CalculatePixelPosition(Bitmap bitmap, int offset)
        {
            int centerX = bitmap.Width / 2;
            int centerY = bitmap.Height / 2;
            int halfHeight = bitmap.Height / 2;

            int x = centerX + (offset / halfHeight);
            int y = centerY + (offset % halfHeight);

            return (x, y);
        }

        /// <summary>
        /// Calculates pixels required for a message
        /// </summary>
        private int CalculateRequiredPixels(string message)
        {
            int totalChars = message.Length + SteganographyConstants.MESSAGE_TERMINATOR.Length;
            return totalChars * 2; // 2 pixels per character
        }

        /// <summary>
        /// Calculates available pixels in an image
        /// </summary>
        private int CalculateAvailablePixels(Bitmap image)
        {
            int halfWidth = image.Width / 2;
            int halfHeight = image.Height / 2;
            return halfWidth * halfHeight;
        }

        #endregion
    }
}