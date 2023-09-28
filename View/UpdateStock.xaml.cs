using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using StockControl.Models;
using StockControl.ViewModels;

namespace StockControl.View {
    public partial class UpdateStock {
        private string oldCodeText;
        private string oldNameText;

        public UpdateStock() {
            InitializeComponent();
            CodeText.TextChanged += CodeText_TextChanged;
            QuantityText.TextChanged += QuantityText_TextChanged;
            NameText.TextChanged += NameText_TextChanged;
            UpdateButtonState();
        }

        private void CodeText_TextChanged(object sender, TextChangedEventArgs e) {
            var newCodeText = CodeText.Text;

            if (newCodeText != oldCodeText) {
                string stockName;
                string quantity;

                var connectionString =
                    "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

                using (var connection = new StockItemDatabase(connectionString)) {
                    connection.Open();

                    connection.GetStockDetails(newCodeText, out stockName, out quantity);

                    NameText.Text = stockName;
                    QuantityText.Text = quantity;

                    oldCodeText = newCodeText;

                    connection.Close();
                }
            }

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

            var stockItemExists = false;

            if (!isAnyTextInputBlank) {
                var connectionString =
                    "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

                using (var connection = new StockItemDatabase(connectionString)) {
                    connection.Open();

                    stockItemExists = connection.CheckStockExists(codeText);

                    connection.Close();
                }
            }

            if ((string)CodeError.Content != string.Empty || (string)QuantityError.Content != string.Empty ||
                (string)NameError.Content != string.Empty || isAnyTextInputBlank) {
                AddButton.IsEnabled = false;
                RemoveButton.IsEnabled = false;
            }
            else if (stockItemExists) {
                AddButton.IsEnabled = false;
                if (quantity == "0")
                    RemoveButton.IsEnabled = true;
                else
                    RemoveButton.IsEnabled = false;
            }
            else {
                RemoveButton.IsEnabled = false;
                AddButton.IsEnabled = true;
            }
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
                    AddButton.IsEnabled = false;
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

        private void RemoveItem(object sender, EventArgs e) {
            var codeText = CodeText.Text;
            var description = "Item removed";

            var connectionString =
                "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

            using (var connection = new StockItemDatabase(connectionString)) {
                connection.Open();

                if (connection.CheckStockExists(codeText)) {
                    var stockName = string.Empty;
                    var quantity = string.Empty;

                    connection.GetStockDetails(codeText, out stockName, out quantity);

                    NameText.Text = stockName;
                    QuantityText.Text = quantity;

                    if (int.TryParse(quantity, out var quantityValue) && quantityValue == 0) {
                        connection.RemoveStockItem(codeText);
                        connection.InsertRemovalLog(codeText, stockName, quantityValue, description);

                        StatusMessage.Content = "Item successfully removed";
                    }
                    else {
                        StatusMessage.Content = "Item does not have 0 quantity";
                    }
                }

                connection.Close();
            }
        }


        private void HomeClick(object sender, EventArgs e) {
            var secondForm = new Dashboard();
            secondForm.Show();
            Close();
        }
    }
}