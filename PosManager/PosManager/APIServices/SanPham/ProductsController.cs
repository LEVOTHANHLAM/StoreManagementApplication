using Newtonsoft.Json;
using PosManager.Model.SanPham;
using Serilog;
using System.Text.RegularExpressions;

namespace PosManager.APIServices.SanPham
{
    public class ProductsController
    {
        public async Task<ApiResponse<ApiResult<List<ProductsModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(ProductsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/products?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<ProductsModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<ProductsModel>>>>(body);

                    Log.Information($"End: {nameof(ProductsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductsController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, ProductsModel productsModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductsController)}, params; {nameof(Add)},Ma; {productsModel.MaHangHoa}");

                string url = Constant.DomainAPI + "/api/products";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maHangHoa = productsModel.MaHangHoa,
                    tenHangHoa = productsModel.TenHangHoa,
                    tenHangHoaKhongDau = productsModel.TenHangHoaKhongDau,
                    maNhomHang = productsModel.MaNhomHang,
                    maDonViCoBan = productsModel.MaDonViCoBan,
                    vat = productsModel.VAT,
                    ghiChu = productsModel.GhiChu,
                    maVach = productsModel.MaVach,
                    maQR = productsModel.MaQR,
                    createById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductsController)}, params; {nameof(Add)},Ma;{productsModel.MaHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductsController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, ProductsModel productsModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductsController)}, params; {nameof(Edit)},MaKho; {productsModel.MaHangHoa}");

                string url = Constant.DomainAPI + $"/api/products/{productsModel.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    tenHangHoa = productsModel.TenHangHoa,
                    tenHangHoaKhongDau = productsModel.TenHangHoaKhongDau,
                    maNhomHang = productsModel.MaNhomHang,
                    vat = productsModel.VAT,
                    ghiChu = productsModel.GhiChu,
                    maVach = productsModel.MaVach,
                    maQR = productsModel.MaQR,
                    lastModifiedById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductsController)}, params; {nameof(Edit)},MaKho; {productsModel.MaHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductsController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductsController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/products/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductsController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductsController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<ProductsModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductsController)}, params; {nameof(Search)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/products/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ProductsModel> data = JsonConvert.DeserializeObject<ApiResponse<ProductsModel>>(body);

                    Log.Information($"End: {nameof(ProductsController)}, params; {nameof(Search)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductsController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
