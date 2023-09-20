namespace StockControl.Models {
    public class StockItems {
        public StockItems(string code, string name, int quantity) {
            Code = code;
            Name = name;
            Quantity = quantity;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}