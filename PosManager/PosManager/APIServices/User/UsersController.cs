using Newtonsoft.Json;
using PosManager.Model.User;
using Serilog;
using System.Net.Http;

namespace PosManager.APIServices.User
{
    public class UsersController
    {
        public async Task<ApiResponse<ApiResult<List<UserModel>>>> Search(string token, string pageIndex = "1", string pageSize = "10", string? searchString = "")
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/Users?pageIndex={pageIndex}&pageSize={pageSize}&searchString={searchString}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<ApiResult<List<UserModel>>> data = JsonConvert.DeserializeObject<ApiResponse<ApiResult<List<UserModel>>>>(body);

                    Log.Information($"End: {nameof(UsersController)}, params; {nameof(Search)},pageIndex; {pageIndex}, pageSize; {pageSize}, searchString; {searchString}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Edit(string token, string id, UserModel user)
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(Edit)},id; {id}");

                string url = Constant.DomainAPI + $"/api/users/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    email = user.Email,
                    fullName = user.FullName,
                    phoneNumber = user.PhoneNumber,
                    cccd = user.CCCD,
                    address = user.Address,
                    dateOfBirth = user.DateOfBirth,
                    role = user.Role,
                    lastModifiedById = "",
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(UsersController)}, params; {nameof(Edit)},id; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(Edit)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> Delete(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(Delete)},name; {id}");

                string url = Constant.DomainAPI + $"/api/users/{id}";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(UsersController)}, params; {nameof(Delete)},name; {id}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(Delete)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<UserModel>> GetById(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(Search)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/users/{id}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<UserModel> data = JsonConvert.DeserializeObject<ApiResponse<UserModel>>(body);

                    Log.Information($"End: {nameof(UsersController)}, params; {nameof(Search)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(Search)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<List<PermissionModel>>> GetPermissionsByIdUser(string token, string id)
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(GetPermissionsByIdUser)},id; {id}");

                // Tạo HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thêm Authorization header
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    // Tạo URL của API endpoint
                    string apiUrl = $"{Constant.DomainAPI}/api/users/{id}/permissions";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    var body = await response.Content.ReadAsStringAsync();
                    ApiResponse<List<PermissionModel>> data = JsonConvert.DeserializeObject<ApiResponse<List<PermissionModel>>>(body);

                    Log.Information($"End: {nameof(UsersController)}, params; {nameof(GetPermissionsByIdUser)},id; {id}");
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(GetPermissionsByIdUser)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
        public async Task<ApiResponse<string?>> UpdatePermissionsByIdUser(string token, PermissionUpdateModel updateModel)
        {
            try
            {
                Log.Information($"Start: {nameof(UsersController)}, params; {nameof(UpdatePermissionsByIdUser)},id; {updateModel.UserId}");

                string url = Constant.DomainAPI + $"/api/users/permissions";
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var requestData = new
                {
                    userId = updateModel.UserId,
                    functionId = updateModel.FunctionId,
                    command = updateModel.Command,
                    newValue = updateModel.NewValue
                };
                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(url, content);
                var body = await response.Content.ReadAsStringAsync();
                ApiResponse<string?> data = JsonConvert.DeserializeObject<ApiResponse<string?>>(body);

                Log.Information($"End: {nameof(UsersController)}, params; {nameof(UpdatePermissionsByIdUser)},id; {updateModel.UserId}");
                return data;
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(UsersController)}, params; {nameof(UpdatePermissionsByIdUser)},token; {token}, Error; {ex.Message}, Exception; {ex}");
                return null;
            }
        }
    }
}
