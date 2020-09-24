using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace xingkong.dengru
{
    /// <summary>
    /// banzhu.xaml 的交互逻辑
    /// </summary>
    public partial class banzhu : Window
    {
        public banzhu()
        {
            InitializeComponent();
            Loaded += Banzhu_Loaded;
        }

        private void Banzhu_Loaded(object sender, RoutedEventArgs e)
        {
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            //新建bat
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    daima.Bat.open_url("https://login2.nide8.com:233/" + App.peizhi.Sever_id + "/loginreg");
                    break;
                case 1:
                    daima.Bat.open_url(App.peizhi.dengru_url);
                    break;
            }
            //运行bat
            Process proc = null;
            proc = new Process();
            proc.StartInfo.FileName = @"mc.bat";
            proc.StartInfo.Arguments = string.Format("10");//this is argument
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();

        }
    }
}
