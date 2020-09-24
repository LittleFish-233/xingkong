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

namespace xingkong.game
{
    /// <summary>
    /// list.xaml 的交互逻辑
    /// </summary>
    public partial class list : Page
    {
        public list()
        {
            InitializeComponent();
            Loaded += List_Loaded;
        }

        private void List_Loaded(object sender, RoutedEventArgs e)
        {
            //选择
            switch(App.peizhi.mc_banben)
            {
                case "星空神域":
                    re1.IsChecked = true;
                    break;
                case "1.12.2":
                    re2.IsChecked = true;
                    break;
            }
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;
            re2.Background = yanse_b;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            App.peizhi.mc_banben = "星空神域";
            App.peizhi.baocun();
        }

        private void re2_Checked(object sender, RoutedEventArgs e)
        {
            App.peizhi.mc_banben = "1.12.2";
            App.peizhi.baocun();
        }
    }
}
