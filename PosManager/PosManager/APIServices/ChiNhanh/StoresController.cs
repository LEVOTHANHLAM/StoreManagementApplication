using Newtonsoft.Json;
using PosManager.Model.ChiNhanh;
using Serilog;

namespace PosManager.APIServices.ChiNhanh
{
    public class StoresController
    {
        public async Task<ApiResponse<ApiResult<List<StoreModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/stores?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<StoreModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<StoreModel>>>>(body);

                    Log.Information($"End: {nameof(StoresController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, StoreModel store)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Add)},MaKho; {store.MaKho}");

                string url = Constant.DomainAPI + "/api/stores";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maCuaHang = store.MaCuaHang,
                    tenCuaHang = store.TenCuaHang,
                    maKho = store.MaKho,
                    createById = ""
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StoresController)}, params; {nameof(Add)},MaKho; {store.MaKho}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, StoreModel store)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Edit)},MaKho; {store.MaKho}");

                string url = Constant.DomainAPI + $"/api/stores/{store.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    tenCuaHang = store.TenCuaHang,
                    maKho = store.MaKho,
                    lastModifiedById = ""
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StoresController)}, params; {nameof(Edit)},MaKho; {store.MaKho}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/stores/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StoresController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<StoreModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Search)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/stores/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<StoreModel> data = JsonConvert.DeserializeObject<ApiResponse<StoreModel>>(body);

                    Log.Information($"End: {nameof(StoresController)}, params; {nameof(Search)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<List<StoreModel>>> GetAll(string token)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(GetAll)}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/stores/all";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<List<StoreModel>> data = JsonConvert.DeserializeObject<ApiResponse<List<StoreModel>>>(body);

                    Log.Information($"End: {nameof(StoresController)}, params; {nameof(GetAll)}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(StoresController)}, params; {nameof(GetAll)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
