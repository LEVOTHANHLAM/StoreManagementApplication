using Newtonsoft.Json;
using PosManager.Model.CaiDat;
using Serilog;

namespace PosManager.APIServices.CaiDat
{
    public class SystemFunctionsController
    {
        public async Task<ApiResponse<ApiResult<List<FunctionsModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(SystemFunctionsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/SystemFunctions/search?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<FunctionsModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<FunctionsModel>>>>(body);

                    Log.Information($"End: {nameof(SystemFunctionsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SystemFunctionsController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, string name, string? createById)
        {
            try
            {
                Log.Information($"Start: {nameof(SystemFunctionsController)}, params; {nameof(Add)},name; {name}");

                string url = Constant.DomainAPI + "/api/SystemFunctions";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new { name = name, createById = createById };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SystemFunctionsController)}, params; {nameof(Add)},name; {name}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SystemFunctionsController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token,string id ,string name, string? lastModifiedById)
        {
            try
            {
                Log.Information($"Start: {nameof(SystemFunctionsController)}, params; {nameof(Edit)},name; {name}");

                string url = Constant.DomainAPI + $"/api/SystemFunctions/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new { name = name, lastModifiedById = lastModifiedById };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SystemFunctionsController)}, params; {nameof(Edit)},name; {name}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SystemFunctionsController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(SystemFunctionsController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/SystemFunctions/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SystemFunctionsController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SystemFunctionsController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
