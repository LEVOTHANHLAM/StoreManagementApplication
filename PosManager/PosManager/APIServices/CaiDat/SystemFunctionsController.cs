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
    }
}
