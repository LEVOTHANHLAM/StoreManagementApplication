namespace PosManager.APIServices
{
    public class ApiResult<T> where T : class
    {
        public int Total { get; set; }
        public T? Result { get; set; }
    }
}
