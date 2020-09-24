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

namespace xingkong.zhanghao
{
    /// <summary>
    /// zhu.xaml 的交互逻辑
    /// </summary>
    public partial class zhu : Page
    {
        public zhu()
        {
            InitializeComponent();
            Loaded += Zhu_Loaded;
        }

        private void Zhu_Loaded(object sender, RoutedEventArgs e)
        {
            zhu_page.Content = new xinxi();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            zhu_page.Content = new xinxi();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.peizhi.id = "";
            App.peizhi.accessToken = "";
            App.peizhi.clientToken = "";
            App.peizhi.username = "";
            App.peizhi.yonghuming = "";
            App.peizhi.baocun();

            MainWindow isw = new MainWindow();
            isw.Show();
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zhu_page.Content = new list();
        }
    }
}
