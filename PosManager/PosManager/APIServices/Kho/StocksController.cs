using Newtonsoft.Json;
using PosManager.Model.Kho;
using Serilog;
using System.Net.Http;

namespace PosManager.APIServices.Kho
{
    public class StocksController
    {
        public async Task<ApiResponse<ApiResult<List<StockModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/stocks?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<StockModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<StockModel>>>>(body);

                    Log.Information($"End: {nameof(StocksController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, StockModel stock)
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(Add)},MaKho; {stock.MaKho}");

                string url = Constant.DomainAPI + "/api/stocks";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maKho = stock.MaKho,
                    tenKho = stock.TenKho
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StocksController)}, params; {nameof(Add)},MaKho; {stock.MaKho}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, StockModel stock)
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(Edit)},MaKho; {stock.MaKho}");

                string url = Constant.DomainAPI + $"/api/stocks/{stock.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maKho = stock.MaKho,
                    tenKho = stock.TenKho,
                    lastModifiedById = ""
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StocksController)}, params; {nameof(Edit)},MaKho; {stock.MaKho}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/stocks/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StocksController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<StockModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(Search)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/stocks/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<StockModel> data = JsonConvert.DeserializeObject<ApiResponse<StockModel>>(body);

                    Log.Information($"End: {nameof(StocksController)}, params; {nameof(Search)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<List<StockModel>>> GetAll(string token)
        {
            try
            {
                Log.Information($"Start: {nameof(StocksController)}, params; {nameof(GetAll)}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/Stocks/all";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<List<StockModel>> data = JsonConvert.DeserializeObject<ApiResponse<List<StockModel>>>(body);

                    Log.Information($"End: {nameof(StocksController)}, params; {nameof(GetAll)}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StocksController)}, params; {nameof(GetAll)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
