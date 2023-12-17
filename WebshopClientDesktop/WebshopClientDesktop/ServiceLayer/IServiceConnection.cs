namespace WebshopClientDesktop.ServiceLayer
{
    public interface IServiceConnection
    {
        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        Task<HttpResponseMessage?> CallServicePost(StringContent postJson);
        Task<HttpResponseMessage> CallServiceGet();
        Task<HttpResponseMessage?> CallServicePut(StringContent postJson);
        Task<HttpResponseMessage?> CallServiceDelete();
    }
}
