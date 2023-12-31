using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
    public class ApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/v1/destinationspractice", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/v1/destinationspractice/{id}", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async void Post(string newDestination)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/v1/destinationspractice", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newDestination);
            await client.PostAsync(request);
        }

        public static async void Put(int id, string updateDestination)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/v1/destinationspractice/{id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(updateDestination);
            await client.PutAsync(request);
        }

        public static async void Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/v1/destinationspractice/{id}", Method.Delete);
            request.AddHeader("Content-Type", "application/json");
            await client.DeleteAsync(request);
        }
    }
}