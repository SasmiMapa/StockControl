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

        public bool CheckStockExists(string stockCode) {
            var selectQuery = "SELECT COUNT(*) FROM StockItem WHERE StockCode = @codeText";

            using (var selectCommand = new SQLiteCommand(selectQuery, Connection)) {
                selectCommand.Parameters.AddWithValue("@codeText", stockCode);

                var count = Convert.ToInt32(selectCommand.ExecuteScalar());

                return count > 0;
            }
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

        public void InsertTransactionLog(string stockCode, string description) {
            var insertQuery =
                "INSERT INTO TransactionLog(StockID, [Date/Time], Description) VALUES (@codeText, DATETIME('now'), @description)";

            using (var insertCommand = new SQLiteCommand(insertQuery, Connection)) {
                insertCommand.Parameters.AddWithValue("@codeText", stockCode);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.ExecuteNonQuery();
            }
        }
    }
}