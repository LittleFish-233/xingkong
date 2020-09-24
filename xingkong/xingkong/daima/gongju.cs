using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SquareMinecraftLauncher.Minecraft;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static SquareMinecraftLauncher.Minecraft.Game;

namespace xingkong.daima
{
    public static class Json_String
    {
        /// <summary>
        /// 解析读取的配置文件Json 外部 负责匹配版本号
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        public static string[] peizhi_jiexi(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            switch (int.Parse(json["banben"].ToString()))
            {
                case 1:
                    return peizhi_jiexi_1(str);
                case 2:
                    return peizhi_jiexi_2(str);
                case 3:
                    return peizhi_jiexi_3(str);
                case 4:
                    return peizhi_jiexi_4(str);
                case 5:
                    return peizhi_jiexi_5(str);
                case 6:
                    return peizhi_jiexi_6(str);
                case 7:
                    return peizhi_jiexi_7(str);
                case 8:
                    return peizhi_jiexi_8(str);
                case 9:
                    return peizhi_jiexi_9(str);
                case 11:
                    return peizhi_jiexi_11(str);
                default:
                    return null;
            }
        }
        /// <summary>
        /// 解析读取的配置文件 版本1
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_1(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            //保存结果
            string[] re = new string[8];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();

            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本2
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_2(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            //保存结果
            string[] re = new string[9];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本3
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_3(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            //保存结果
            string[] re = new string[10];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本4
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_4(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            //保存结果
            string[] re = new string[11];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本5
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_5(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            //保存结果
            string[] re = new string[13];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本6
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_6(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            var color_zhu = json["color_zhu"];
            //保存结果
            string[] re = new string[14];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();
            re[13] = color_zhu.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本7
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_7(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            var color_zhu = json["color_zhu"];
            var mc_banben = json["mc_banben"];
            //保存结果
            string[] re = new string[15];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();
            re[13] = color_zhu.ToString();
            re[14] = mc_banben.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本8
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_8(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            var color_zhu = json["color_zhu"];
            var mc_banben = json["mc_banben"];
            var users = json["users"];
            var dengru_url = json["dengru_url"];
            var users_xaunzhe = json["users_xaunzhe"];
            var dengru_fangshi = json["dengru_fangshi"];
            //保存结果
            string[] re = new string[19];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();
            re[13] = color_zhu.ToString();
            re[14] = mc_banben.ToString();
            re[15] = users.ToString();
            re[16] = dengru_url.ToString();
            re[17] = users_xaunzhe.ToString();
            re[18] = dengru_fangshi.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本9
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_9(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            var color_zhu = json["color_zhu"];
            var mc_banben = json["mc_banben"];
            var users = json["users"];
            var dengru_url = json["dengru_url"];
            var users_xaunzhe = json["users_xaunzhe"];
            var dengru_fangshi = json["dengru_fangshi"];
            var mima = json["mima"];
            //保存结果
            string[] re = new string[20];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();
            re[13] = color_zhu.ToString();
            re[14] = mc_banben.ToString();
            re[15] = users.ToString();
            re[16] = dengru_url.ToString();
            re[17] = users_xaunzhe.ToString();
            re[18] = dengru_fangshi.ToString();
            re[19] = mima.ToString();


            return re;
        }
        /// <summary>
        /// 解析读取的配置文件 版本11
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_11(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var yonghuming = json["yonghuming"];
            var accessToken = json["accessToken"];
            var clientToken = json["clientToken"];
            var id = json["id"];
            var java_path = json["java_path"];
            var Sever_id = json["Sever_id"];
            var MinRAM = json["MinRAM"];
            var banben = json["banben"];
            var username = json["username"];
            var mc_path = json["mc_path"];
            var juzi = json["juzi"];
            var serverIP = json["serverIP"];
            var serverName = json["serverName"];
            var color_zhu = json["color_zhu"];
            var mc_banben = json["mc_banben"];
            var users = json["users"];
            var dengru_url = json["dengru_url"];
            var users_xaunzhe = json["users_xaunzhe"];
            var dengru_fangshi = json["dengru_fangshi"];
            var mima = json["mima"];
            var neicun_zong = json["neicun_zong"];
            var sys_banben = json["sys_banben"];
            var java_banben = json["java_banben"];
            var gpu = json["gpu"];
            var cpu = json["cpu"];
            var cpu_hexin = json["cpu_hexin"];
            var yingpan = json["yingpan"];
            var diannao_xinghao = json["diannao_xinghao"];
            //保存结果
            string[] re = new string[28];
            re[0] = yonghuming.ToString();
            re[1] = accessToken.ToString();
            re[2] = clientToken.ToString();
            re[3] = id.ToString();
            re[4] = java_path.ToString();
            re[5] = Sever_id.ToString();
            re[6] = MinRAM.ToString();
            re[7] = banben.ToString();
            re[8] = username.ToString();
            re[9] = mc_path.ToString();
            re[10] = juzi.ToString();
            re[11] = serverIP.ToString();
            re[12] = serverName.ToString();
            re[13] = color_zhu.ToString();
            re[14] = mc_banben.ToString();
            re[15] = users.ToString();
            re[16] = dengru_url.ToString();
            re[17] = users_xaunzhe.ToString();
            re[18] = dengru_fangshi.ToString();
            re[19] = mima.ToString();
            re[20] = neicun_zong.ToString();
            re[21] = sys_banben.ToString();
            re[22] = java_banben.ToString();
            re[23] = gpu.ToString();
            re[24] = cpu.ToString();
            re[25] = cpu_hexin.ToString();
            re[26] = yingpan.ToString();
            re[27] = diannao_xinghao.ToString();


            return re;
        }




        /// <summary>
        /// 解析统一通行证 第一次登入后返回的数据
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>解析的字符串</returns>
        public static string[] TYTXZ_frist_dengru_jiexi(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            //访问令牌
            var accessToken = json["accessToken"];
            //客户端UUID
            var clientToken = json["clientToken"];
            //玩家UUID
            var selectedProfile_L = json["selectedProfile"];
            var json1 = (JObject)JsonConvert.DeserializeObject(selectedProfile_L.ToString());
            var selectedProfile = json1["id"];
            var user = json1["name"];
            //保存数据
            string[] result = new string[4];
            result[0] = accessToken.ToString();
            result[1] = clientToken.ToString();
            result[2] = selectedProfile.ToString();
            result[3] = user.ToString();
            //返回结果
            return result;
        }
        /// <summary>
        /// 解析统一通行证 获取服务器信息返回的数据
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>解析的字符串</returns>
        public static string[] TYTXZ_huoquxinxi(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var meta = json["meta"];
            var json1 = (JObject)JsonConvert.DeserializeObject(meta.ToString());
            //服务器IP
            var serverIP = json1["serverIP"];
            //服务器名称
            var serverName = json1["serverName"];
            //保存数据
            string[] result = new string[2];
            result[0] = serverIP.ToString();
            result[1] = serverName.ToString();
            //返回结果
            return result;

        }


        /// <summary>
        /// 解析外置登入 获取服务器信息返回的数据
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>解析的字符串</returns>
        public static string[] auth_huoquxinxi(string str)
        {
            try
            {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var meta = json["meta"];
            var json1 = (JObject)JsonConvert.DeserializeObject(meta.ToString());
            //服务器名称
            var serverName = json1["serverName"];
            //保存数据
            string[] result = new string[1];
            result[0] = serverName.ToString();
            //返回结果
            return result;

            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 解析外置登入 第一次登入后返回的数据
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>解析的字符串</returns>
        public static string[] Auth_frist_dengru_jiexi(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            //访问令牌
            var accessToken = json["accessToken"];
            //客户端UUID
            var clientToken = json["clientToken"];
            //availableProfiles 可选的角色列表
            var availableProfiles = json["availableProfiles"];
            var json1 = (JArray)JsonConvert.DeserializeObject(availableProfiles.ToString());
            //建立数组
            string[] result = new string[2 + json1.Count * 2];

            for (int i = 0; i < json1.Count; i++)
            {
                JObject obj = (JObject)json1[i];
                var id = obj["id"];
                var name = obj["name"];
                result[2 + i * 2] = id.ToString();
                result[3 + i * 2] = name.ToString();
            }
            //保存数据
            result[0] = accessToken.ToString();
            result[1] = clientToken.ToString();
            //返回结果
            return result;
        }
        /// <summary>
        /// 解析外置登入 刷新令牌
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>解析的字符串</returns>
        public static string[] Auth_shuaxin(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            //访问令牌
            var accessToken = json["accessToken"];
            //客户端UUID
            var clientToken = json["clientToken"];
            //玩家UUID
            var selectedProfile_L = json["selectedProfile"];
            var json1 = (JObject)JsonConvert.DeserializeObject(selectedProfile_L.ToString());
            var selectedProfile = json1["id"];
            var user = json1["name"];
            //保存数据
            string[] result = new string[4];
            result[0] = accessToken.ToString();
            result[1] = clientToken.ToString();
            result[2] = selectedProfile.ToString();
            result[3] = user.ToString();
            //返回结果
            return result;
        }


    }

    /// <summary>
    /// 负责进行HTTP调用的铺助类
    /// </summary>
    public static class HttpRequestHelper
    {
        /// <summary>
        /// 通过HTTP下载文件
        /// </summary>
        /// <param name="path">文件保存路径</param>
        /// <param name="url">文件下载URL</param>
        /// <returns>是否成功</returns>
        public static async Task<bool> downloadAsync(string path, string url)
        {
            string newFileName = path;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var ms = await response.Content.ReadAsStreamAsync();
                        using (var br = new BinaryReader(ms))
                        {
                            var data = br.ReadBytes((int)ms.Length);
                            File.WriteAllBytes(newFileName, data);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception exc)
                {
                    return false;
                }


                return true;
            }
        }


        /// <summary>
        /// HTTP进行POST请求 返回string
        /// </summary>
        /// <param name="Url">目标URL</param>
        /// <param name="postDataStr">传递的数据</param>
        /// <returns>返回字符串</returns>
        public static async Task<string> HttpPostAsync(string Url, string postDataStr)
        {

            HttpResponseMessage httpResponse = null;
            string rawMessage = null;
            HttpClient Client = new HttpClient();
            try
            {
                //初始化目标
                StringContent contents = new StringContent(postDataStr, Encoding.UTF8, "application/json");
                //进行HTTP请求
                httpResponse = await Client.PostAsync(Url, contents);
                //解析结果
                rawMessage = await httpResponse.Content.ReadAsStringAsync();
                httpResponse.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                return "F" + ex.Message;
            }

            return rawMessage;
        }

        /// <summary>
        /// HTTP进行POST请求 返回 bool 用来验证默认令牌
        /// </summary>
        /// <param name="Url">目标URL</param>
        /// <param name="postDataStr">传递的数据</param>
        /// <returns>返回结果</returns>
        public static async Task<bool> HttpPostAsync_yuan(string Url, string postDataStr)
        {

            HttpResponseMessage httpResponse = null;
            HttpClient Client = new HttpClient();
            try
            {
                //初始化目标
                StringContent contents = new StringContent(postDataStr, Encoding.UTF8, "application/json");
                //进行HTTP请求
                httpResponse = await Client.PostAsync(Url, contents);
                //解析结果
                httpResponse.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        /*
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                        request.Method = "POST";
                        request.ContentType = "application/json";
                        request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
                        //request.CookieContainer = cookie;
                        Stream myRequestStream = request.GetRequestStream();
                        StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("utf-8"));
                        myStreamWriter.Write(postDataStr);
                        myStreamWriter.Close();

                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        //response.Cookies = cookie.GetCookies(response.ResponseUri);
                        Stream myResponseStream = response.GetResponseStream();
                        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                        string retString = myStreamReader.ReadToEnd();
                        myStreamReader.Close();
                        myResponseStream.Close();

                        return retString;
                    }
                    catch (Exception e)
                    {
                        //isSuccess = false;
                        Console.Write(e.Message);
                        return e.Message;
                    }
                    */

        public static string HttpGet(string Url, string postDataStr)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = "application/json";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch
            {
                return null;
            }
        }

        /// <summary> 
        /// 创建GET方式的HTTP请求 
        /// </summary> 
        //public static HttpWebResponse CreateGetHttpResponse(string url, int timeout, string userAgent, CookieCollection cookies)
        public static HttpWebResponse CreateGetHttpResponse(string url)
        {
            HttpWebRequest request = null;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //对服务端证书进行有效性校验（非第三方权威机构颁发的证书，如自己生成的，不进行验证，这里返回true）
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;    //http版本，默认是1.1,这里设置为1.0
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "GET";

            //设置代理UserAgent和超时
            //request.UserAgent = userAgent;
            //request.Timeout = timeout;
            //if (cookies != null)
            //{
            //    request.CookieContainer = new CookieContainer();
            //    request.CookieContainer.Add(cookies);
            //}
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary> 
        /// 创建POST方式的HTTP请求 
        /// </summary> 
        //public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters, int timeout, string userAgent, CookieCollection cookies)
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest request = null;
            //如果是发送HTTPS请求 
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                //request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "POST";
            request.ContentType = "application/json";

            //设置代理UserAgent和超时
            //request.UserAgent = userAgent;
            //request.Timeout = timeout;

            //if (cookies != null)
            //{
            //    request.CookieContainer = new CookieContainer();
            //    request.CookieContainer.Add(cookies);
            //}
            //发送POST数据 
            if (!(parameters == null || parameters.Count == 0))
            {
                StringBuilder buffer = new StringBuilder();
                int i = 0;
                foreach (string key in parameters.Keys)
                {
                    if (i > 0)
                    {
                        buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                    }
                    else
                    {
                        buffer.AppendFormat("{0}={1}", key, parameters[key]);
                        i++;
                    }
                }
                byte[] data = Encoding.ASCII.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            string[] values = request.Headers.GetValues("Content-Type");
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 获取请求的数据
        /// </summary>
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();

            }
        }

        /// <summary>
        /// 验证证书
        /// </summary>
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;
            return false;
        }
    }

    public static class Bat
    {
        /// <summary>
        /// 根据参数新建bat脚本 启动原版MC
        /// </summary>
        /// <param name="banben">版本</param>
        /// <param name="yonghuming">用户名</param>
        /// <param name="accessToken">访问令牌</param>
        /// <param name="clientToken">客户端UUID</param>
        /// <param name="id">玩家UUID</param>
        /// <param name="java_path">Java安装路径</param>
        /// <param name="Sever_id">服务器ID</param>
        /// <param name="MinRAM">最低内存大小</param>
        /// <param name="username">游戏内名字</param>
        /// <returns>是否成功创建</returns>
        public static bool xinjian_bat_v(string sever_id, int banben, string accessToken, string id, string java_path, string MinRAM, string username, string path,int dengru_fangshi)
        {
            //判断登入方式
            string dengru_zhujian = "";
            switch (dengru_fangshi)
            {
                case 0:
                    dengru_zhujian = " -javaagent:" + path + ".minecraft\\nide8auth.jar=" + sever_id;
                    break;
                case 1:
                    dengru_zhujian = " -javaagent:" + path + ".minecraft\\authlib.jar=" + sever_id + "/api/yggdrasil";
                    break;
                case 2:
                    break;
            }
            //模板bat
            string str = "\"C:\\Program Files\\Java\\jre1.8.0_241\\bin\\java.exe\" -javaagent:C:\\Users\\Littl\\Documents\\MC\\nide8auth.jar=9ff1539e6e7a11ea908800163e095b49 -Dminecraft.client.jar=.minecraft\\versions\\1.12.2\\1.12.2.jar -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -XX:-UseAdaptiveSizePolicy -XX:-OmitStackTraceInFastThrow -Xmn128m -Xmx2048m -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=C:\\Users\\Littl\\Documents\\MC\\.minecraft\\versions\\1.12.2\\natives -Dminecraft.launcher.brand=HMCL -Dminecraft.launcher.version=3.3.156 -cp C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\mojang\\patchy\\1.1\\patchy-1.1.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\mojang\\authlib\\1.5.25\\authlib-1.5.25.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;C:\\Users\\Littl\\Documents\\MC\\.minecraft\\versions\\1.12.2\\1.12.2.jar net.minecraft.client.main.Main --username LittleFish --version \"HMCL 3.3.156\" --gameDir C:\\Users\\Littl\\Documents\\MC\\.minecraft\\versions\\1.12.2 --assetsDir C:\\Users\\Littl\\Documents\\MC\\.minecraft\\assets --assetIndex 1.12 --uuid dc3014e03c923d2387848962c030ca85 --accessToken a3118d1d6f1111ea908800163e095b49 --width 854 --height 480 -Xss512K -XX:+AggressiveOpts -XX:+UseCompressedOops -XX:+UseCMSCompactAtFullCollection -XX:+UseFastAccessorMethods -XX:ParallelGCThreads=4 -XX:+UseConcMarkSweepGC -XX:CMSFullGCsBeforeCompaction=2 -XX:CMSInitiatingOccupancyFraction=70 -XX:-DisableExplicitGC -XX:TargetSurvivorRatio=90\nPAUSE";
            //修改后的脚本
            string result = "\"" + java_path + "\""+dengru_zhujian+" -Dminecraft.client.jar=.minecraft\\versions\\1.12.2\\1.12.2.jar -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -XX:-UseAdaptiveSizePolicy -XX:-OmitStackTraceInFastThrow -Xmn128m -Xmx" + MinRAM + " -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=" + path + ".minecraft\\versions\\1.12.2\\1.12.2-natives -Dminecraft.launcher.brand=HMCL -Dminecraft.launcher.version=3.3.156 -cp " + path + ".minecraft\\libraries\\com\\mojang\\patchy\\1.1\\patchy-1.1.jar;" + path + ".minecraft\\libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;" + path + ".minecraft\\libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;" + path + ".minecraft\\libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;" + path + ".minecraft\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;" + path + ".minecraft\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" + path + ".minecraft\\libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;" + path + ".minecraft\\libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;" + path + ".minecraft\\libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;" + path + ".minecraft\\libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;" + path + ".minecraft\\libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;" + path + ".minecraft\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" + path + ".minecraft\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" + path + ".minecraft\\libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;" + path + ".minecraft\\libraries\\com\\mojang\\authlib\\1.5.25\\authlib-1.5.25.jar;" + path + ".minecraft\\libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;" + path + ".minecraft\\libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;" + path + ".minecraft\\libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;" + path + ".minecraft\\libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;" + path + ".minecraft\\libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;" + path + ".minecraft\\libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;" + path + ".minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;" + path + ".minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;" + path + ".minecraft\\versions\\1.12.2\\1.12.2.jar net.minecraft.client.main.Main --username " + username + " --version \"XKL 1." + banben + "\" --gameDir " + path + ".minecraft\\versions\\1.12.2 --assetsDir " + path + ".minecraft\\assets --assetIndex 1.12 --uuid " + id + " --accessToken " + accessToken + " --width 854 --height 480 -Xss512K -XX:+AggressiveOpts -XX:+UseCompressedOops -XX:+UseCMSCompactAtFullCollection -XX:+UseFastAccessorMethods -XX:ParallelGCThreads=4 -XX:+UseConcMarkSweepGC -XX:CMSFullGCsBeforeCompaction=2 -XX:CMSInitiatingOccupancyFraction=70 -XX:-DisableExplicitGC -XX:TargetSurvivorRatio=90";

            //将bat写入文件
            FileStream xiaFile = new FileStream(path + ".minecraft\\versions\\1.12.2\\mc.bat", FileMode.Create);
            byte[] buf = Encoding.Default.GetBytes(result);
            xiaFile.Write(buf, 0, buf.Length);
            xiaFile.Flush();
            xiaFile.Close();

            xiaFile = new FileStream(path + ".minecraft\\versions\\1.12.2\\1.bat", FileMode.Create);
            buf = Encoding.UTF8.GetBytes("cd /d %~dp0\nmc.bat");
            xiaFile.Write(buf, 0, buf.Length);
            xiaFile.Flush();
            xiaFile.Close();

            return true;
        }
        /// <summary>
        /// 根据参数新建bat脚本 启动模组服务器
        /// </summary>
        /// <param name="banben">版本</param>
        /// <param name="yonghuming">用户名</param>
        /// <param name="accessToken">访问令牌</param>
        /// <param name="clientToken">客户端UUID</param>
        /// <param name="id">玩家UUID</param>
        /// <param name="java_path">Java安装路径</param>
        /// <param name="Sever_id">服务器ID 或 登入验证地址</param>
        /// <param name="MinRAM">最低内存大小</param>
        /// <param name="username">游戏内名字</param>
        /// <returns>是否成功创建</returns>
        public static string xinjian_bat_F(string sever_id, int banben, string accessToken, string id, string java_path, string MinRAM, string username, string path,int dengru_fangshi)
        {
            //判断登入方式
            string dengru_zhujian = "";
            switch(dengru_fangshi)
            {
                case 0:
                    dengru_zhujian =" -javaagent:"+path+ ".minecraft\\nide8auth.jar=" + sever_id;
                    break;
                case 1:
                    dengru_zhujian = " -javaagent:" + path + ".minecraft\\authlib.jar=" + sever_id+ "/api/yggdrasil";
                    break;
                case 2:
                    break;
            }
            //处理路径
            //模板bat
            string str = "\"C:\\Program Files\\Java\\jre1.8.0_241\\bin\\java.exe\" -javaagent:C:\\Users\\Littl\\Documents\\nide8auth.jar=9ff1539e6e7a11ea908800163e095b49 -Dminecraft.client.jar=.minecraft\\versions\\1.12.2\\1.12.2.jar -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -XX:-UseAdaptiveSizePolicy -XX:-OmitStackTraceInFastThrow -Xmn128m -Xmx2048m -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=C:\\Users\\Littl\\Documents\\.minecraft\\versions\\星空神域\\星空神域-natives -Dminecraft.launcher.brand=HMCL -Dminecraft.launcher.version=3.3.156 -cp C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\mojang\\patchy\\1.1\\patchy-1.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\mojang\\authlib\\1.5.25\\authlib-1.5.25.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\minecraftforge\\forge\\1.12.2-14.23.5.2847\\forge-1.12.2-14.23.5.2847.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\minecraft\\launchwrapper\\1.12\\launchwrapper-1.12.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\ow2\\asm\\asm-all\\5.2\\asm-all-5.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\jline\\jline\\3.5.1\\jline-3.5.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\typesafe\\akka\\akka-actor_2.11\\2.3.3\\akka-actor_2.11-2.3.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\com\\typesafe\\config\\1.2.1\\config-1.2.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-actors-migration_2.11\\1.1.0\\scala-actors-migration_2.11-1.1.0.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-compiler\\2.11.1\\scala-compiler-2.11.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\plugins\\scala-continuations-library_2.11\\1.0.2\\scala-continuations-library_2.11-1.0.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\plugins\\scala-continuations-plugin_2.11.1\\1.0.2\\scala-continuations-plugin_2.11.1-1.0.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-library\\2.11.1\\scala-library-2.11.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-parser-combinators_2.11\\1.0.1\\scala-parser-combinators_2.11-1.0.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-reflect\\2.11.1\\scala-reflect-2.11.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-swing_2.11\\1.0.1\\scala-swing_2.11-1.0.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\scala-lang\\scala-xml_2.11\\1.0.2\\scala-xml_2.11-1.0.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\lzma\\lzma\\0.0.1\\lzma-0.0.1.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\java3d\\vecmath\\1.5.2\\vecmath-1.5.2.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\apache\\maven\\maven-artifact\\3.5.3\\maven-artifact-3.5.3.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;C:\\Users\\Littl\\Documents\\.minecraft\\versions\\1.12.2\\1.12.2.jar net.minecraft.launchwrapper.Launch --username MC_Nirvana --version \"XKL 1.3\" --gameDir C:\\Users\\Littl\\Documents\\.minecraft\\versions\\星空神域 --assetsDir C:\\Users\\Littl\\Documents\\.minecraft\\assets --assetIndex 1.12 --uuid 1b6f8f0f43b5488eb25859bfab6016fb --accessToken eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiI3ODY3ZTc4ZjU0MGZiZjlhZWExMGMyY2QxNDBiMjllYiIsInlnZ3QiOiIwZWU3MTBjNzI5Nzc0MmEyOTIwZmRjN2M1YWQyZmJlNCIsInNwciI6IjFiNmY4ZjBmNDNiNTQ4OGViMjU4NTliZmFiNjAxNmZiIiwiaXNzIjoiWWdnZHJhc2lsLUF1dGgiLCJleHAiOjE1ODUyODQ5MTQsImlhdCI6MTU4NTExMjExNH0.t1gdBVwI504noCsB8Q3HbF8l_qTZX_OTAr0OfpguMNg --userType mojang --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker --versionType Forge --width 854 --height 480 -Xss512K -XX:+AggressiveOpts -XX:+UseCompressedOops -XX:+UseCMSCompactAtFullCollection -XX:+UseFastAccessorMethods -XX:ParallelGCThreads=4 -XX:+UseConcMarkSweepGC -XX:CMSFullGCsBeforeCompaction=2 -XX:CMSInitiatingOccupancyFraction=70 -XX:-DisableExplicitGC -XX:TargetSurvivorRatio=90\\nPAUSE";
            //修改后的脚本
            string result = "\"" + java_path + "\""+dengru_zhujian + " -Dminecraft.client.jar=.minecraft\\versions\\1.12.2\\1.12.2.jar -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -XX:-UseAdaptiveSizePolicy -XX:-OmitStackTraceInFastThrow -Xmn128m -Xmx" + MinRAM + " -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=" + path + ".minecraft\\versions\\星空神域\\星空神域-natives -Dminecraft.launcher.brand=HMCL -Dminecraft.launcher.version=3.3.156 -cp " + path + ".minecraft\\libraries\\com\\mojang\\patchy\\1.1\\patchy-1.1.jar;" + path + ".minecraft\\libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;" + path + ".minecraft\\libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;" + path + ".minecraft\\libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;" + path + ".minecraft\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;" + path + ".minecraft\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" + path + ".minecraft\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" + path + ".minecraft\\libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;" + path + ".minecraft\\libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;" + path + ".minecraft\\libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;" + path + ".minecraft\\libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;" + path + ".minecraft\\libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;" + path + ".minecraft\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" + path + ".minecraft\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" + path + ".minecraft\\libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;" + path + ".minecraft\\libraries\\com\\mojang\\authlib\\1.5.25\\authlib-1.5.25.jar;" + path + ".minecraft\\libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;" + path + ".minecraft\\libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;" + path + ".minecraft\\libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;" + path + ".minecraft\\libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;" + path + ".minecraft\\libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;" + path + ".minecraft\\libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;" + path + ".minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;" + path + ".minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;" + path + ".minecraft\\libraries\\net\\minecraftforge\\forge\\1.12.2-14.23.5.2847\\forge-1.12.2-14.23.5.2847.jar;" + path + ".minecraft\\libraries\\net\\minecraft\\launchwrapper\\1.12\\launchwrapper-1.12.jar;" + path + ".minecraft\\libraries\\org\\ow2\\asm\\asm-all\\5.2\\asm-all-5.2.jar;" + path + ".minecraft\\libraries\\org\\jline\\jline\\3.5.1\\jline-3.5.1.jar;" + path + ".minecraft\\libraries\\com\\typesafe\\akka\\akka-actor_2.11\\2.3.3\\akka-actor_2.11-2.3.3.jar;" + path + ".minecraft\\libraries\\com\\typesafe\\config\\1.2.1\\config-1.2.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-actors-migration_2.11\\1.1.0\\scala-actors-migration_2.11-1.1.0.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-compiler\\2.11.1\\scala-compiler-2.11.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\plugins\\scala-continuations-library_2.11\\1.0.2\\scala-continuations-library_2.11-1.0.2.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\plugins\\scala-continuations-plugin_2.11.1\\1.0.2\\scala-continuations-plugin_2.11.1-1.0.2.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-library\\2.11.1\\scala-library-2.11.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-parser-combinators_2.11\\1.0.1\\scala-parser-combinators_2.11-1.0.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-reflect\\2.11.1\\scala-reflect-2.11.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-swing_2.11\\1.0.1\\scala-swing_2.11-1.0.1.jar;" + path + ".minecraft\\libraries\\org\\scala-lang\\scala-xml_2.11\\1.0.2\\scala-xml_2.11-1.0.2.jar;" + path + ".minecraft\\libraries\\lzma\\lzma\\0.0.1\\lzma-0.0.1.jar;" + path + ".minecraft\\libraries\\java3d\\vecmath\\1.5.2\\vecmath-1.5.2.jar;" + path + ".minecraft\\libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;" + path + ".minecraft\\libraries\\org\\apache\\maven\\maven-artifact\\3.5.3\\maven-artifact-3.5.3.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;" + path + ".minecraft\\versions\\1.12.2\\1.12.2.jar net.minecraft.launchwrapper.Launch --username " + username + " --version \"XKL 1." + banben + "\" --gameDir " + path + ".minecraft\\versions\\星空神域 --assetsDir " + path + ".minecraft\\assets --assetIndex 1.12 --uuid " + id + " --accessToken " + accessToken + " --userType mojang --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker --versionType Forge --width 854 --height 480 -Xss512K -XX:+AggressiveOpts -XX:+UseCompressedOops -XX:+UseCMSCompactAtFullCollection -XX:+UseFastAccessorMethods -XX:ParallelGCThreads=4 -XX:+UseConcMarkSweepGC -XX:CMSFullGCsBeforeCompaction=2 -XX:CMSInitiatingOccupancyFraction=70 -XX:-DisableExplicitGC -XX:TargetSurvivorRatio=90";

            //将bat写入文件
            FileStream xiaFile = new FileStream(path + ".minecraft\\versions\\星空神域\\mc.bat", FileMode.Create);
            byte[] buf = Encoding.Default.GetBytes(result);
            xiaFile.Write(buf, 0, buf.Length);
            xiaFile.Flush();
            xiaFile.Close();

            xiaFile = new FileStream(path + ".minecraft\\versions\\星空神域\\1.bat", FileMode.Create);
            buf = Encoding.UTF8.GetBytes("cd /d %~dp0\nmc.bat");
            xiaFile.Write(buf, 0, buf.Length);
            xiaFile.Flush();
            xiaFile.Close();


            return result;
        }
        /// <summary>
        /// 新建bat打开指定网页
        /// </summary>
        /// <param name="url">要打开的网页</param>
        /// <returns>是否成功</returns>
        public static bool open_url(string url)
        {
            //修改后的脚本
            string result = "start "+url;

            //将bat写入文件
            FileStream xiaFile = new FileStream("mc.bat", FileMode.Create);
            byte[] buf = Encoding.UTF8.GetBytes(result);
            xiaFile.Write(buf, 0, buf.Length);
            xiaFile.Flush();
            xiaFile.Close();
            return true;
        }
    }

    public static class zifuchuang
    {
        /// <summary>
        /// 将ip与端口拆分开
        /// </summary>
        /// <param name="ip">要处理的ip</param>
        /// <returns>1ip 2端口</returns>
        public static string[] fenli_ip(string ip)
        {
            string duankou = "";
            string ip_re = "";
            bool shifouip = true;
            for(int i=0;i<ip.Length; i++)
            {
                if(ip[i]==':')
                {
                    shifouip = false;
                    continue;
                }
                if (shifouip == true)
                {
                    ip_re += ip[i];
                }
                else
                {
                    duankou += ip[i];
                }
            }
            string[] jieguo = new string[2];
            jieguo[0] = ip_re;
            jieguo[1] = duankou;

            return jieguo;
        }
    }
}
