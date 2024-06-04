using System.Windows.Forms.VisualStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Cursov
{



    public partial class Form1 : Form
    {
        private TradingSystem tradingSystem = new TradingSystem();

        public Form1()
        {
            InitializeComponent();
            cmbOrderType.Items.Add(OrderType.Buy);
            cmbOrderType.Items.Add(OrderType.Sell);
            cmbUsers.DisplayMember = "Name"; // ”казываем, что отображать в ComboBox
        }



        private void btnRegisterUser_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (!string.IsNullOrEmpty(userName))
            {
                User user = new User { Id = tradingSystem.Users.Count + 1, Name = userName };
                tradingSystem.RegisterUser(user);
                cmbUsers.Items.Add(user);
                MessageBox.Show($"User {userName} registered.");
                txtUserName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a user name.");
            }

        }

        private void btnAddStock_Click_1(object sender, EventArgs e)
        {
            string stockSymbol = txtStockSymbol.Text;
            if (double.TryParse(txtStockPrice.Text, out double stockPrice))
            {
                Stock stock = new Stock { Symbol = stockSymbol, Price = stockPrice };
                tradingSystem.AddStock(stock);
                MessageBox.Show($"Stock {stockSymbol} added.");
                txtStockSymbol.Clear();
                txtStockPrice.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid stock price.");
            }

        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User user && cmbOrderType.SelectedItem is OrderType orderType)
            {
                string stockSymbol = txtOrderStockSymbol.Text;
                if (int.TryParse(txtOrderQuantity.Text, out int quantity))
                {
                    Stock stock = tradingSystem.Stocks.FirstOrDefault(s => s.Symbol == stockSymbol);
                    if (stock != null)
                    {
                        Order order = new Order { User = user, Stock = stock, Quantity = quantity, OrderType = orderType };
                        tradingSystem.PlaceOrder(order);
                        tradingSystem.ExecuteOrders();
                        MessageBox.Show($"Order placed: {orderType} {quantity} shares of {stockSymbol}.");
                        txtOrderStockSymbol.Clear();
                        txtOrderQuantity.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Stock not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user and order type.");
            }

        }

        private void btnShowHoldings_Click_1(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User user)
            {
                lstUserHoldings.Items.Clear();
                var holdings = tradingSystem.GetUserHoldings(user);
                foreach (var holding in holdings)
                {
                    lstUserHoldings.Items.Add($"{holding.Stock.Symbol}: {holding.Quantity} shares");
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }

        }

        
    }

    public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<StockHolding> Holdings { get; set; } = new List<StockHolding>();

            public override string ToString()
            {
                return Name;
            }
        }

        public class Stock
        {
            public string Symbol { get; set; }
            public double Price { get; set; }
        }

        public class StockHolding
        {
            public Stock Stock { get; set; }
            public int Quantity { get; set; }
        }

        public class Order
        {
            public User User { get; set; }
            public Stock Stock { get; set; }
            public int Quantity { get; set; }
            public OrderType OrderType { get; set; }
        }

        public enum OrderType
        {
            Buy,
            Sell
        }

        public class TradingSystem
        {
            public List<User> Users { get; private set; } = new List<User>();
            public List<Stock> Stocks { get; private set; } = new List<Stock>();
            private List<Order> orders = new List<Order>();

            public void RegisterUser(User user)
            {
                Users.Add(user);
            }

            public void AddStock(Stock stock)
            {
                Stocks.Add(stock);
            }

            public void PlaceOrder(Order order)
            {
                orders.Add(order);
            }

            public void ExecuteOrders()
            {
                foreach (var order in orders)
                {
                    if (order.OrderType == OrderType.Buy)
                    {
                        var holding = order.User.Holdings.FirstOrDefault(h => h.Stock.Symbol == order.Stock.Symbol);
                        if (holding == null)
                        {
                            holding = new StockHolding { Stock = order.Stock, Quantity = order.Quantity };
                            order.User.Holdings.Add(holding);
                        }
                        else
                        {
                            holding.Quantity += order.Quantity;
                        }
                    }
                    else if (order.OrderType == OrderType.Sell)
                    {
                        var holding = order.User.Holdings.FirstOrDefault(h => h.Stock.Symbol == order.Stock.Symbol);
                        if (holding != null && holding.Quantity >= order.Quantity)
                        {
                            holding.Quantity -= order.Quantity;
                        }
                    }
                }

                orders.Clear();
            }

            public List<StockHolding> GetUserHoldings(User user)
            {
                return user.Holdings;
            }
        }
    }



