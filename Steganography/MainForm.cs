using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Steganography.Core.Encoders;

namespace Steganography
{
    public partial class MainForm : Form
    {
        // Shared processor for both tabs
        private readonly SteganographyProcessor _processor;

        // Encrypt tab fields
        private Bitmap _sourceImage;
        private Bitmap _encodedImage;
        private string _messageToEncode;

        // Decrypt tab fields
        private Bitmap _encryptedImage;
        private string _decryptedMessage;

        public MainForm()
        {
            _processor = new SteganographyProcessor();
            InitializeComponent();
            InitializeCustomUI();
        }

        private void InitializeCustomUI()
        {
            // Set form properties
            this.Text = "Image Steganography";
            this.Size = new Size(950, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Update capacity info when tab changes
            tabControl.SelectedIndexChanged += (s, e) => UpdateUIState();
        }

        #region Encrypt Tab Event Handlers

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                dialog.Title = "Select Carrier Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _sourceImage = new Bitmap(dialog.FileName);
                        encryptPictureBox.Image = _sourceImage;
                        UpdateEncryptCapacity();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error loading image: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (_sourceImage == null)
            {
                MessageBox.Show(
                    "Please select an image first.",
                    "No Image Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            _messageToEncode = encryptMessageTextBox.Text;
            if (string.IsNullOrWhiteSpace(_messageToEncode))
            {
                MessageBox.Show(
                    "Please enter a message to hide.",
                    "No Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Encode the message
                _encodedImage = _processor.Encode(_sourceImage, _messageToEncode);

                // Prompt to save
                SaveEncodedImage();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Encoding Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveEncodedImage()
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "BMP Image|*.bmp|PNG Image|*.png";
                dialog.Title = "Save Encoded Image";
                dialog.FileName = "encoded_image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = Path.GetExtension(dialog.FileName).ToLower() == ".png"
                            ? ImageFormat.Png
                            : ImageFormat.Bmp;

                        _encodedImage.Save(dialog.FileName, format);

                        MessageBox.Show(
                            "✓ Image encoded and saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error saving image: {ex.Message}",
                            "Save Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EncryptMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateEncryptCapacity();
        }

        private void UpdateEncryptCapacity()
        {
            int currentLength = encryptMessageTextBox.Text.Length;
            encryptCharCountLabel.Text = $"{currentLength} characters";

            if (_sourceImage != null)
            {
                int maxLength = _processor.GetMaxMessageLength(_sourceImage);
                bool canEncode = _processor.CanEncode(_sourceImage, encryptMessageTextBox.Text);

                if (!canEncode && currentLength > 0)
                {
                    encryptCharCountLabel.ForeColor = Color.Red;
                    encryptCharCountLabel.Text = $"{currentLength}/{maxLength} characters (too long!)";
                    encryptButton.Enabled = false;
                }
                else
                {
                    encryptCharCountLabel.ForeColor = Color.FromArgb(46, 204, 113);
                    encryptCharCountLabel.Text = $"{currentLength}/{maxLength} characters";
                    encryptButton.Enabled = currentLength > 0;
                }

                encryptCapacityLabel.Text = $"Image capacity: {maxLength} characters";
            }
            else
            {
                encryptCapacityLabel.Text = "No image loaded";
                encryptButton.Enabled = false;
            }
        }

        #endregion

        #region Decrypt Tab Event Handlers

        private void BrowseEncryptedButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg|All Files|*.*";
                dialog.Title = "Select Encrypted Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _encryptedImage = new Bitmap(dialog.FileName);
                        decryptPictureBox.Image = _encryptedImage;
                        decryptButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error loading image: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (_encryptedImage == null)
            {
                MessageBox.Show(
                    "Please select an encrypted image first.",
                    "No Image Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Decode the message
                _decryptedMessage = _processor.Decode(_encryptedImage);
                decryptResultTextBox.Text = _decryptedMessage;

                MessageBox.Show(
                    "✓ Message decrypted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Decryption Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Methods

        private void UpdateUIState()
        {
            if (tabControl.SelectedIndex == 0) // Encrypt tab
            {
                UpdateEncryptCapacity();
            }
        }

        #endregion
    }
}
