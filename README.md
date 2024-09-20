# MAUI Factorial Calculator

This project is a cross-platform mobile application built with .NET MAUI (Multi-platform App UI) that demonstrates the integration of JavaScript within a MAUI app. The app allows users to calculate the factorial of a given number using a JavaScript function executed within a WebView.

## Features

- Simple and intuitive user interface
- Input validation for user entries
- JavaScript integration for factorial calculation
- Error handling and user feedback
- Cross-platform compatibility (iOS, Android, Windows)

## Technologies Used

- .NET MAUI
- C#
- XAML
- JavaScript
- WebView

## Getting Started

### Prerequisites

- Visual Studio 2022 with .NET MAUI workload installed
- .NET 6.0 SDK or later

### Installation

1. Clone the repository
   ```
   git clone https://github.com/marcelojaf/MauiEvaluateJavaScript.git
   ```
2. Open the solution in Visual Studio 2022
3. Restore NuGet packages
4. Build the solution

### Running the App

1. Select your target platform (Android, iOS, or Windows)
2. Press F5 or click the "Run" button in Visual Studio

## How It Works

1. The app uses a WebView to load a simple HTML page containing a JavaScript function for factorial calculation.
2. When the user enters a number and clicks the "Calculate Factorial" button, the app validates the input.
3. If the input is valid, the app uses the WebView to execute the JavaScript function and calculate the factorial.
4. The result is then displayed to the user.

## Project Structure

- `MainPage.xaml`: Contains the UI layout for the app
- `MainPage.xaml.cs`: Contains the logic for handling user input and JavaScript integration

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Acknowledgments

- Thanks to the .NET MAUI team for providing a great cross-platform development framework
- Inspired by the need for simple demonstrations of JavaScript integration in MAUI apps
