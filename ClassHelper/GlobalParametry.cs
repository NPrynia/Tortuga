using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TortugaPrianiKaraul.ClassHelper
{
    public class GlobalParametry
    {
        public static Frame Frame;
        public static int idTable;
        public static StackPanel stackPanel;
        public static List<Tortuga.EF.Menu> order = new List<Tortuga.EF.Menu>();
        public static List<Basket> basket = new List<Basket>();


        public partial class Basket
        {
            public int IDMenu { get; set; }
            public int Qty { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Cost { get; set; } 
            public decimal finalCost {
                get 
                {
                    return Qty*Cost;
                }
            } 
            public byte[] Image { get; set; }
        }
    }
}
