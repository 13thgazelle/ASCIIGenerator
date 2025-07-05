# ASCIIGenerator 🎨

![ASCIIGenerator](https://img.shields.io/badge/ASCIIGenerator-v1.0.0-blue.svg) ![GitHub release](https://img.shields.io/github/release/13thgazelle/ASCIIGenerator.svg) ![License](https://img.shields.io/badge/license-MIT-green.svg)

## Overview

Welcome to **ASCIIGenerator**, a simple yet powerful C# console application designed to transform your images into stunning ASCII art. This tool provides an easy way to convert any image into a text-based representation, making it perfect for terminal enthusiasts, artists, and anyone who enjoys working with text art.

## Features

- **Image to ASCII Conversion**: Convert images into ASCII art quickly and easily.
- **Adjustable Width**: Control the width of the output to fit your needs.
- **Color Inversion**: Optionally invert colors to enhance detail and contrast in the output.
- **Console Application**: A straightforward command-line interface that is easy to use.

## Getting Started

To get started with ASCIIGenerator, download the latest release from the [Releases section](https://github.com/13thgazelle/ASCIIGenerator/releases). Follow the instructions below to set it up and start generating ASCII art.

### Prerequisites

- .NET Core SDK (version 3.1 or later)
- A console or terminal to run the application

### Installation

1. Download the latest release from the [Releases section](https://github.com/13thgazelle/ASCIIGenerator/releases).
2. Extract the downloaded files to a folder of your choice.
3. Open your console or terminal.
4. Navigate to the folder where you extracted the files.

### Running the Application

To run the application, use the following command:

```bash
dotnet ASCIIGenerator.dll <path_to_image> --width <desired_width> --invert
```

- Replace `<path_to_image>` with the path to your image file.
- Replace `<desired_width>` with the width you want for the ASCII output.
- Use the `--invert` flag if you want to invert the colors.

### Example Command

```bash
dotnet ASCIIGenerator.dll myimage.jpg --width 100 --invert
```

This command will convert `myimage.jpg` to ASCII art with a width of 100 characters and inverted colors.

## Usage

ASCIIGenerator is designed to be user-friendly. Here’s how you can use it effectively:

1. **Choose an Image**: Select an image you want to convert.
2. **Decide on the Width**: Determine how wide you want the ASCII art to be.
3. **Run the Command**: Use the command line to run the application with your chosen settings.

### Example Output

Here’s an example of what the output might look like:

```
        .--.
       |o_o |
       |:_/ |
      //   \ \
     (|     | )
    /'\_   _/`\
    \___)=(___/
```

## Customization Options

### Adjustable Width

You can set the width of the ASCII art output to suit your terminal or preference. The application will automatically scale the ASCII representation based on the width you specify.

### Color Inversion

The color inversion feature allows you to enhance the visibility of your ASCII art. This is particularly useful for images with low contrast.

## Contributing

We welcome contributions to ASCIIGenerator! If you want to help improve the project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push your changes to your fork.
5. Create a pull request.

Please ensure that your code adheres to the project's coding standards and includes appropriate tests.

## License

ASCIIGenerator is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Topics

- art-generator
- ascii
- ascii-art
- cli
- command-line-tool
- commandline
- commandline-interface
- console-application
- csharp
- dotnet
- git
- image-processing
- image-to-ascii
- opensource
- opensource-projects
- script
- terminal
- text-art

## Support

If you encounter any issues or have questions, feel free to open an issue in the repository. You can also check the [Releases section](https://github.com/13thgazelle/ASCIIGenerator/releases) for updates and new features.

## Acknowledgments

Thanks to the open-source community for their contributions and support. Special thanks to those who have provided feedback and suggestions for improving ASCIIGenerator.

## Conclusion

ASCIIGenerator is a straightforward tool that brings your images to life in a unique way. Whether you're creating art for fun or for a project, this application provides the functionality you need. Download it today from the [Releases section](https://github.com/13thgazelle/ASCIIGenerator/releases) and start creating!

---

Feel free to explore the code, contribute, and enjoy generating ASCII art!