using System.Data.SQLite;

namespace StockControl {
    public abstract class DatabaseConnection {
        protected DatabaseConnection(string connectionString) {
            Connection = new SQLiteConnection(connectionString);
        }

        protected SQLiteConnection Connection { get; }

        public void Open() {
            Connection.Open();
        }

        public void Close() {
            Connection.Close();
        }
    }
}