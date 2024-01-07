﻿using Newtonsoft.Json;
using PosManager.Model.SanPham;
using Serilog;

namespace PosManager.APIServices.SanPham
{
    public class ProductUnitsController
    {
        public async Task<ApiResponse<ApiResult<List<DonViHangHoaModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/productunits?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<DonViHangHoaModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<DonViHangHoaModel>>>>(body);

                    Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Add(string token, DonViHangHoaModel donViHangHoaModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Add)},Ma; {donViHangHoaModel.MaDonViHangHoa}");

                string url = Constant.DomainAPI + "/api/productunits";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maDonViHangHoa = donViHangHoaModel.MaDonViHangHoa,
                    tenDonViHangHoa = donViHangHoaModel.TenDonViHangHoa,
                    createById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Add)},Ma; {donViHangHoaModel.MaDonViHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Add)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, DonViHangHoaModel donViHangHoaModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Edit)},Ma;  {donViHangHoaModel.MaDonViHangHoa}");

                string url = Constant.DomainAPI + $"/api/productunits/{donViHangHoaModel.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maDonViHangHoa = donViHangHoaModel.MaDonViHangHoa,
                    tenDonViHangHoa = donViHangHoaModel.TenDonViHangHoa,
                    lastModifiedById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Edit)},Ma;  {donViHangHoaModel.MaDonViHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/productunits/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<DonViHangHoaModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(GetById)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/productunits/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<DonViHangHoaModel> data = JsonConvert.DeserializeObject<ApiResponse<DonViHangHoaModel>>(body);

                    Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(GetById)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(GetById)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }

        public async Task<ApiResponse<List<DonViHangHoaModel>>> GetAll(string token)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(GetAll)}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/productunits/all";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<List<DonViHangHoaModel>> data = JsonConvert.DeserializeObject<ApiResponse<List<DonViHangHoaModel>>>(body);

                    Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(GetAll)}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(GetAll)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }

        //////////////////////////////////////////////////////////////////////////
        public async Task<ApiResponse<string?>> AddProductUnitDetail(string token, ProductUnitDetailModel productUnitDetailModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Add)},Ma; {productUnitDetailModel.MaDonViHangHoa}");

                string url = Constant.DomainAPI + "/api/productunits/details";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maHangHoa = productUnitDetailModel.MaHangHoa,
                    maDonViHangHoa = productUnitDetailModel.MaDonViHangHoa,
                    tyLeChuyenDoi = productUnitDetailModel.TyLeChuyenDoi,
                    createById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(AddProductUnitDetail)},Ma; {productUnitDetailModel.MaDonViHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(AddProductUnitDetail)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<ProductUnitDetailModel>> GetDetailById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/productunits/details/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ProductUnitDetailModel> data = JsonConvert.DeserializeObject<ApiResponse<ProductUnitDetailModel>>(body);

                    Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<List<ProductUnitDetailModel>>> GetDetailByProductId(string token, string idProduct)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},id; {idProduct}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/productunits/details/products/{idProduct}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<List<ProductUnitDetailModel>> data = JsonConvert.DeserializeObject<ApiResponse<List<ProductUnitDetailModel>>>(body);

                    Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},id; {idProduct}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(GetDetailById)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> UpdateDetail(string token, ProductUnitDetailModel productUnitDetailModel)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Edit)},Ma;  {productUnitDetailModel.MaDonViHangHoa}");

                string url = Constant.DomainAPI + $"/api/productunits/details/{productUnitDetailModel.Id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    maDonViHangHoa = productUnitDetailModel.MaDonViHangHoa,
                    tenDonViHangHoa = productUnitDetailModel.TenDonViHangHoa,
                    lastModifiedById = ""
                };
                var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Edit)},Ma;  {productUnitDetailModel.MaDonViHangHoa}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> DeleteDetail(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(ProductUnitsController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/productunits/details/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(ProductUnitsController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ProductUnitsController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
