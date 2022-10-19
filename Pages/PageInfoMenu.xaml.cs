using System;
using System.Collections.Generic;
using System.IO;
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

namespace Tortuga.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageInfoMenu.xaml
    /// </summary>
    public partial class PageInfoMenu : Page
    {
        public PageInfoMenu(EF.Menu menu)
        {
            InitializeComponent();
            if (menu.IsDishes == false)
            {
                tbUnit.Text = "Мл:";
                tbGram.Text = menu.Mililiters.ToString();
            }
            else
            {
                tbUnit.Text = "Грамм:";
                tbGram.Text = menu.Gram.ToString();
            }
            if(menu.Image != null)
            {
                MemoryStream byteStream = new MemoryStream(menu.Image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                imgMenu.Source = image;
            }
            tbNameMenu.Text = menu.Name;
            tbDescription.Text = menu.Description;
            tbPrice.Text = menu.Cost.ToString();
            tbProtein.Text = menu.Protein.ToString();
            tbCarb.Text = menu.Carb.ToString();
            tbFat.Text = menu.Carb.ToString();
            tbCalories.Text = menu.Calories.ToString();
            
            


        }
    }
}
