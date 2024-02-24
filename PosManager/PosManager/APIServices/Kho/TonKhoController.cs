using Newtonsoft.Json;
using PosManager.Model.Kho;
using Serilog;
using System.Net.Http;

namespace PosManager.APIServices.Kho
{
    public class TonKhoController
    {
        public async Task<ApiResponse<ApiResult<List<TonKhoViewModel>>>> Search(string token, string pageIndex = "1", string pageSize = "9999999", string? searchString = "", string? makho = "", string? maHangHoa = "")
        {
            try
            {
                Log.Information($"Start: {nameof(TonKhoController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/TonKho?maKho={makho}&maHangHoa={maHangHoa}&pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<TonKhoViewModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<TonKhoViewModel>>>>(body);

                    Log.Information($"End: {nameof(TonKhoController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(TonKhoController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
