using System.Collections.Generic;
using System.Data.SQLite;

namespace StockControl.View {
    public class YourDataModel {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Quantity { get; set; }
    }

    public partial class ViewStocks {
        public ViewStocks() {
            InitializeComponent();
            DataContext = this;
            var myList = new List<YourDataModel>();

            var connectionString =
                "Data Source=C:\\Users\\VCT\\RiderProjects\\StockControl\\StockItem.sqlite;Version=3;";

            using (var connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                var selectQuery = "SELECT StockCode, StockName, Quantity FROM StockItem";

                using (var selectCommand = new SQLiteCommand(selectQuery, connection)) {
                    using (var reader = selectCommand.ExecuteReader()) {
                        while (reader.Read()) {
                            var stockCode = reader.GetString(0);
                            var stockName = reader.GetString(1);
                            var quantity = reader.GetInt32(2).ToString();

                            myList.Add(new YourDataModel
                                { StockCode = stockCode, StockName = stockName, Quantity = quantity });
                        }
                    }
                }

                connection.Close();
            }

            dataGrid.ItemsSource = myList;
        }
    }
}