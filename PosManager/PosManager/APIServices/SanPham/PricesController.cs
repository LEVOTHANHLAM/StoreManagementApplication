using Newtonsoft.Json;
using PosManager.Model.SanPham;
using Serilog;
using System.Net.Http;

namespace PosManager.APIServices.SanPham
{
    public class PricesController
    {
        public async Task<ApiResponse<string?>> Add(string token, List<PriceModel> prices)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Add)},Ma; {prices.Count}");

                string url = Constant.DomainAPI + "/api/prices";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var content = new StringContent(JsonConvert.SerializeObject(prices), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Add)},Ma;{prices.Count}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, List<PriceModel> prices)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Edit)},MaKho;{prices.Count}");

                string url = Constant.DomainAPI + $"/api/prices";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var content = new StringContent(JsonConvert.SerializeObject(prices), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Edit)},MaKho; {prices.Count}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
