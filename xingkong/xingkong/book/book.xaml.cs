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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace xingkong.book
{
    /// <summary>
    /// book.xaml 的交互逻辑
    /// </summary>
    public partial class book : Page
    {
        public book()
        {
            InitializeComponent();
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
