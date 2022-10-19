using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TortugaPrianiKaraul.ClassHelper;
using TortugaPrianiKaraul.Pages;
using Tortuga.Pages;
using Tortuga.EF;
using Tortuga.ClassHelper;

namespace TortugaPrianiKaraul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a=1;
        public MainWindow()
        {
            InitializeComponent();
            GlobalParametry.Frame = MainFrame;
            GlobalParametry.stackPanel = spButton;
            MainFrame.Navigate(new Pages.InactionPage());
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
            if (ClassHelper.GlobalParametry.basket.Count == 0)
            {
                btnPurchase.Visibility = Visibility.Hidden;
            }
            else
            {
                btnPurchase.Visibility = Visibility.Visible;
            }
            lvBasket.ItemsSource = null;
            lvBasket.ItemsSource = TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket;
            tbPrice.Text = (TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket.Sum(s => s.finalCost)).ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.GoBack();
            string a = MainFrame.Content.ToString();
            if (MainFrame.Content.ToString() == "TortugaPrianiKaraul.Pages.MainPage")
            {
                GlobalParametry.stackPanel.Visibility = Visibility.Hidden;
            }
             
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            var basket = button.DataContext as ClassHelper.GlobalParametry.Basket;
            if (basket.Qty < 10)
            {

                basket.Qty += 1;
            }
            lvBasket.ItemsSource = null;
            lvBasket.ItemsSource = TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket;
            tbPrice.Text = (TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket.Sum(s => s.finalCost)).ToString();


        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var basket = button.DataContext as ClassHelper.GlobalParametry.Basket;
            if (basket.Qty > 0)
            {
                basket.Qty -= 1;
            }
            if (basket.Qty == 0)
            {
                ClassHelper.GlobalParametry.basket.Remove(basket);
            }
            lvBasket.ItemsSource = null;
            lvBasket.ItemsSource = TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket;
            tbPrice.Text = (TortugaPrianiKaraul.ClassHelper.GlobalParametry.basket.Sum(s => s.finalCost)).ToString();


        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (ClassHelper.GlobalParametry.basket.Count != 0)
            {
                Order order = new Order();
                order.IDTable = ClassHelper.GlobalParametry.idTable;
                order.FInalCost = Convert.ToDecimal(tbPrice.Text);
                AppData.Context.Order.Add(order);
                AppData.Context.SaveChanges();

                foreach (var menu in ClassHelper.GlobalParametry.basket)
                {

                    OrderMenu orderMenu = new OrderMenu();
                    orderMenu.IDOrder = order.ID;
                    orderMenu.IDMenu = menu.IDMenu;
                    orderMenu.Qty = menu.Qty;
                    AppData.Context.OrderMenu.Add(orderMenu);
                    AppData.Context.SaveChanges();
                }
                MessageBox.Show("Спасибо что выбрали нас !");
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }

           


        }
    }
}
