using Microsoft.Win32;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;
            re2.Background = yanse_b;
            re3.Background = yanse_b;
            re4.Background = yanse_b;
            re5.Background = yanse_b;
            re6.Background = yanse_b;
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    xianshi(1, App.peizhi.username);
                    break;
                case 1:
                    //显示
                    int shuliang = App.peizhi.users.Count<string>() / 2;
                    for (int i = 0; i < shuliang; i++)
                    {
                        xianshi(i + 1, App.peizhi.users[i * 2 + 1]);
                    }
                    //选择
                    switch (App.peizhi.users_xaunzhe)
                    {
                        case 0:
                            re1.IsChecked = true;
                            break;
                        case 1:
                            re2.IsChecked = true;
                            break;
                        case 2:
                            re3.IsChecked = true;
                            break;
                        case 3:
                            re4.IsChecked = true;
                            break;
                        case 4:
                            re5.IsChecked = true;
                            break;
                    }
                    break;
                case 2:
                    xianshi(1, App.peizhi.username);
                    break;
            }
        }

        public void xianshi(int a,string name)
        {
            switch(a)
            {
                case 1:
                    gr1.Visibility = Visibility.Visible;
                    te1.Text = name;
                    break;
                case 2:
                    te2.Text = name;
                    gr2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    te3.Text = name;
                    gr3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    te4.Text = name;
                    gr4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    te5.Text = name;
                    gr5.Visibility = Visibility.Visible;
                    break;
            }
        }
        public async Task<int> dengruAsync()
        {
            string[] result = null;
            result = await daima.authlib_injector.dengru_fristAsync(App.peizhi.dengru_url, App.peizhi.yonghuming, App.peizhi.mima, App.peizhi.banben, App.peizhi.clientToken);
            App.peizhi.accessToken = result[0];
            App.peizhi.clientToken = result[1];
            string[] linshi2 = new string[result.Count<string>() - 2];
            for (int i = 0; i < result.Count<string>() - 2; i += 2)
            {
                linshi2[i] = result[2 + i];
                linshi2[i + 1] = result[3 + i];
            }
            App.peizhi.users = linshi2;
            App.peizhi.users_xaunzhe = 0;
            App.peizhi.username = linshi2[1];
            App.peizhi.id = linshi2[0];
            App.peizhi.baocun();
            return 0;
        }


        private async void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (App.peizhi.dengru_fangshi != 1||App.peizhi.users.Count<string>()<=2)
            {
                return;
            }
            try
            {

                await dengruAsync();

                string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[1], App.peizhi.users[0]);
                App.peizhi.accessToken = linshi[0];
                App.peizhi.clientToken = linshi[1];
                App.peizhi.username = linshi[3];
                App.peizhi.id = linshi[2];
                App.peizhi.users_xaunzhe = 0;
                App.peizhi.baocun();

            }
            catch
            {

            }
        }

        private async void re2_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                await dengruAsync();

                string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[3], App.peizhi.users[2]);
                App.peizhi.accessToken = linshi[0];
                App.peizhi.clientToken = linshi[1];
                App.peizhi.username = linshi[3];
                App.peizhi.id = linshi[2];
                App.peizhi.users_xaunzhe = 1;
                App.peizhi.baocun();

            }
            catch
            {

            }
        }

        private async void re3_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                await dengruAsync();

                string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[5], App.peizhi.users[4]);
            App.peizhi.accessToken = linshi[0];
            App.peizhi.clientToken = linshi[1];
            App.peizhi.username = linshi[3];
            App.peizhi.id = linshi[2];
            App.peizhi.users_xaunzhe = 2;
            App.peizhi.baocun();

            }
            catch
            {

            }
        }

        private async void re4_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                await dengruAsync();

                string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[7], App.peizhi.users[6]);
            App.peizhi.accessToken = linshi[0];
            App.peizhi.clientToken = linshi[1];
            App.peizhi.username = linshi[3];
            App.peizhi.id = linshi[2];

            App.peizhi.users_xaunzhe = 3;
            App.peizhi.baocun();

            }
            catch
            {

            }
        }

        private async void re5_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                await dengruAsync();

                string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[9], App.peizhi.users[8]);
                App.peizhi.accessToken = linshi[0];
                App.peizhi.clientToken = linshi[1];
                App.peizhi.username = linshi[3];
                App.peizhi.id = linshi[2];
                App.peizhi.users_xaunzhe = 4;
                App.peizhi.baocun();

            }
            catch
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
