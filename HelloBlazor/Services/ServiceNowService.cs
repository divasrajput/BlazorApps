using static HelloBlazor.Services.IServiceNow;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace HelloBlazor.Services
{

    public class ServiceNowService
    {
        public async Task GetOpenIncidents()
        {
            string apiUrl = "https://dev181114.service-now.com/api/1050846/get_incidents/open/incidents";

            try
            {
                HttpResponseMessage response = await Http.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throw exception for non-2xx status codes

                string responseBody = await response.Content.ReadAsStringAsync();
                List<Incident> incidents = JsonConvert.DeserializeObject<List<Incident>>(responseBody); // Assuming JSON response format

                // Update UI with the retrieved incidents (explained in step 3)
            }
            catch (HttpRequestException ex)
            {
                // Handle API call errors gracefully (explained in step 4)
            }
        }

    }

}
