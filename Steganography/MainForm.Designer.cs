using System.Drawing;
using System.Windows.Forms;

namespace Steganography
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.encryptTab = new System.Windows.Forms.TabPage();
            this.decryptTab = new System.Windows.Forms.TabPage();

            // Encrypt tab controls
            this.encryptHeaderPanel = new System.Windows.Forms.Panel();
            this.encryptHeaderLabel = new System.Windows.Forms.Label();
            this.encryptMainPanel = new System.Windows.Forms.Panel();
            this.encryptTextPanel = new System.Windows.Forms.Panel();
            this.encryptImagePanel = new System.Windows.Forms.Panel();
            this.encryptInfoLabel = new System.Windows.Forms.Label();
            this.encryptMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptCharCountLabel = new System.Windows.Forms.Label();
            this.encryptCapacityLabel = new System.Windows.Forms.Label();
            this.encryptPictureBox = new System.Windows.Forms.PictureBox();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();

            // Decrypt tab controls
            this.decryptHeaderPanel = new System.Windows.Forms.Panel();
            this.decryptHeaderLabel = new System.Windows.Forms.Label();
            this.decryptMainPanel = new System.Windows.Forms.Panel();
            this.decryptImagePanel = new System.Windows.Forms.Panel();
            this.decryptResultPanel = new System.Windows.Forms.Panel();
            this.decryptResultLabel = new System.Windows.Forms.Label();
            this.decryptPictureBox = new System.Windows.Forms.PictureBox();
            this.browseEncryptedButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptResultTextBox = new System.Windows.Forms.RichTextBox();

            this.tabControl.SuspendLayout();
            this.encryptTab.SuspendLayout();
            this.decryptTab.SuspendLayout();
            this.encryptHeaderPanel.SuspendLayout();
            this.encryptMainPanel.SuspendLayout();
            this.encryptTextPanel.SuspendLayout();
            this.encryptImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptPictureBox)).BeginInit();
            this.decryptHeaderPanel.SuspendLayout();
            this.decryptMainPanel.SuspendLayout();
            this.decryptImagePanel.SuspendLayout();
            this.decryptResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.encryptTab);
            this.tabControl.Controls.Add(this.decryptTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(934, 611);
            this.tabControl.TabIndex = 0;

            // 
            // encryptTab
            // 
            this.encryptTab.BackColor = System.Drawing.Color.White;
            this.encryptTab.Controls.Add(this.encryptMainPanel);
            this.encryptTab.Controls.Add(this.encryptHeaderPanel);
            this.encryptTab.Location = new System.Drawing.Point(4, 26);
            this.encryptTab.Name = "encryptTab";
            this.encryptTab.Padding = new System.Windows.Forms.Padding(3);
            this.encryptTab.Size = new System.Drawing.Size(926, 581);
            this.encryptTab.TabIndex = 0;
            this.encryptTab.Text = "🔒 Encrypt Message";

            // 
            // encryptHeaderPanel
            // 
            this.encryptHeaderPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.encryptHeaderPanel.Controls.Add(this.encryptHeaderLabel);
            this.encryptHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.encryptHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.encryptHeaderPanel.Name = "encryptHeaderPanel";
            this.encryptHeaderPanel.Size = new System.Drawing.Size(920, 70);
            this.encryptHeaderPanel.TabIndex = 0;

            // 
            // encryptHeaderLabel
            // 
            this.encryptHeaderLabel.AutoSize = true;
            this.encryptHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.encryptHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.encryptHeaderLabel.Location = new System.Drawing.Point(20, 18);
            this.encryptHeaderLabel.Name = "encryptHeaderLabel";
            this.encryptHeaderLabel.Size = new System.Drawing.Size(330, 37);
            this.encryptHeaderLabel.TabIndex = 0;
            this.encryptHeaderLabel.Text = "Hide Message in Image";

            // 
            // encryptMainPanel
            // 
            this.encryptMainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.encryptMainPanel.Controls.Add(this.encryptTextPanel);
            this.encryptMainPanel.Controls.Add(this.encryptImagePanel);
            this.encryptMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptMainPanel.Location = new System.Drawing.Point(3, 73);
            this.encryptMainPanel.Name = "encryptMainPanel";
            this.encryptMainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.encryptMainPanel.Size = new System.Drawing.Size(920, 505);
            this.encryptMainPanel.TabIndex = 1;

            // 
            // encryptTextPanel
            // 
            this.encryptTextPanel.BackColor = System.Drawing.Color.White;
            this.encryptTextPanel.Controls.Add(this.encryptInfoLabel);
            this.encryptTextPanel.Controls.Add(this.encryptMessageTextBox);
            this.encryptTextPanel.Controls.Add(this.encryptCharCountLabel);
            this.encryptTextPanel.Controls.Add(this.encryptCapacityLabel);
            this.encryptTextPanel.Location = new System.Drawing.Point(20, 20);
            this.encryptTextPanel.Name = "encryptTextPanel";
            this.encryptTextPanel.Size = new System.Drawing.Size(410, 465);
            this.encryptTextPanel.TabIndex = 0;

            // 
            // encryptInfoLabel
            // 
            this.encryptInfoLabel.AutoSize = true;
            this.encryptInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.encryptInfoLabel.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.encryptInfoLabel.Location = new System.Drawing.Point(20, 25);
            this.encryptInfoLabel.Name = "encryptInfoLabel";
            this.encryptInfoLabel.Size = new System.Drawing.Size(252, 20);
            this.encryptInfoLabel.TabIndex = 0;
            this.encryptInfoLabel.Text = "Enter your secret message below:";

            // 
            // encryptMessageTextBox
            // 
            this.encryptMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptMessageTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.encryptMessageTextBox.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.encryptMessageTextBox.Location = new System.Drawing.Point(20, 60);
            this.encryptMessageTextBox.Name = "encryptMessageTextBox";
            this.encryptMessageTextBox.Size = new System.Drawing.Size(370, 320);
            this.encryptMessageTextBox.TabIndex = 1;
            this.encryptMessageTextBox.Text = "";
            this.encryptMessageTextBox.TextChanged += new System.EventHandler(this.EncryptMessageTextBox_TextChanged);

            // 
            // encryptCharCountLabel
            // 
            this.encryptCharCountLabel.AutoSize = true;
            this.encryptCharCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.encryptCharCountLabel.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.encryptCharCountLabel.Location = new System.Drawing.Point(20, 395);
            this.encryptCharCountLabel.Name = "encryptCharCountLabel";
            this.encryptCharCountLabel.Size = new System.Drawing.Size(95, 19);
            this.encryptCharCountLabel.TabIndex = 2;
            this.encryptCharCountLabel.Text = "0 characters";

            // 
            // encryptCapacityLabel
            // 
            this.encryptCapacityLabel.AutoSize = true;
            this.encryptCapacityLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.encryptCapacityLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.encryptCapacityLabel.Location = new System.Drawing.Point(20, 425);
            this.encryptCapacityLabel.Name = "encryptCapacityLabel";
            this.encryptCapacityLabel.Size = new System.Drawing.Size(97, 15);
            this.encryptCapacityLabel.TabIndex = 3;
            this.encryptCapacityLabel.Text = "No image loaded";

            // 
            // encryptImagePanel
            // 
            this.encryptImagePanel.BackColor = System.Drawing.Color.White;
            this.encryptImagePanel.Controls.Add(this.encryptPictureBox);
            this.encryptImagePanel.Controls.Add(this.browseImageButton);
            this.encryptImagePanel.Controls.Add(this.encryptButton);
            this.encryptImagePanel.Location = new System.Drawing.Point(450, 20);
            this.encryptImagePanel.Name = "encryptImagePanel";
            this.encryptImagePanel.Size = new System.Drawing.Size(450, 465);
            this.encryptImagePanel.TabIndex = 1;

            // 
            // encryptPictureBox
            // 
            this.encryptPictureBox.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.encryptPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptPictureBox.Location = new System.Drawing.Point(25, 25);
            this.encryptPictureBox.Name = "encryptPictureBox";
            this.encryptPictureBox.Size = new System.Drawing.Size(400, 300);
            this.encryptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.encryptPictureBox.TabIndex = 0;
            this.encryptPictureBox.TabStop = false;

            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.browseImageButton.FlatAppearance.BorderSize = 0;
            this.browseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseImageButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.browseImageButton.ForeColor = System.Drawing.Color.White;
            this.browseImageButton.Location = new System.Drawing.Point(25, 345);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(400, 50);
            this.browseImageButton.TabIndex = 1;
            this.browseImageButton.Text = "📁 Browse Images";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.BrowseImageButton_Click);

            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.encryptButton.Enabled = false;
            this.encryptButton.FlatAppearance.BorderSize = 0;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.Location = new System.Drawing.Point(25, 405);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(400, 50);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "🔒 Encrypt & Save";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);

            // 
            // decryptTab
            // 
            this.decryptTab.BackColor = System.Drawing.Color.White;
            this.decryptTab.Controls.Add(this.decryptMainPanel);
            this.decryptTab.Controls.Add(this.decryptHeaderPanel);
            this.decryptTab.Location = new System.Drawing.Point(4, 26);
            this.decryptTab.Name = "decryptTab";
            this.decryptTab.Padding = new System.Windows.Forms.Padding(3);
            this.decryptTab.Size = new System.Drawing.Size(926, 581);
            this.decryptTab.TabIndex = 1;
            this.decryptTab.Text = "🔓 Decrypt Message";

            // 
            // decryptHeaderPanel
            // 
            this.decryptHeaderPanel.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.decryptHeaderPanel.Controls.Add(this.decryptHeaderLabel);
            this.decryptHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.decryptHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.decryptHeaderPanel.Name = "decryptHeaderPanel";
            this.decryptHeaderPanel.Size = new System.Drawing.Size(920, 70);
            this.decryptHeaderPanel.TabIndex = 0;

            // 
            // decryptHeaderLabel
            // 
            this.decryptHeaderLabel.AutoSize = true;
            this.decryptHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.decryptHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.decryptHeaderLabel.Location = new System.Drawing.Point(20, 18);
            this.decryptHeaderLabel.Name = "decryptHeaderLabel";
            this.decryptHeaderLabel.Size = new System.Drawing.Size(355, 37);
            this.decryptHeaderLabel.TabIndex = 0;
            this.decryptHeaderLabel.Text = "Extract Hidden Message";

            // 
            // decryptMainPanel
            // 
            this.decryptMainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.decryptMainPanel.Controls.Add(this.decryptImagePanel);
            this.decryptMainPanel.Controls.Add(this.decryptResultPanel);
            this.decryptMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptMainPanel.Location = new System.Drawing.Point(3, 73);
            this.decryptMainPanel.Name = "decryptMainPanel";
            this.decryptMainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.decryptMainPanel.Size = new System.Drawing.Size(920, 505);
            this.decryptMainPanel.TabIndex = 1;

            // 
            // decryptImagePanel
            // 
            this.decryptImagePanel.BackColor = System.Drawing.Color.White;
            this.decryptImagePanel.Controls.Add(this.decryptPictureBox);
            this.decryptImagePanel.Controls.Add(this.browseEncryptedButton);
            this.decryptImagePanel.Controls.Add(this.decryptButton);
            this.decryptImagePanel.Location = new System.Drawing.Point(20, 20);
            this.decryptImagePanel.Name = "decryptImagePanel";
            this.decryptImagePanel.Size = new System.Drawing.Size(450, 465);
            this.decryptImagePanel.TabIndex = 0;

            // 
            // decryptPictureBox
            // 
            this.decryptPictureBox.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.decryptPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decryptPictureBox.Location = new System.Drawing.Point(25, 25);
            this.decryptPictureBox.Name = "decryptPictureBox";
            this.decryptPictureBox.Size = new System.Drawing.Size(400, 300);
            this.decryptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decryptPictureBox.TabIndex = 0;
            this.decryptPictureBox.TabStop = false;

            // 
            // browseEncryptedButton
            // 
            this.browseEncryptedButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.browseEncryptedButton.FlatAppearance.BorderSize = 0;
            this.browseEncryptedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseEncryptedButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.browseEncryptedButton.ForeColor = System.Drawing.Color.White;
            this.browseEncryptedButton.Location = new System.Drawing.Point(25, 345);
            this.browseEncryptedButton.Name = "browseEncryptedButton";
            this.browseEncryptedButton.Size = new System.Drawing.Size(400, 50);
            this.browseEncryptedButton.TabIndex = 1;
            this.browseEncryptedButton.Text = "📁 Browse Encrypted Image";
            this.browseEncryptedButton.UseVisualStyleBackColor = false;
            this.browseEncryptedButton.Click += new System.EventHandler(this.BrowseEncryptedButton_Click);

            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.decryptButton.Enabled = false;
            this.decryptButton.FlatAppearance.BorderSize = 0;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.Location = new System.Drawing.Point(25, 405);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(400, 50);
            this.decryptButton.TabIndex = 2;
            this.decryptButton.Text = "🔓 Decrypt Message";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);

            // 
            // decryptResultPanel
            // 
            this.decryptResultPanel.BackColor = System.Drawing.Color.White;
            this.decryptResultPanel.Controls.Add(this.decryptResultLabel);
            this.decryptResultPanel.Controls.Add(this.decryptResultTextBox);
            this.decryptResultPanel.Location = new System.Drawing.Point(490, 20);
            this.decryptResultPanel.Name = "decryptResultPanel";
            this.decryptResultPanel.Size = new System.Drawing.Size(410, 465);
            this.decryptResultPanel.TabIndex = 1;

            // 
            // decryptResultLabel
            // 
            this.decryptResultLabel.AutoSize = true;
            this.decryptResultLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.decryptResultLabel.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.decryptResultLabel.Location = new System.Drawing.Point(20, 25);
            this.decryptResultLabel.Name = "decryptResultLabel";
            this.decryptResultLabel.Size = new System.Drawing.Size(168, 20);
            this.decryptResultLabel.TabIndex = 0;
            this.decryptResultLabel.Text = "Decrypted Message:";

            // 
            // decryptResultTextBox
            // 
            this.decryptResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptResultTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.decryptResultTextBox.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.decryptResultTextBox.Location = new System.Drawing.Point(20, 60);
            this.decryptResultTextBox.Name = "decryptResultTextBox";
            this.decryptResultTextBox.ReadOnly = true;
            this.decryptResultTextBox.Size = new System.Drawing.Size(370, 385);
            this.decryptResultTextBox.TabIndex = 1;
            this.decryptResultTextBox.Text = "";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Steganography";
            this.tabControl.ResumeLayout(false);
            this.encryptTab.ResumeLayout(false);
            this.decryptTab.ResumeLayout(false);
            this.encryptHeaderPanel.ResumeLayout(false);
            this.encryptHeaderPanel.PerformLayout();
            this.encryptMainPanel.ResumeLayout(false);
            this.encryptTextPanel.ResumeLayout(false);
            this.encryptTextPanel.PerformLayout();
            this.encryptImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.encryptPictureBox)).EndInit();
            this.decryptHeaderPanel.ResumeLayout(false);
            this.decryptHeaderPanel.PerformLayout();
            this.decryptMainPanel.ResumeLayout(false);
            this.decryptImagePanel.ResumeLayout(false);
            this.decryptResultPanel.ResumeLayout(false);
            this.decryptResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage encryptTab;
        private System.Windows.Forms.TabPage decryptTab;

        // Encrypt tab controls
        private System.Windows.Forms.Panel encryptHeaderPanel;
        private System.Windows.Forms.Label encryptHeaderLabel;
        private System.Windows.Forms.Panel encryptMainPanel;
        private System.Windows.Forms.Panel encryptTextPanel;
        private System.Windows.Forms.Panel encryptImagePanel;
        private System.Windows.Forms.Label encryptInfoLabel;
        private System.Windows.Forms.RichTextBox encryptMessageTextBox;
        private System.Windows.Forms.Label encryptCharCountLabel;
        private System.Windows.Forms.Label encryptCapacityLabel;
        private System.Windows.Forms.PictureBox encryptPictureBox;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Button encryptButton;

        // Decrypt tab controls
        private System.Windows.Forms.Panel decryptHeaderPanel;
        private System.Windows.Forms.Label decryptHeaderLabel;
        private System.Windows.Forms.Panel decryptMainPanel;
        private System.Windows.Forms.Panel decryptImagePanel;
        private System.Windows.Forms.Panel decryptResultPanel;
        private System.Windows.Forms.Label decryptResultLabel;
        private System.Windows.Forms.PictureBox decryptPictureBox;
        private System.Windows.Forms.Button browseEncryptedButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.RichTextBox decryptResultTextBox;
    }
}
