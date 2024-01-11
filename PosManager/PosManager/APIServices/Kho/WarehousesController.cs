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
        public async Task<ApiResponse<ApiResult<List<WarehouseModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(WarehousesController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/warehouses?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<WarehouseModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<WarehouseModel>>>>(body);

                    Log.Information($"End: {nameof(WarehousesController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(WarehousesController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<WarehouseModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(WarehousesController)}, params; {nameof(GetById)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/warehouses/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<WarehouseModel> data = JsonConvert.DeserializeObject<ApiResponse<WarehouseModel>>(body);

                    Log.Information($"End: {nameof(WarehousesController)}, params; {nameof(GetById)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(WarehousesController)}, params; {nameof(GetById)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, WarehouseModel warehouse)
        {
            try
            {
                Log.Information($"Start: {nameof(WarehousesController)}, params; {nameof(Edit)},MaKho; {warehouse.Id}");

                string url = Constant.DomainAPI + $"/api/warehouses/{warehouse.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = JsonConvert.SerializeObject(warehouse);
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(WarehousesController)}, params; {nameof(Edit)},MaKho; {warehouse.Id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(WarehousesController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(WarehousesController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/warehouses/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(WarehousesController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(WarehousesController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
