using Panuon.UI.Silver;
using Panuon.UI.Silver.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace xingkong.home
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            Loaded += HomePage_Loaded;
        }

        private void HomePage_Loaded(object sender, RoutedEventArgs e)
        {
            //设置颜色
            Brush yanse_b = (Brush)(new BrushConverter()).ConvertFromString(App.peizhi.color_zhu);
            re1.Background = yanse_b;
            //更新按钮文本
            buttontext.Text ="启动 "+ App.peizhi.mc_banben;
            //获取系统信息
            huoquxitongxinxi();
            //更新玩家信息
            username.Text = App.peizhi.username;
            switch (App.peizhi.dengru_fangshi)
            {
                case 0:
                    degru_fangsi.Text = "登录方式：统一通行证";
                    break;
                case 1:
                    degru_fangsi.Text = "登录方式：外置登录";
                    break;
                case 2:
                    degru_fangsi.Text = "登录方式：离线登录";
                    break;
            }
            try
            {
                //设置签名
                juzi.Text = App.peizhi.juzi;
                //更新服务器信息
                fuwuqi_name.Text = App.peizhi.serverName;
                fuwuqi_ip.Text = "服务器地址："+App.peizhi.serverIP;
                //获取服务器信息
                string[] linshi = daima.zifuchuang.fenli_ip(App.peizhi.serverIP);
                var mc = daima.MinecraftServerInfo.GetServerInformation(new System.Net.IPAddress(Encoding.UTF8.GetBytes(linshi[0])), int.Parse(linshi[1]));
                //更新服务器信息
                if (mc != null)
                {
                    fuwuqi_renshu.Text = "人数：" + mc.CurrentPlayerCount + "//" + mc.MaxPlayerCount;
                    fuwuqi_yanci.Text = mc.ServerMotd;
                }

            }
            catch (Exception exc)
            {

            }
        }
        private void huoquxitongxinxi()
        {
            //内存总大小
            text1.Text = "内存总大小：" + App.peizhi.neicun_zong+"MB";
            //游戏内存分配大小
            text2.Text = "游戏内存分配大小：" + App.peizhi.MinRAM +"B";
            //操作系统版本
            text3.Text = "操作系统版本：" + App.peizhi.sys_banben;
            //Java版本
            text4.Text = "Java版本：" + App.peizhi.java_banben;
            //GPU
            text5.Text = "GPU：" + App.peizhi.gpu;
            //CPU
            text6.Text = "CPU：" + App.peizhi.cpu;
            //CPU核心数
            text7.Text = "CPU核心数：" + App.peizhi.cpu_hexin;
            //硬盘容量
            text8.Text = "硬盘容量：" + App.peizhi.yingpan;
            //电脑型号
            text9.Text = "电脑型号：" + App.peizhi.diannao_xinghao;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //检查Java路径
                if (App.peizhi.java_path == "")
                {
                    App.peizhi.java_path = daima.Sys_infor.java_path()[0];
                    if(App.peizhi.java_path=="")
                    {
                        Notice.Show("请确保你安装了Java的1.8版本，如果已经安装请在设置中手动输入Java路径，我们无法自动检测", "无法找到Java路径", 15, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //检查游戏目录
                if (App.peizhi.mc_path == "")
                {
                    App.peizhi.mc_path = System.Environment.CurrentDirectory+"\\";
                    App.peizhi.baocun();
                }
                //下载缺失的库
                if (File.Exists(App.peizhi.mc_path + ".minecraft\\authlib.jar") == false && App.peizhi.dengru_fangshi == 1)
                {
                    //显示错误
                    var result = MessageBoxX.Show("必须下载authlib.jar文件，大约需要1-2分钟，请耐心等待", "需要下载依赖文件", Application.Current.MainWindow, MessageBoxButton.YesNo, new MessageBoxXConfigurations()
                    {
                        MessageBoxIcon = MessageBoxIcon.Info,
                    });
                    bool shifouchenggong = await daima.HttpRequestHelper.downloadAsync(App.peizhi.mc_path + ".minecraft\\authlib.jar", "https://raw.githubusercontent.com/yushijinhun/authlib-injector.yushi.moe/master/artifact/26/authlib-injector-1.1.26-41a7a47.jar");
                    if (shifouchenggong == false)
                    {
                        Notice.Show("如果你使用的是离线登录，请忽略此消息。请检查你的网络链接，无法下载authlib.jar文件。", "无法下载依赖文件", 15, MessageBoxIcon.Warning);
                    }
                }
                //下载缺失的库
                if (File.Exists(App.peizhi.mc_path + ".minecraft\\nide8auth.jar") == false&&App.peizhi.dengru_fangshi==0)
                {
                    //显示错误
                    var result = MessageBoxX.Show("必须下载nide8auth.jar文件，大约需要1-2分钟，请耐心等待", "需要下载依赖文件", Application.Current.MainWindow, MessageBoxButton.YesNo, new MessageBoxXConfigurations()
                    {
                        MessageBoxIcon = MessageBoxIcon.Info,
                    });
                    bool shifouchenggong = await daima.HttpRequestHelper.downloadAsync(App.peizhi.mc_path + ".minecraft\\nide8auth.jar", "https://login2.nide8.com:233/download/nide8auth.jar");
                    if (shifouchenggong == false)
                    {
                        Notice.Show("如果你使用的是离线登录，请忽略此消息。请检查你的网络链接，无法下载nide8auth.jar文件。", "无法下载依赖文件", 15, MessageBoxIcon.Warning);
                    }
                }
                //识别
                string fuwuqi = "";
                switch(App.peizhi.dengru_fangshi)
                {
                    case 0:
                        fuwuqi = App.peizhi.Sever_id;
                        break;
                    case 1:
                        fuwuqi = App.peizhi.dengru_url;
                        break;
                }
                //建立bat脚本 根据选择启动对应的MC版本
                string command = "";
                switch (App.peizhi.mc_banben)
                {
                    case "星空神域":
                        command= daima.Bat.xinjian_bat_F(fuwuqi, App.peizhi.banben, App.peizhi.accessToken, App.peizhi.id, App.peizhi.java_path, App.peizhi.MinRAM, App.peizhi.username, App.peizhi.mc_path,App.peizhi.dengru_fangshi);
                        break;
                    case "1.12.2":
                        daima.Bat.xinjian_bat_v(fuwuqi, App.peizhi.banben, App.peizhi.accessToken, App.peizhi.id, App.peizhi.java_path, App.peizhi.MinRAM, App.peizhi.username, App.peizhi.mc_path,App.peizhi.dengru_fangshi);
                        break;
                }
                //显示提示
                Notice.Show("正在后台启动 " + App.peizhi.mc_banben + "，根据不同硬件配置需要5-10分钟左右才能完全启动游戏，请耐心等待", "成功启动游戏", 30, MessageBoxIcon.Success);
                //运行bat
                Process proc = null;
                proc = new Process();
                proc.StartInfo.FileName = @"" + App.peizhi.mc_path + ".minecraft\\versions\\"+App.peizhi.mc_banben+"\\1.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Exited += Proc_Exited;
                proc.Start();
                
                //关闭当前窗口
                Window window1 = Window.GetWindow(this);
                window1.Close();
            }
            catch (Exception ex)
            {
                //显示错误
                var result = MessageBoxX.Show("建立并运行脚本时出现错误<" + ex.Message + ">", "Error", Application.Current.MainWindow, MessageBoxButton.YesNo, new MessageBoxXConfigurations()
                {
                    MessageBoxIcon = MessageBoxIcon.Error,
                    ButtonBrush = "#FF4C4C".ToColor().ToBrush(),
                });
            }
        }

        private void Proc_Exited(object sender, EventArgs e)
        {
            //关闭提示 
            Notice.Show("如果是你主动结束游戏请忽略这条信息，否则请到用户手册中查找解决方案", "游戏进程已结束", 10, MessageBoxIcon.Warning);
        }
    }
}
