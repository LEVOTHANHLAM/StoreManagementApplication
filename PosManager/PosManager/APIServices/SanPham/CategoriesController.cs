using Newtonsoft.Json;
using PosManager.Model.SanPham;
using Serilog;

namespace PosManager.APIServices.SanPham
{
    public class CategoriesController
    {
        public async Task<ApiResponse<ApiResult<List<CategoryModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/categories?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<CategoryModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<CategoryModel>>>>(body);

                    Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, CategoryModel category)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Add)},Ma; {category.MaNhomHang}");

                string url = Constant.DomainAPI + "/api/categories";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maNhomHang = category.MaNhomHang,
                    tenNhomHang = category.TenNhomHang,
                    parentId = category.ParentId,
                    createById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Add)},Ma;{category.MaNhomHang}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, CategoryModel category)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Edit)},MaKho; {category.MaNhomHang}");

                string url = Constant.DomainAPI + $"/api/categories/{category.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maNhomHang = category.MaNhomHang,
                    tenNhomHang = category.TenNhomHang,
                    parentId = category.ParentId,
                    lastModifiedById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Edit)},MaKho; {category.MaNhomHang}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/categories/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<CategoryModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Search)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/categories/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<CategoryModel> data = JsonConvert.DeserializeObject<ApiResponse<CategoryModel>>(body);

                    Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Search)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<CategoryModel>> GetByCode(string token, string code)
        {
            try
            {
                Log.Information($"Start: {nameof(CategoriesController)}, params; {nameof(Search)},id; {code}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/categories/{code}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<CategoryModel> data = JsonConvert.DeserializeObject<ApiResponse<CategoryModel>>(body);

                    Log.Information($"End: {nameof(CategoriesController)}, params; {nameof(Search)},id; {code}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(CategoriesController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
