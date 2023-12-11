using Newtonsoft.Json;
using PosManager.Model.User;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.APIServices.User
{
    public class AuthenticateController
    {
        public async Task<ApiResponse<UserLoginModel>> Login(string username, string password)
        {
            try
            {
                Log.Information($"Start: {nameof(AuthenticateController)}, params; {nameof(Login)},username; {username}, password; {password}");

                string url = Constant.DomainAPI + "/api/Authenticate/login";
                HttpClient httpClient = new HttpClient();
                var requestData = new { username = username, password = password };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<UserLoginModel> data = JsonConvert.DeserializeObject<ApiResponse<UserLoginModel>>(body);

                Log.Information($"End: {nameof(AuthenticateController)}, params; {nameof(Login)},username; {username}, password; {password}, body; {body}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(AuthenticateController)}, params; {nameof(Login)},username; {username}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
