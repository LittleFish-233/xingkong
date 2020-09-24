using Panuon.UI.Silver;
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

namespace xingkong.setting
{
    /// <summary>
    /// qidongqi_shezhi.xaml 的交互逻辑
    /// </summary>
    public partial class qidongqi_shezhi : Page
    {
        public qidongqi_shezhi()
        {
            InitializeComponent();
            Loaded += Qidongqi_shezhi_Loaded;
        }

        private void Qidongqi_shezhi_Loaded(object sender, RoutedEventArgs e)
        {
            sever_id.Text = App.peizhi.Sever_id;
            java_path.Text = App.peizhi.java_path;
            mc_path.Text = App.peizhi.mc_path;
            mc_ram.Text = App.peizhi.MinRAM;
            //qianming.Text = App.peizhi.juzi;
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.peizhi.Sever_id = sever_id.Text;
            App.peizhi.java_path = java_path.Text;
            App.peizhi.mc_path = mc_path.Text;
            App.peizhi.MinRAM = mc_ram.Text;
            //App.peizhi.juzi = qianming.Text;
            App.peizhi.baocun();
            //提示
            var result = MessageBoxX.Show("保存成功", "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);

        }
    }
}
