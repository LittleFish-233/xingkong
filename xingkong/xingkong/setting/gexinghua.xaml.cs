using Panuon.UI.Silver;
using Panuon.UI.Silver.Core;
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

namespace xingkong.setting
{
    /// <summary>
    /// gexinghua.xaml 的交互逻辑
    /// </summary>
    public partial class gexinghua : Page
    {
        public gexinghua()
        {
            InitializeComponent();
            Loaded += Gexinghua_Loaded;
        }

        private void Gexinghua_Loaded(object sender, RoutedEventArgs e)
        {
            qianming.Text = App.peizhi.juzi;
            yanse.Text = App.peizhi.color_zhu;
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //检查颜色是否正确
            try
            {
                Color color = (Color)ColorConverter.ConvertFromString(yanse.Text);
                yanse_xuan.Color = color;

            }
            catch (Exception exc)
            {
                MessageBoxX.Show("输入的颜色不是有效的颜色<"+exc.Message+">", "Error", Application.Current.MainWindow, MessageBoxButton.YesNo, new MessageBoxXConfigurations()
                {
                    MessageBoxIcon = MessageBoxIcon.Error,
                    ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
                });
                return;
            }
            //保存
            App.peizhi.juzi = qianming.Text;
            App.peizhi.color_zhu = yanse.Text;
            App.peizhi.baocun();
            //提示
            MessageBoxX.Show("保存成功", "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);
        }

        private void ColorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            Color color= yanse_xuan.Color;
            App.peizhi.color_zhu= color.ToString();
            yanse.Text = App.peizhi.color_zhu;
        }

        private void yanse_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                Color color = (Color)ColorConverter.ConvertFromString(yanse.Text);
                yanse_xuan.Color = color;

            }
            catch (Exception exc)
            {
                return;
            }
        }

        private void yanse_xuan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Color color = yanse_xuan.Color;
            App.peizhi.color_zhu = color.ToString();
            yanse.Text = App.peizhi.color_zhu;
        }
    }
}
