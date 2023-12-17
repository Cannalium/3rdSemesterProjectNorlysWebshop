namespace WebshopClientDesktop.ServiceLayer
{
    public class ServiceConnection : IServiceConnection
    {
        public ServiceConnection(String inBaseUrl)
        {
            HttpEnabler = new HttpClient();
            BaseUrl = inBaseUrl;
            UseUrl = BaseUrl;
        }

        public HttpClient HttpEnabler { private get; init; }
        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        // Sends a POST request to the specified URL with the provided JSON content and returns the HTTP response
        public async Task<HttpResponseMessage?> CallServicePost(StringContent postJson)
        {
            HttpResponseMessage hrm = null;
            if (UseUrl != null)
            {
                hrm = await HttpEnabler.PostAsync(UseUrl, postJson);
            }
            return hrm;
        }

        // Sends a GET request to the specified URL and returns the HTTP response
        public async Task<HttpResponseMessage> CallServiceGet()
        {
            return await HttpEnabler.GetAsync(UseUrl);
        }

        // Sends a PUT request to the specified URL with the provided JSON content and returns the HTTP response
        public async Task<HttpResponseMessage?> CallServicePut(StringContent putJson)
        {
            HttpResponseMessage? hrm = null;
            if (UseUrl != null)
            {
                hrm = await HttpEnabler.PutAsync(UseUrl, putJson);
            }
            return hrm;
        }

        // Sends a DELETE request to the specified URL and returns the HTTP response
        public async Task<HttpResponseMessage?> CallServiceDelete()
        {
            HttpResponseMessage? hrm = null;
            if (UseUrl != null)
            {
                hrm = await HttpEnabler.DeleteAsync(UseUrl);
            }
            return hrm;
        }

    }
}
