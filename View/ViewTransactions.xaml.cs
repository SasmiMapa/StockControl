using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace StockControl.View {
    public class TransactionModel {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
    }

    public partial class ViewTransactions {
        public ViewTransactions() {
            InitializeComponent();
            DataContext = this;
            var myList1 = new List<TransactionModel>();

            var connectionString =
                "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

            using (var connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                var selectQuery = "SELECT StockID, StockName, Quantity, DateTime, Description FROM TransactionLog";

                using (var selectCommand = new SQLiteCommand(selectQuery, connection)) {
                    using (var reader = selectCommand.ExecuteReader()) {
                        while (reader.Read()) {
                            var stockCode = reader.GetString(0);
                            var stockName = reader.GetString(1);
                            var quantity = reader.GetInt32(2).ToString();
                            var date = reader.GetString(3);
                            var desc = reader.GetString(4);

                            myList1.Add(new TransactionModel {
                                StockCode = stockCode, StockName = stockName, Quantity = quantity, Description = desc,
                                DateTime = date
                            });
                        }
                    }
                }

                connection.Close();
            }

            dataGrid1.ItemsSource = myList1;
        }

        private void HomeClick(object sender, EventArgs e) {
            var secondForm = new Dashboard();
            secondForm.Show();
            Close();
        }
    }
}