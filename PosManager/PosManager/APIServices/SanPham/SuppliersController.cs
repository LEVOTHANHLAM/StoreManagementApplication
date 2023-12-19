using Newtonsoft.Json;
using PosManager.Model.SanPham;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.APIServices.SanPham
{
    public class SuppliersController
    {
        public async Task<ApiResponse<ApiResult<List<SupplierModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(SuppliersController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/suppliers?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<SupplierModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<SupplierModel>>>>(body);

                    Log.Information($"End: {nameof(SuppliersController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SuppliersController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, SupplierModel supplierModel)
        {
            try
            {
                Log.Information($"Start: {nameof(SuppliersController)}, params; {nameof(Add)},Ma; {supplierModel.MaNhaCungCap}");

                string url = Constant.DomainAPI + "/api/suppliers";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maNhaCungCap = supplierModel.MaNhaCungCap,
                    tenNhaCungCap = supplierModel.TenNhaCungCap,
                    diaChi = supplierModel.DiaChi,
                    soDienThoai = supplierModel.SoDienThoai,
                    createById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SuppliersController)}, params; {nameof(Add)},Ma; {supplierModel.MaNhaCungCap}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SuppliersController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, SupplierModel supplierModel)
        {
            try
            {
                Log.Information($"Start: {nameof(SuppliersController)}, params; {nameof(Edit)},Ma;  {supplierModel.Id}");

                string url = Constant.DomainAPI + $"/api/suppliers/{supplierModel.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maNhaCungCap = supplierModel.MaNhaCungCap,
                    tenNhaCungCap = supplierModel.TenNhaCungCap,
                    diaChi = supplierModel.DiaChi,
                    soDienThoai = supplierModel.SoDienThoai,
                    lastModifiedById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SuppliersController)}, params; {nameof(Edit)},Ma;  {supplierModel.Id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SuppliersController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(SuppliersController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/suppliers/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(SuppliersController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SuppliersController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<SupplierModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(SuppliersController)}, params; {nameof(GetById)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/suppliers/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<SupplierModel> data = JsonConvert.DeserializeObject<ApiResponse<SupplierModel>>(body);

                    Log.Information($"End: {nameof(SuppliersController)}, params; {nameof(GetById)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(SuppliersController)}, params; {nameof(GetById)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
