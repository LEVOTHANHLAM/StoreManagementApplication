using Newtonsoft.Json;
using PosManager.APIServices.ChiNhanh;
using PosManager.Model.ChiNhanh;
using PosManager.Model.HoaDon;
using Serilog;
using System.Net.Http;

namespace PosManager.APIServices.HoaDon
{
    public class HoaDonNhapController
    {
        public async Task<ApiResponse<ApiResult<List<HoaDonNhapModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(HoaDonNhapController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/HoaDonNhap?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<HoaDonNhapModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<HoaDonNhapModel>>>>(body);

                    Log.Information($"End: {nameof(HoaDonNhapController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(HoaDonNhapController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, HoaDonNhapModel model)
        {
            try
            {
                Log.Information($"Start: {nameof(StoresController)}, params; {nameof(Edit)}");

                string url = Constant.DomainAPI + $"/api/HoaDonNhap/{model.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    ghiChu = model.GhiChu,
                    tienGiam = 0,
                    ngayDenHan =model.NgayDenHan,
                    ngayThanhToan = model.NgayThanhToan,
                    trangThai = model.TrangThai
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(StoresController)}, params; {nameof(Edit)}");
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

                string url = Constant.DomainAPI + $"/api/HoaDonNhap/{id}";
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
        public async Task<ApiResponse<HoaDonNhapModel>> GetById(string token, string id)
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
                    string apiUrl = $"{Constant.DomainAPI}/api/HoaDonNhap/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<HoaDonNhapModel> data = JsonConvert.DeserializeObject<ApiResponse<HoaDonNhapModel>>(body);

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
    }
}
