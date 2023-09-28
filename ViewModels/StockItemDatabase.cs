using System;
using System.Data.SQLite;

namespace StockControl.ViewModels {
    public class StockItemDatabase : DatabaseConnection, IDisposable {
        public StockItemDatabase(string connectionString) : base(connectionString) {
        }

        public void Dispose() {
            Connection.Close();
            Connection.Dispose();
        }

        public void InsertStockItem(string stockCode, string stockName, int quantity) {
            var insertQuery =
                "INSERT INTO StockItem(StockCode, StockName, Quantity) VALUES (@codeText, @nameText, @quantity)";

            using (var insertCommand = new SQLiteCommand(insertQuery, Connection)) {
                insertCommand.Parameters.AddWithValue("@codeText", stockCode);
                insertCommand.Parameters.AddWithValue("@nameText", stockName);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.ExecuteNonQuery();
            }
        }

        public void InsertTransactionLog(string stockCode, string stockName, int quantity, string description) {
            var insertQuery =
                "INSERT INTO TransactionLog(StockID, StockName, Quantity, DateTime, Description) VALUES (@codeText, @nameText, @quantity, DATETIME('now'), @description)";

            using (var insertCommand = new SQLiteCommand(insertQuery, Connection)) {
                insertCommand.Parameters.AddWithValue("@codeText", stockCode);
                insertCommand.Parameters.AddWithValue("@nameText", stockName);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.ExecuteNonQuery();
            }
        }

        public void RemoveStockItem(string stockCode) {
            var updateQuery =
                "UPDATE StockItem SET StockCode = NULL, StockName = NULL, Quantity = NULL WHERE StockCode = @codeText";

            using (var updateCommand = new SQLiteCommand(updateQuery, Connection)) {
                updateCommand.Parameters.AddWithValue("@codeText", stockCode);
                updateCommand.ExecuteNonQuery();
            }
        }

        public void InsertRemovalLog(string stockCode, string stockName, int quantity, string description) {
            var insertQuery =
                "INSERT INTO TransactionLog(StockID, StockName, Quantity, DateTime, Description) VALUES (@codeText, @nameText, @quantity, DATETIME('now'), @description)";

            using (var insertCommand = new SQLiteCommand(insertQuery, Connection)) {
                insertCommand.Parameters.AddWithValue("@codeText", stockCode);
                insertCommand.Parameters.AddWithValue("@nameText", stockName);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.ExecuteNonQuery();
            }
        }

        public bool CheckStockExists(string stockCode) {
            var selectQuery = "SELECT StockName, Quantity FROM StockItem WHERE StockCode = @codeText";

            using (var selectCommand = new SQLiteCommand(selectQuery, Connection)) {
                selectCommand.Parameters.AddWithValue("@codeText", stockCode);

                using (var reader = selectCommand.ExecuteReader()) {
                    if (reader.Read()) {
                        var stockName = reader.GetString(0);
                        var quantity = reader.GetInt32(1).ToString();

                        return true;
                    }
                }
            }

            return false;
        }

        public void GetStockDetails(string stockCode, out string stockName, out string quantity) {
            var selectQuery = "SELECT StockName, Quantity FROM StockItem WHERE StockCode = @codeText";

            using (var selectCommand = new SQLiteCommand(selectQuery, Connection)) {
                selectCommand.Parameters.AddWithValue("@codeText", stockCode);

                using (var reader = selectCommand.ExecuteReader()) {
                    if (reader.Read()) {
                        stockName = reader.GetString(0);
                        quantity = reader.GetInt32(1).ToString();
                    }
                    else {
                        stockName = string.Empty;
                        quantity = string.Empty;
                    }
                }
            }
        }
    }
}