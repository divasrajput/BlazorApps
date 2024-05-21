namespace HelloBlazor.Services
{
    public interface IServiceNow
    {
        Task<IEnumerable<Incident>> GetEmployees();
        //Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest request);
    }
}
