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
    /// xinxi.xaml 的交互逻辑
    /// </summary>
    public partial class xinxi : Page
    {
        public xinxi()
        {
            InitializeComponent();
            Loaded += Xinxi_Loaded;
        }

        private void Xinxi_Loaded(object sender, RoutedEventArgs e)
        {
            yonghuming.Text ="用户名："+ App.peizhi.yonghuming;
            youxi_id.Text ="游戏内ID：" +App.peizhi.username;
            switch(App.peizhi.dengru_fangshi)
            {
                case 0:
                    dengru.Text = "登录方式：统一通行证";
                    break;
                case 1:
                    dengru.Text = "登录方式：外置登录";
                    break;
                case 2:
                    dengru.Text = "登录方式：离线登录";
                    break;
            }
        }
    }
}
