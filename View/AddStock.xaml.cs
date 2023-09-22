using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using StockControl.Models;
using StockControl.ViewModels;

namespace StockControl.View {
    public partial class AddStock {
        public AddStock() {
            InitializeComponent();
            CodeText.TextChanged += CodeText_TextChanged;
            QuantityText.TextChanged += QuantityText_TextChanged;
            NameText.TextChanged += NameText_TextChanged;
            UpdateButtonState();
        }

        private void CodeText_TextChanged(object sender, TextChangedEventArgs e) {
            var regex = new Regex("^[a-zA-Z0-9]*$");
            if (!regex.IsMatch(CodeText.Text)) {
                CodeText.Text = Regex.Replace(CodeText.Text, "[^a-zA-Z0-9]", "");
                CodeError.Content = "Only letters and numbers are allowed";
            }
            else {
                CodeError.Content = string.Empty;
            }

            UpdateButtonState();
        }

        private void QuantityText_TextChanged(object sender, TextChangedEventArgs e) {
            var regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(QuantityText.Text)) {
                QuantityText.Text = Regex.Replace(QuantityText.Text, "[^0-9]", "");
                QuantityError.Content = "Only numbers are allowed";
            }
            else {
                QuantityError.Content = string.Empty;
            }

            UpdateButtonState();
        }

        private void NameText_TextChanged(object sender, TextChangedEventArgs e) {
            var regex = new Regex("^[a-zA-Z]*$");
            if (!regex.IsMatch(NameText.Text)) {
                NameText.Text = Regex.Replace(NameText.Text, "[^a-zA-Z]", "");
                NameError.Content = "Only letters are allowed";
            }
            else {
                NameError.Content = string.Empty;
            }

            UpdateButtonState();
        }

        private void UpdateButtonState() {
            var codeText = CodeText.Text;
            var nameText = NameText.Text;
            var quantity = QuantityText.Text;

            var isAnyTextInputBlank = string.IsNullOrWhiteSpace(codeText) || string.IsNullOrWhiteSpace(nameText) ||
                                      string.IsNullOrWhiteSpace(quantity);

            if ((string)CodeError.Content != string.Empty || (string)QuantityError.Content != string.Empty ||
                (string)NameError.Content != string.Empty || isAnyTextInputBlank)
                AddButton.IsEnabled = false;
            else
                AddButton.IsEnabled = true;
        }

        private void AddItem(object sender, EventArgs e) {
            var codeText = CodeText.Text;
            var nameText = NameText.Text;
            var quantity = int.Parse(QuantityText.Text);
            var description = "Item added";

            var connectionString =
                "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

            using (var connection = new StockItemDatabase(connectionString)) {
                connection.Open();

                StatusMessage.Content = string.Empty;

                if (connection.CheckStockExists(codeText)) {
                    CodeError.Content = "Stock already exists";
                }
                else {
                    var stockItem = new StockItems(codeText, nameText, quantity);

                    connection.InsertStockItem(stockItem.Code, stockItem.Name, stockItem.Quantity);
                    connection.InsertTransactionLog(stockItem.Code, stockItem.Name, stockItem.Quantity, description);

                    StatusMessage.Content = "Item successfully added";
                }

                connection.Close();
            }
        }
    }
}