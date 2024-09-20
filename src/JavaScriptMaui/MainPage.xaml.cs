namespace JavaScriptMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private WebView webView;

        public MainPage()
        {
            InitializeComponent();

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
                    <h1>Fatorial em JavaScript</h1>
                    <p>Use a função `factorial(num)` no console do navegador para calcular o fatorial de um número.</p>
                    </body>
                    </html>"
                },
                IsVisible = false,
                HeightRequest = 1,
                WidthRequest = 1
            };

            ((VerticalStackLayout)((ScrollView)Content).Content).Children.Add(webView);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void btnJava_Clicked(object sender, EventArgs e)
        {
            try
            {
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

                await Task.Delay(500);

                string result = await webView.EvaluateJavaScriptAsync($"factorial({number})");
                lblResult.Text = $"Factorial of {number} is {result}.";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}