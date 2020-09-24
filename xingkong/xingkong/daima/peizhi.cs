using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xingkong.daima
{
    public class Peizhi
    {
        /// <summary>
        /// 客户端版本
        /// </summary>
        public int banben = 11;
        /// <summary>
        /// 用户名
        /// </summary>
        public string yonghuming = "";
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string accessToken = "";
        /// <summary>
        /// 客户端UUID
        /// </summary>
        public string clientToken = "";
        /// <summary>
        /// 玩家UUID
        /// </summary>
        public string id = "";
        /// <summary>
        /// Java安装路径
        /// </summary>
        public string java_path = "";
        /// <summary>
        /// 服务器ID
        /// </summary>
        public string Sever_id = "b909afdb6f3d11ea908800163e095b49";
        /// <summary>
        /// 最低内存大小
        /// </summary>
        public string MinRAM = "2048M";
        /// <summary>
        /// 游戏内名字
        /// </summary>
        public string username = "";
        /// <summary>
        /// mc路径
        /// </summary>
        public string mc_path = "";
        /// <summary>
        /// 个性化签名
        /// </summary>
        public string juzi = "我仿佛看到一次既可悲又可笑的幽灵现身，看到一个时代已经过时的幻影。";
        /// <summary>
        /// 服务器ip
        /// </summary>
        public string serverIP = "mcb2.5imc.xyz:1081";
        /// <summary>
        /// 服务器名称
        /// </summary>
        public string serverName = "";
        /// <summary>
        /// 主题颜色
        /// </summary>
        public string color_zhu = "#555555";
        /// <summary>
        /// 启动的MC版本 1mod 2yaun
        /// </summary>
        public string mc_banben = "星空神域";
        /// <summary>
        /// 多个用户角色 外置登入
        /// </summary>
        public string[] users = null;
        /// <summary>
        /// 外置登入的验证服务器URL
        /// </summary>
        public string dengru_url = "http://47.93.231.24";
        /// <summary>
        /// 用户选择的角色 外置登入 从零开始计数
        /// </summary>
        public int users_xaunzhe = 0;
        /// <summary>
        /// 用户的登入方式 0统一通行证 1外置登入 2离线登入
        /// </summary>
        public int dengru_fangshi = 1;
        /// <summary>
        /// 密码
        /// </summary>
        public string mima = "";
        /// <summary>
        /// 内存总大小
        /// </summary>
        public string neicun_zong = "";
        /// <summary>
        /// 操作系统版本
        /// </summary>
        public string sys_banben = "";
        /// <summary>
        /// Java版本
        /// </summary>
        public string java_banben = "";
        /// <summary>
        /// GPU
        /// </summary>
        public string gpu = "";
        /// <summary>
        /// CPU
        /// </summary>
        public string cpu = "";
        /// <summary>
        /// CPU核心数
        /// </summary>
        public string cpu_hexin = "";
        /// <summary>
        /// 硬盘容量
        /// </summary>
        public string yingpan = "";
        /// <summary>
        /// 电脑型号
        /// </summary>
        public string diannao_xinghao = "";

        /// <summary>
        /// 保存配置信息
        /// </summary>
        /// <returns>是否成功</returns>
        public bool baocun()
        {
            try
            {
                //序列化数组 
                var linshi1 = new JObject();
                if (users != null)
                {
                    linshi1.Add("count", users.Count<string>());
                    for (int i = 0; i < users.Count<string>(); i += 2)
                    {
                        linshi1.Add("id" + i, users[i]);
                        linshi1.Add("name" + (i + 1), users[i + 1]);
                    }
                }
                string linshi4 = linshi1.ToString();
                //序列化json 将数据保存为json
                string data = new JObject(
                                        new JProperty("banben", banben.ToString()),
                                        new JProperty("yonghuming", yonghuming),
                                        new JProperty("accessToken", accessToken),
                                        new JProperty("clientToken", clientToken),
                                        new JProperty("id", id),
                                        new JProperty("java_path", java_path),
                                        new JProperty("Sever_id", Sever_id),
                                        new JProperty("MinRAM", MinRAM),
                                        new JProperty("username", username),
                                        new JProperty("mc_path", mc_path),
                                        new JProperty("juzi", juzi),
                                        new JProperty("serverIP", serverIP),
                                        new JProperty("serverName", serverName),
                                        new JProperty("color_zhu", color_zhu),
                                        new JProperty("mc_banben", mc_banben),
                                        new JProperty("users", linshi4),
                                        new JProperty("dengru_url", dengru_url),
                                        new JProperty("users_xaunzhe", users_xaunzhe),
                                        new JProperty("dengru_fangshi", dengru_fangshi),
                                        new JProperty("mima", mima),
                                        new JProperty("neicun_zong", neicun_zong),
                                        new JProperty("sys_banben", sys_banben),
                                        new JProperty("java_banben", java_banben),
                                        new JProperty("gpu", gpu),
                                        new JProperty("cpu", cpu),
                                        new JProperty("cpu_hexin", cpu_hexin),
                                        new JProperty("yingpan", yingpan),
                                        new JProperty("diannao_xinghao", diannao_xinghao)).ToString();

                //新建文件
                FileStream xiaFile = new FileStream("infor.txt", FileMode.Create);
                //写入
                byte[] buf = Encoding.UTF8.GetBytes(data);
                xiaFile.Write(buf, 0, buf.Length);
                xiaFile.Flush();
                xiaFile.Close();

            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 读取配置信息
        /// </summary>
        /// <returns>是否成功</returns>
        public bool duqu()
        {
            try
            {
                //打开文件
                FileInfo fi = new FileInfo("infor.txt");
                long len = fi.Length;

                FileStream fs = new FileStream("infor.txt", FileMode.Open);
                byte[] buffer = new byte[len];
                fs.Read(buffer, 0, (int)len);//读取文件
                fs.Close();//关闭
                string str = Encoding.UTF8.GetString(buffer);//转码
                string[] result = daima.Json_String.peizhi_jiexi(str);//解析Json
                //根据读取的数据初始化相应变量
                try
                {
                    if (result[0] != "")
                    {
                        yonghuming = result[0];
                    }
                    if (result[1] != "")
                    {
                        accessToken = result[1];
                    }
                    if (result[2] != "")
                    {
                        clientToken = result[2];
                    }
                    if (result[3] != "")
                    {
                        id = result[3];
                    }
                    if (result[4] != "")
                    {
                        java_path = result[4];
                    }
                    if (result[5] != "")
                    {
                        Sever_id = result[5];
                    }
                    if (result[6] != "")
                    {
                        MinRAM = result[6];
                    }
                    if (result[8] != "")
                    {
                        username = result[8];
                    }
                    if (result[9] != "")
                    {
                        mc_path = result[9];
                    }
                    if (result[10] != "")
                    {
                        juzi = result[10];
                    }
                    if (result[11] != "")
                    {
                        serverIP = result[11];
                    }
                    if (result[12] != "")
                    {
                        serverName = result[12];
                    }
                    if (result[13] != "")
                    {
                        color_zhu = result[13];
                    }
                    if (result[14] != "")
                    {
                        mc_banben = result[14];
                    }

                    if (result[15] != "")
                    {
                        //users = result[15];
                        if (result[15] != "{}")
                        {
                            //建立数组
                            var json1 = (JObject)JsonConvert.DeserializeObject(result[15]);
                            var count = json1["count"];
                            int linshi3 = int.Parse(count.ToString());

                            string[] linshi2 = new string[linshi3];

                            for (int i = 0; i < linshi3; i += 2)
                            {
                                var id = json1["id" + i];
                                var name = json1["name" + (i + 1)];
                                linshi2[i] = id.ToString();
                                linshi2[1 + i] = name.ToString();
                            }
                            users = linshi2;
                        }
                    }
                    if (result[16] != "")
                    {
                        dengru_url = result[16];
                    }
                    if (result[17] != "")
                    {
                        users_xaunzhe =int.Parse( result[17]);
                    }
                    if (result[18] != "")
                    {
                        dengru_fangshi = int.Parse(result[18]);
                    }
                    if (result[19] != "")
                    {
                        mima = result[19];
                    }
                    if (result[20] != "")
                    {
                        neicun_zong = result[20];
                    }
                    if (result[21] != "")
                    {
                        sys_banben = result[21];
                    }
                    if (result[22] != "")
                    {
                        java_banben = result[22];
                    }
                    if (result[23] != "")
                    {
                        gpu = result[23];
                    }
                    if (result[24] != "")
                    {
                        cpu = result[24];
                    }
                    if (result[25] != "")
                    {
                        cpu_hexin = result[25];
                    }
                    if (result[26] != "")
                    {
                        yingpan = result[26];
                    }
                    if (result[27] != "")
                    {
                        diannao_xinghao = result[27];
                    }


                }
                catch
                {

                }
                //检查版本号是否一致
                if (banben.ToString() != result[7])
                {
                    //保存
                    baocun();
                }
                return true;

            }
            catch (Exception exc)
            {
                baocun();
                return false;
            }
        }
    }
}
