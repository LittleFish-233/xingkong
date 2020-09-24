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
using System.Windows.Shapes;

namespace xingkong
{
    /// <summary>
    /// zhuye.xaml 的交互逻辑
    /// </summary>
    public partial class zhuye : Window
    {
        public zhuye()
        {
            InitializeComponent();
            Loaded += Zhuye_Loaded;
        }

        private void Zhuye_Loaded(object sender, RoutedEventArgs e)
        {
            //导航
            home.HomePage page = new home.HomePage();
            zhu_frame.Content = page;
            //设置标题
            biaoti.Text = "星空启动器v1.5-主页";
        }

        //最小化窗口
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; //设置窗口最小化
        }
        //关闭窗口
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            biaoti.Text = "星空启动器v1.5-主页";

            home.HomePage page = new home.HomePage();
            zhu_frame.Content = page;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            biaoti.Text = "星空启动器v1.5-游戏列表";

            game.zhu page = new game.zhu();
            zhu_frame.Content = page;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            biaoti.Text = "星空启动器v1.5-设置";

            setting.zhu page = new setting.zhu();
            zhu_frame.Content = page;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            biaoti.Text = "星空启动器v1.5-账户";

            zhanghao.zhu page = new zhanghao.zhu();
            zhu_frame.Content = page;
        }
    }
}
