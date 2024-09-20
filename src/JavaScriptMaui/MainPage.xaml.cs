namespace JavaScriptMaui
{
    /// <summary>
    /// Main page of the Factorial Calculator application.
    /// This page allows users to input a number and calculate its factorial using JavaScript.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        private readonly WebView webView;

        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// Sets up the WebView with the factorial calculation JavaScript function.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            // Initialize WebView with JavaScript function
            webView = new WebView
            {
                Source = new HtmlWebViewSource
                {
                    Html = @"
                    <html>
                    <body>
                    <script type='text/javascript'>
                    function factorial(num) {
                        if (num === 0 || num === 1)
                            return 1;
                        for (var i = num - 1; i >= 1; i--) {
                            num *= i;
                        }
                        return num;
                    }
                    </script>
                    </body>
                    </html>"
                },
                IsVisible = false,
                HeightRequest = 1,
                WidthRequest = 1
            };

            // Add WebView to the page
            ((VerticalStackLayout)((ScrollView)Content).Content).Children.Add(webView);
        }

        /// <summary>
        /// Handles the click event of the Calculate button.
        /// Validates user input, calculates the factorial, and displays the result.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private async void btnCalculate_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Validate user input
                if (string.IsNullOrWhiteSpace(txtNumber.Text))
                {
                    await DisplayAlert("Error", "Please enter a number", "OK");
                    return;
                }

                if (!int.TryParse(txtNumber.Text, out int number))
                {
                    await DisplayAlert("Error", "Please enter a valid integer", "OK");
                    return;
                }

                // Ensure WebView is loaded
                await Task.Delay(500);

                // Calculate factorial using JavaScript
                string result = await webView.EvaluateJavaScriptAsync($"factorial({number})");

                // Display result
                lblResult.Text = $"Factorial of {number} is {result}";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }
    }
}