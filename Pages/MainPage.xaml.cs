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
using Tortuga.ClassHelper;
using Tortuga.EF;
using TortugaPrianiKaraul.ClassHelper;

namespace TortugaPrianiKaraul.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        bool isFirstItemLv = true;
        public MainPage()
        {
            InitializeComponent();
        }

       

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tbContorl.SelectedIndex)
            {
                case 0:

                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 3).ToList();
                    break;
                case 1:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 1).ToList();
                    break;
                case 2:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 4).ToList();
                    break;
                case 3:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 5).ToList();
                    break;
                case 4:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 2).ToList();
                    break;
                case 5:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 6).ToList();
                    break;
                case 6:
                    lvMenu.ItemsSource = AppData.Context.Menu.Where(i => i.IDCategory == 7).ToList();
                    break;


            }
            isFirstItemLv = true;
        }

        private void lvMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (lvMenu.SelectedValue is Tortuga.EF.Menu)
            {
                var menu = lvMenu.SelectedItem as Tortuga.EF.Menu;
                GlobalParametry.Frame.Navigate(new Tortuga.Pages.PageInfoMenu(menu));
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var menu = button.DataContext as Tortuga.EF.Menu;
            if (ClassHelper.GlobalParametry.basket.Where(i => i.IDMenu == menu.ID).FirstOrDefault() != null)
            {
                ClassHelper.GlobalParametry.Basket changeBasket = ClassHelper.GlobalParametry.basket.Where(i => i.IDMenu == menu.ID).FirstOrDefault();
                if(changeBasket.Qty < 10)
                {
                    changeBasket.Qty += 1;
                }

            }
            else
            {
                ClassHelper.GlobalParametry.Basket basket = new ClassHelper.GlobalParametry.Basket();
                basket.IDMenu = menu.ID;
                basket.Image = menu.Image;
                basket.Name = menu.Name;
                basket.Cost = menu.Cost;
                basket.Qty = 1;
                basket.Description = menu.Description;
                ClassHelper.GlobalParametry.basket.Add(basket);
            }
           


        }

        private void Border_Initialized(object sender, EventArgs e)
        {
            if (isFirstItemLv)
            {
                Border border = sender as Border;
                Thickness margin = border.Margin;
                margin.Top = 0;
                border.Margin = margin;
            }
            isFirstItemLv = false;


        }
    }
}
