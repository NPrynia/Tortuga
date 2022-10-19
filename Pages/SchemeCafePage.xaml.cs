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
using TortugaPrianiKaraul.ClassHelper;

namespace TortugaPrianiKaraul.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchemeCafePage.xaml
    /// </summary>
    public partial class SchemeCafePage : Page
    {
        public SchemeCafePage()
        {
            InitializeComponent();
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            checkTable(Convert.ToInt32(button.Tag));

        }

        public void checkTable(int idTable)
        {
            //List<Tortuga.EF.Table> tables = new List<Tortuga.EF.Table>();
            //tables = AppData.Context.Table.ToList();
            //var table = AppData.Context.Table.Where(i => i.ID == idTable).FirstOrDefault();
            //if (table.IsAvaliable == true)
            //{

            GlobalParametry.idTable = idTable;
                GlobalParametry.Frame.Navigate(new Pages.MainPage());
                GlobalParametry.stackPanel.Visibility = Visibility.Visible;

            //}
            //else
            //{
            //    MessageBox.Show("Столик занят.Выберите пожалуйста другой.");
            //    return;
            //}

        }
    }
}
