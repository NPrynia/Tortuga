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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TortugaPrianiKaraul.Pages
{
    /// <summary>
    /// Логика взаимодействия для InactionPage.xaml
    /// </summary>
    public partial class InactionPage : Page
    {
        public InactionPage()
        {
            InitializeComponent();
            DoubleAnimation ImgAnimationWidth = new DoubleAnimation();
            ImgAnimationWidth.From = 1400;
            ImgAnimationWidth.To = 1480;
            ImgAnimationWidth.Duration = TimeSpan.FromSeconds(3);
            OceanImg.BeginAnimation(Image.WidthProperty, ImgAnimationWidth);


            DoubleAnimation imgAnimationHeight = new DoubleAnimation();
            imgAnimationHeight.From = 550;
            imgAnimationHeight.To = 500;
            imgAnimationHeight.Duration = TimeSpan.FromSeconds(3);
            imgAnimationHeight.Completed += SecondAnimation;
            OceanImg.BeginAnimation(Image.HeightProperty, imgAnimationHeight);

         
        }
        
        private void FirstAnimation(object sender, EventArgs e)
        {

            DoubleAnimation ImgAnimationWidth = new DoubleAnimation();
            ImgAnimationWidth.From = 1400;
            ImgAnimationWidth.To = 1480;
            ImgAnimationWidth.Duration = TimeSpan.FromSeconds(3);
            OceanImg.BeginAnimation(Image.WidthProperty, ImgAnimationWidth);

            DoubleAnimation imgAnimationHeight = new DoubleAnimation();
            imgAnimationHeight.From = 550;
            imgAnimationHeight.To = 500;
            imgAnimationHeight.Duration = TimeSpan.FromSeconds(3);
            imgAnimationHeight.Completed += SecondAnimation;
            OceanImg.BeginAnimation(Image.HeightProperty, imgAnimationHeight);

        }
        private void SecondAnimation(object sender, EventArgs e)
        {
            DoubleAnimation ImgAnimationWidth = new DoubleAnimation();
            ImgAnimationWidth.From = 1480;
            ImgAnimationWidth.To = 1400;
            ImgAnimationWidth.Duration = TimeSpan.FromSeconds(3);
            OceanImg.BeginAnimation(Image.WidthProperty, ImgAnimationWidth);

            DoubleAnimation ImgAnimationHeight = new DoubleAnimation();
            ImgAnimationHeight.From = 500;
            ImgAnimationHeight.To = 550;
            ImgAnimationHeight.Duration = TimeSpan.FromSeconds(3);
            ImgAnimationHeight.Completed += FirstAnimation;
            OceanImg.BeginAnimation(Image.HeightProperty, ImgAnimationHeight);
        }
    }
}
