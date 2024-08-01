using System;

using System.Windows;


namespace SuccessfulLoginToWelcomeMessageDisplay
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Password;

            try
            {
                // Simulate a login request; replace this with the actual HTTP request.
                string response = await RestHelper.PostLoginAuth(username, password);

                if (!string.IsNullOrEmpty(response) || response.Contains("SUCCESSFUL"))
                {
                    MessageBox.Show("Login Successful!");

                    // Pass the username to the main window
                    MainWindow mainWindow = new MainWindow(username);
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password..!!");
                    txtUser.Text = null;
                    txtPassword.Password = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
