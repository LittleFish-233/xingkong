using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xingkong.daima
{
    /// <summary>
    /// 管理统一通行证的最底层类 直接进行Http调用的类
    /// </summary>
    public static class minecraft_TYTXZ
    {
        /// <summary>
        /// 首次登录
        /// </summary>
        /// <param name="sever_id">服务器的32位ID</param>
        /// <param name="yonghu">用户名</param>
        /// <param name="mima">密码</param>
        /// <returns>1访问令牌 2客户端UUID 3玩家UUID</returns>
        public static async System.Threading.Tasks.Task<string[]> dengru_fristAsync(string sever_id, string yonghu, string mima, int banben, string clientToken)
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
                string result = await daima.HttpRequestHelper.HttpPostAsync("https://auth2.nide8.com:233/" + sever_id + "/authserver/authenticate", data);
                //解析返回的数据
                return daima.Json_String.TYTXZ_frist_dengru_jiexi(result);
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
        public static async System.Threading.Tasks.Task<bool> yanzhengAsync(string accessToken, string clientToken, string sever_id)
        {
            try
            {
                //初始化Json数据
                string data = new JObject(
                                        new JProperty("clientToken", clientToken),
                                        new JProperty("accessToken", accessToken)).ToString();
                //调用http 发送到目标URL
                bool result = await daima.HttpRequestHelper.HttpPostAsync_yuan("https://auth2.nide8.com:233/" + sever_id + "/authserver/validate", data);
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
        public static async Task<string[]> Huoqu_xinxiAsync(string sever_id)
        {
            string result= await daima.HttpRequestHelper.HttpPostAsync("https://auth2.nide8.com:233/" + sever_id + "/","");
            return daima.Json_String.TYTXZ_huoquxinxi(result);
        }



    }
}
