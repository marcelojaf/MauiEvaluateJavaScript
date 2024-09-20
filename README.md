# MAUI JavaScript Integration Demo

This project demonstrates how to execute JavaScript code within a .NET MAUI (Multi-platform App UI) application. It showcases the integration of web technologies in a cross-platform mobile app, using a simple factorial calculator as an example.

## Project Overview

The main goal of this application is to illustrate how .NET MAUI can execute JavaScript code and retrieve the results of that execution. This is achieved using a WebView component, which loads a custom HTML/JavaScript page and allows interaction between the C# code and the JavaScript functions.

## Key Features

- Integration of JavaScript in a .NET MAUI app
- Execution of JavaScript functions from C# code
- Retrieval and display of JavaScript execution results
- Simple user interface for input and output
- Error handling and input validation

## How It Works

1. The app initializes a WebView with a custom HTML page containing JavaScript functions.
2. User input is collected through the MAUI UI.
3. When the user requests a calculation, the app validates the input.
4. The app then uses the WebView to execute the appropriate JavaScript function.
5. The result from the JavaScript execution is retrieved and displayed to the user.

## Technologies Used

- .NET MAUI
- C#
- XAML
- JavaScript
- WebView

## Project Structure

- `MainPage.xaml`: Contains the UI layout for the app
- `MainPage.xaml.cs`: Contains the logic for handling user input and JavaScript integration
- WebView (in code): Loads the HTML/JavaScript and facilitates the execution of JavaScript functions

## Getting Started

### Prerequisites

- Visual Studio 2022 with .NET MAUI workload installed
- .NET 6.0 SDK or later

### Running the App

1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Select your target platform (Android, iOS, or Windows)
4. Press F5 or click the "Run" button in Visual Studio

## Extending the Project

This demo uses a factorial calculator as an example, but the same principles can be applied to execute various JavaScript functions within a MAUI app. Some ideas for extension include:

- Implementing more complex mathematical operations
- Adding string manipulation functions
- Creating a multi-function calculator
- Demonstrating Ajax calls (simulated or to actual APIs) within the WebView

## Contributing

Contributions are welcome! Feel free to submit pull requests or open issues to suggest improvements or report bugs.

## Acknowledgments

- Thanks to the .NET MAUI team for providing a powerful cross-platform development framework
- Inspired by the need to demonstrate seamless integration of web technologies in mobile apps
