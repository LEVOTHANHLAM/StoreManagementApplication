using Newtonsoft.Json;
using PosManager.Model.Kho;
using Serilog;

namespace PosManager.APIServices.Kho
{
    public class WarehousesController
    {
        public async Task<ApiResponse<string?>> Add(string token, WarehouseModel model)
        {
            try
            {
                Log.Information($"Start: {nameof(WarehousesController)}, params; {nameof(Add)},MaKho; {model.MaKho}");

                string url = Constant.DomainAPI + "/api/warehouses";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(WarehousesController)}, params; {nameof(Add)},MaKho; {model.MaKho}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(WarehousesController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
