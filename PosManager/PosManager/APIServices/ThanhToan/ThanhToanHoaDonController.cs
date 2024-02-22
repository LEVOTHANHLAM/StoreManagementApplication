using Newtonsoft.Json;
using PosManager.APIServices.ChiNhanh;
using PosManager.Model.ChiNhanh;
using PosManager.Model.ThanhToan;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.APIServices.ThanhToan
{
    public class ThanhToanHoaDonController
    {
        public async Task<ApiResponse<string?>> Add(string token, ThanhToanHoaDonModel model)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Add)}");

                string url = Constant.DomainAPI + "/api/ThanhToanHoaDon";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StoresController)}, params; {nameof(Add)}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
