using System;

namespace StockControl.View {
    public partial class Dashboard {
        public Dashboard() {
            InitializeComponent();
        }

        private void AddItemsClick(object sender, EventArgs e) {
            var secondForm = new AddStock();
            secondForm.Show();
            Close();
        }

        private void ViewItemsClick(object sender, EventArgs e) {
            var secondForm = new ViewStocks();
            secondForm.Show();
            Close();
        }
    }
}