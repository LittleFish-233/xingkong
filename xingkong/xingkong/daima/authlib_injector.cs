using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xingkong.daima
{
    public static class authlib_injector
    {
        /// <summary>
        /// 根据服务器URL 获取服务器信息 http:\\mcb2.5imc.xyz:1102
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string[] yanzheng_url(string URL)
        {

            var result = HttpRequestHelper.HttpGet(URL + "/api/yggdrasil", "");

            return daima.Json_String.auth_huoquxinxi(result);
        }

        /// <summary>
        /// 首次登录
        /// </summary>
        /// <param name="sever_id">服务器的验证URL</param>
        /// <param name="yonghu">用户名</param>
        /// <param name="mima">密码</param>
        /// <returns>1访问令牌 2客户端UUID 3玩家UUID</returns>
        public static async System.Threading.Tasks.Task<string[]> dengru_fristAsync(string sever_url, string yonghu, string mima, int banben, string clientToken)
        {
            try
            {
                //检查传递的参数
                if (string.IsNullOrWhiteSpace(clientToken) == true)
                {
                    clientToken = Guid.NewGuid().ToString("N");
                }
                //初始化Json数据
                string data = new JObject(
                                        new JProperty("agent",
                                            new JObject(
                                                new JProperty("name", "Celestial domain"),
                                                new JProperty("version", "1." + banben.ToString()))),//版本号
                                        new JProperty("username", yonghu),
                                        new JProperty("password", mima),
                                        new JProperty("clientToken", clientToken),
                                        new JProperty("requestUser", true)).ToString();
                //调用http 发送到目标URL
                string result = await daima.HttpRequestHelper.HttpPostAsync(sever_url + "/api/yggdrasil/authserver/authenticate", data);
                //解析返回的数据
                return daima.Json_String.Auth_frist_dengru_jiexi(result);
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        /// <summary>
        /// 验证保存的令牌是否有效 用于启动器启动时的自动登入
        /// </summary>
        /// <param name="accessToken">访问令牌</param>
        /// <param name="clientToken">客户端UUID</param>
        /// <returns>是否有效</returns>
        public static async System.Threading.Tasks.Task<bool> yanzhengAsync(string accessToken, string clientToken, string sever_ip)
        {
            try
            {
                //初始化Json数据
                string data = new JObject(
                                        new JProperty("clientToken", clientToken),
                                        new JProperty("accessToken", accessToken)).ToString();
                //调用http 发送到目标URL
                bool result = await daima.HttpRequestHelper.HttpPostAsync_yuan(sever_ip + "/api/yggdrasil/authserver/validate", data);
                //返回数据
                return result;
                //解析返回的数据
                /*if(result=="true")
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
            }
            catch (Exception exc)
            {
                return false;
            }

        }
        /// <summary>
        /// 刷新令牌 用于选择角色
        /// </summary>
        /// <param name="accessToken">访问令牌</param>
        /// <param name="clientToken">客户端UUID</param>
        /// <returns>是否有效</returns>
        public static async System.Threading.Tasks.Task<string[]> shuaxin(string accessToken, string clientToken, string sever_url,string username,string user_id)
        {
            try
            {
                //初始化Json数据
                string data = new JObject(
                                        new JProperty("clientToken", clientToken),
                                        new JProperty("accessToken", accessToken),
                                        new JProperty("requestUser", true),
                                        new JProperty("selectedProfile",
                                            new JObject(
                                                new JProperty("name", username),
                                                new JProperty("id", user_id)))).ToString();
                //调用http 发送到目标URL
                string result = await daima.HttpRequestHelper.HttpPostAsync(sever_url + "/api/yggdrasil/authserver/refresh", data);
                //解析返回的数据
                return daima.Json_String.Auth_shuaxin(result);
                /*if(result=="true")
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
            }
            catch (Exception exc)
            {
                return null;
            }

        }
    }
}
