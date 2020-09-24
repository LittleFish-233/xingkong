using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace xingkong
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //ceshi linshi_1 = new ceshi();
            //linshi_1.Show();
            //Window window2 = Window.GetWindow(this);//关闭父窗体
            //window2.Close();
            //return;

            //更新路径
            string path2 = System.Environment.CurrentDirectory;

            //try
            //{
            //    Directory.Move(path2 + "\\.minecraft\\versions\\星空神域", path2 + "\\.minecraft\\versions\\CelestialDomain");
            //    Directory.Move(path2 + "\\.minecraft\\versions\\CelestialDomain\\星空神域-natives", path2 + "\\.minecraft\\versions\\CelestialDomain\\CelestialDomain-natives");
            //}
            //catch(Exception exc)
            //{

            //}
            //复制文件

            //获取的文件地址
            //将选择的文件复制的地址
            //try
            //{
            //
            //    File.Copy(path2 + "\\.minecraft\\nide8auth.jar", path2 + "\\.minecraft\\versions\\星空神域\\mods\\nide8auth.jar", true);
            //}
            //catch (Exception exc)
            //{
            //
            //}

            //读取配置文件
            App.peizhi.duqu(); 
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            Background = yanse_b;
            re1.Background = yanse_b;
            re2.Background = yanse_b;
            re3.Background = yanse_b;
            re4.Fill = yanse_b;
            re5.Foreground = yanse_b;
            re6.Foreground = yanse_b;
            re7.Foreground = yanse_b;

            //获取服务器信息
            string[] jieguo = null;
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    jieguo = await daima.minecraft_TYTXZ.Huoqu_xinxiAsync(App.peizhi.Sever_id);
                    if (jieguo != null)
                    {
                        App.peizhi.serverIP = jieguo[0];
                        App.peizhi.serverName = jieguo[1];
                        App.peizhi.baocun();
                    }
                    break;
                case 1:
                    jieguo = daima.authlib_injector.yanzheng_url(App.peizhi.dengru_url);
                    if (jieguo != null)
                    {
                        App.peizhi.serverName = jieguo[0];
                        App.peizhi.baocun();
                    }
                    break;
                default:
                    break;
            }
            //检查Java路径
            if(App.peizhi.java_path=="")
            {
                App.peizhi.java_path = daima.Sys_infor.java_path()[0];
                App.peizhi.baocun();
            }
            //检查系统信息
            if(App.peizhi.neicun_zong=="")
            {
                //内存总大小
                App.peizhi.neicun_zong = daima.ComputerInfo.GetMemoryTotal();
                //操作系统版本
                App.peizhi.sys_banben = daima.ComputerInfo.GetOSVersion();
                //Java版本
                App.peizhi.java_banben = daima.Sys_infor.java_path()[1];
                //GPU
                App.peizhi.gpu = daima.ComputerInfo.GetGPU();
                //CPU
                App.peizhi.cpu = daima.ComputerInfo.GetCPU();
                //CPU核心数
                App.peizhi.cpu_hexin = daima.Computer.GetCPU_Count();
                //硬盘容量
                App.peizhi.yingpan = daima.Computer.GetDiskSize();
                //电脑型号
                App.peizhi.diannao_xinghao = daima.Computer.GetVersion();

                App.peizhi.baocun();
            }


            //检查是否存在默认令牌 存在则说明可以直接登入 这一部分验证存在问题所以每次启动都要登入
            if (App.peizhi.accessToken != "" && App.peizhi.clientToken != "")
            {
                //检查是否有效
                bool linshi = false;
                switch(App.peizhi.dengru_fangshi)
                {
                    case 0: 
                        linshi = await daima.minecraft_TYTXZ.yanzhengAsync(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.Sever_id);
                        break;
                    case 1:
                        linshi = await daima.authlib_injector.yanzhengAsync(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url);
                        break;
                    case 2:
                        linshi = true;
                        break;
                    default:
                        break;
                }
                if (linshi == true)
                {
                    //打开游戏主页
                    ceshi isw1 = new ceshi();//这是新窗口的类
                                             //isw.Title = "给新页面命名";//这里可以给新窗口重新命名
                    isw1.Show();//无模式，弹出！
                    Window window1 = Window.GetWindow(this);//关闭父窗体
                    window1.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;

            }
        }

        //关闭当前窗口
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dengru.shezhi isw = new dengru.shezhi();
            isw.Show();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //检查用户输入
            if (string.IsNullOrWhiteSpace(zhanghao_shu.Text) == true)
            {
                Notice.Show("用户名是在服务器网站上注册时使用的用户名，不是游戏内ID", "请输入用户名", 3, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(mima_shuru.Password) == true&&App.peizhi.dengru_fangshi!=2)
            {
                //显示错误
                Notice.Show("密码是在服务器网站上注册时时创建的密码", "请输入密码", 3, MessageBoxIcon.Error);
                return;
            }
            //尝试登入
            App.peizhi.mima = mima_shuru.Password;
            string[] result = null;
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    result = await daima.minecraft_TYTXZ.dengru_fristAsync(App.peizhi.Sever_id, zhanghao_shu.Text, mima_shuru.Password, App.peizhi.banben, App.peizhi.clientToken);
                    break;
                case 1:
                    result = await daima.authlib_injector.dengru_fristAsync(App.peizhi.dengru_url, zhanghao_shu.Text, mima_shuru.Password, App.peizhi.banben, App.peizhi.clientToken);
                    break;
                default:
                    break;
            }
            //检查
            if (result == null&&App.peizhi.dengru_fangshi!=2)
            {
                //显示错误
                Notice.Show("用户名是在统一通行证注册时使用的用户名，不是游戏内ID", "用户名或密码错误", 3, MessageBoxIcon.Error);
                return;
            }
            //保存数据
            switch(App.peizhi.dengru_fangshi)
            {
                case 0:
                    App.peizhi.accessToken = result[0];
                    App.peizhi.clientToken = result[1];
                    App.peizhi.id = result[2];
                    App.peizhi.username = result[3];
                    App.peizhi.yonghuming = zhanghao_shu.Text;
                    break;
                case 1:
                    //更新相关设置
                    App.peizhi.accessToken = result[0];
                    App.peizhi.clientToken = result[1];
                    App.peizhi.yonghuming = zhanghao_shu.Text;
                    string[] linshi2 = new string[result.Count<string>() - 2];
                    for(int i=0;i<result.Count<string>()-2;i+=2)
                    {
                        linshi2[i] = result[2 + i];
                        linshi2[i + 1] = result[3 + i];
                    }
                    App.peizhi.users = linshi2;
                    App.peizhi.users_xaunzhe = 0;
                    App.peizhi.username = linshi2[1];
                    App.peizhi.id = linshi2[0];
                    //需要绑定相关角色
                    if (linshi2.Count<string>() > 2)
                    {
                        string[] linshi = await daima.authlib_injector.shuaxin(App.peizhi.accessToken, App.peizhi.clientToken, App.peizhi.dengru_url, App.peizhi.users[1], App.peizhi.users[0]);
                        App.peizhi.accessToken = linshi[0];
                        App.peizhi.clientToken = linshi[1];
                        App.peizhi.username = linshi[3];
                        App.peizhi.id = linshi[2];
                        App.peizhi.users_xaunzhe = 0;
                    }
                    break;
                case 2:
                    App.peizhi.accessToken = "11111111111111111111";
                    App.peizhi.clientToken = "1111111111111111111111111";
                    App.peizhi.id = "111111111111111111111111111111111";
                    App.peizhi.username = zhanghao_shu.Text;
                    App.peizhi.yonghuming = zhanghao_shu.Text;
                    break;
                default:
                    break;
            }
            App.peizhi.baocun();
            //调转
            ceshi isw = new ceshi();
            isw.Show();
            Window window1 = Window.GetWindow(this);//关闭父窗体
            window1.Close();
        }

        private void zhanghao_shu_TextChanged(object sender, TextChangedEventArgs e)
        {
            cuowuxinxi.Visibility = Visibility.Hidden;
        }

        private void mima_shuru_PasswordChanged(object sender, RoutedEventArgs e)
        {
            cuowuxinxi.Visibility = Visibility.Hidden;
        }

        private void re8_Click(object sender, RoutedEventArgs e)
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
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
        }
    }
}
