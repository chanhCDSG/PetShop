using System.Text.Json;

namespace PetShop.MVC.Helpers
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false)
            {
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
            }
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = JsonSerializer.Deserialize<T>(
                dataAsString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return result!;
        }
        //public static async Task<T> PostContentAsync<T>(this HttpResponseMessage response)
        //{
        //    if (response.IsSuccessStatusCode == false)
        //    {
        //        throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
        //    }
        //    var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        //    var result = JsonSerializer.Serialize<T>(); return result;
        //}
    }
}
