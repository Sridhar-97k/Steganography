# Image Steganography

A C# Windows Forms application that hides secret text messages within images using LSB (Least Significant Bit) steganography.

## Features

- **Unified Interface**: Single application with tabbed design for encryption and decryption
- **LSB Steganography**: Encodes data in the 2 least significant bits of RGB color channels
- **Real-time Validation**: Shows message capacity and prevents oversized messages
- **Modern UI**: Clean, flat design with color-coded tabs
- **Separated Architecture**: Business logic in Core library, UI in separate layer

## How It Works

The application uses 2-bit LSB encoding across two pixels per character:
- Each character (8 bits) is split across Red and Green channels of two consecutive pixels
- Pixels are modified starting from the image center
- A terminator marker (`*#*`) indicates message end
- Changes are imperceptible to the human eye

## Project Structure
```
Steganography/
├── Steganography/              # Windows Forms UI
│   ├── MainForm.cs            # Main tabbed interface
│   └── Program.cs
│
└── Steganography.Core/         # Business Logic Library
    ├── Constants/
    │   └── SteganographyConstants.cs
    └── Encoders/
        └── SteganographyProcessor.cs
```

## Requirements

- .NET Framework 4.7.2 or higher
- Windows OS
- Visual Studio 2019 or later (for development)

## Usage

### Encrypting a Message

1. Open the **Encrypt Message** tab
2. Click **Browse Images** and select a carrier image
3. Enter your secret message in the text box
4. Click **Encrypt & Save**
5. Save the encoded image

### Decrypting a Message

1. Open the **Decrypt Message** tab
2. Click **Browse Encrypted Image** and select an encoded image
3. Click **Decrypt Message**
4. The hidden message will be displayed

## Technical Details

### Encoding Algorithm
- Uses 2 pixels per character (8 bits total)
- Pixel 1: Bits 0-3 in Red and Green channels
- Pixel 2: Bits 4-7 in Red and Green channels
- Supports standard ASCII characters

### Image Capacity
Maximum message length depends on image size:
```
Max Characters = (Width/2 × Height/2) / 2
```

### Supported Formats
- **Input**: JPG, JPEG, PNG, BMP
- **Output**: BMP, PNG (lossless formats recommended)

## Architecture

Built following SOLID principles:
- **Single Responsibility**: Separated UI from business logic
- **Open/Closed**: Extensible for new encoding methods
- **Clean Architecture**: Core library independent of UI framework

## Limitations

- JPEG compression may corrupt hidden data (use BMP or PNG)
- Maximum message size depends on carrier image dimensions
- No password protection (future enhancement)

## Future Improvements

- [ ] Password-protected encryption
- [ ] Support for hiding files (not just text)
- [ ] Alternative encoding algorithms (4-bit LSB, alpha channel)
- [ ] Batch processing
- [ ] Cross-platform support (.NET Core)

## License

This project is open source and available for educational purposes.

## Author

Created as a learning project to demonstrate:
- Steganography techniques
- C# Windows Forms development
- Separation of concerns
- Modern UI design principles