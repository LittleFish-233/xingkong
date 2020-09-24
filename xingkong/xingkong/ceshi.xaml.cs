using Panuon.UI.Silver;
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
    /// ceshi.xaml 的交互逻辑
    /// </summary>
    public partial class ceshi : WindowX
    {
        public ceshi()
        {
            InitializeComponent();
            Loaded += Ceshi_Loaded;
        }

        private void Ceshi_Loaded(object sender, RoutedEventArgs e)
        {
            //导航
            home.HomePage page = new home.HomePage();
            zhu_frame.Content = page;

            //设置颜色
            Brush yanse_b=(Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            Background = yanse_b;
            re1.Background = yanse_b;
        }

        private void TreeView_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (caidan.SelectedItem != null)
            {
                TreeViewItem selectedTnh = caidan.SelectedItem as TreeViewItem;
                int a = int.Parse(selectedTnh.Tag as string);
                switch(a)
                {
                    case 1:
                        home.HomePage page = new home.HomePage();
                        zhu_frame.Content = page;
                        break;
                    case 2:
                        game.zhu page1 = new game.zhu();
                        zhu_frame.Content = page1;
                        break;
                    case 3:
                        zhanghao.zhu page2 = new zhanghao.zhu();
                        zhu_frame.Content = page2;
                        break;
                    case 4:
                        setting.zhu page3 = new setting.zhu();
                        zhu_frame.Content = page3;
                        break;
                    case 5:
                        book.zhu page4 = new book.zhu();
                        zhu_frame.Content = page4;
                        break;
                }
            }
        }
    }
}
