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

namespace xingkong.dengru
{
    /// <summary>
    /// shezhi.xaml 的交互逻辑
    /// </summary>
    public partial class shezhi : Window
    {
        public shezhi()
        {
            InitializeComponent();
            Loaded += Shezhi_Loaded;
        }

        private void Shezhi_Loaded(object sender, RoutedEventArgs e)
        {
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;
            re2.Background = yanse_b;


            dengru_fangshi.SelectedIndex = App.peizhi.dengru_fangshi;
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    te3.Visibility = Visibility.Collapsed;
                    yanzhneg_path.Visibility = Visibility.Collapsed;
                    te1.Visibility = Visibility.Visible;
                    sever_id.Visibility = Visibility.Visible;
                    break;
                case 1:
                    te3.Visibility = Visibility.Visible;
                    yanzhneg_path.Visibility = Visibility.Visible;
                    te1.Visibility = Visibility.Collapsed;
                    sever_id.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    te3.Visibility = Visibility.Collapsed;
                    yanzhneg_path.Visibility = Visibility.Collapsed;
                    te1.Visibility = Visibility.Collapsed;
                    sever_id.Visibility = Visibility.Collapsed;
                    break;
            }
            sever_id.Text = App.peizhi.Sever_id;
            yanzhneg_path.Text = App.peizhi.dengru_url;
        }

        //打开帮助
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            banzhu isw = new banzhu();
            isw.Show();
        }
        //不保存 直接关闭
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.peizhi.Sever_id = sever_id.Text;
            App.peizhi.dengru_url = yanzhneg_path.Text;
            App.peizhi.baocun();
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }
        private void dengru_fangshi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            App.peizhi.dengru_fangshi = dengru_fangshi.SelectedIndex;
                switch (App.peizhi.dengru_fangshi)
                {
                    case 0:
                        te3.Visibility = Visibility.Collapsed;
                        yanzhneg_path.Visibility = Visibility.Collapsed;
                        te1.Visibility = Visibility.Visible;
                        sever_id.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        te3.Visibility = Visibility.Visible;
                        yanzhneg_path.Visibility = Visibility.Visible;
                        te1.Visibility = Visibility.Collapsed;
                        sever_id.Visibility = Visibility.Collapsed;
                        break;
                    case 2:
                        te3.Visibility = Visibility.Collapsed;
                        yanzhneg_path.Visibility = Visibility.Collapsed;
                        te1.Visibility = Visibility.Collapsed;
                        sever_id.Visibility = Visibility.Collapsed;
                        break;

                }
            }
            catch(Exception exc)
            {

            }

        }
    }
}
