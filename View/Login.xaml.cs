using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace StockControl.View {
    public partial class Login {
        public Login() {
            InitializeComponent();
            UpdateButtonState();
            userName.TextChanged += userName_TextChanged;
            passWord.TextChanged += passWord_TextChanged;
        }

        private void userName_TextChanged(object sender, TextChangedEventArgs e) {
            UpdateButtonState();
        }

        private void passWord_TextChanged(object sender, TextChangedEventArgs e) {
            UpdateButtonState();
        }


        private void UpdateButtonState() {
            var username = userName.Text;
            var password = passWord.Text;

            var isAnyTextInputBlank = string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);

            if (isAnyTextInputBlank)
                LogInButton.IsEnabled = false;
            else
                LogInButton.IsEnabled = true;
        }

        private void Login_Click(object sender, RoutedEventArgs e) {
            var username = userName.Text;
            var password = passWord.Text;

            var connectionString =
                "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;";

            using (var connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                var query = "SELECT UserName, Password FROM User";

                using (var selectCommand = new SQLiteCommand(query, connection)) {
                    using (var reader = selectCommand.ExecuteReader()) {
                        if (reader.Read()) {
                            var Username = reader.GetString(0);
                            var Password = reader.GetString(1);

                            if (username == Username && password == Password) {
                                var nextForm = new Dashboard();
                                nextForm.Show();

                                Close();
                            }
                            else {
                                ErrorMessage.Content = "Invalid username or password";
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}