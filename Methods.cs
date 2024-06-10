using CarseerTask.Models.Base;
using CarseerTask.Models;
using Newtonsoft.Json;

namespace CarseerTask.Services
{
    public class Methods
    {
        public async Task<ReturnResponse<IList<Result>>> GetModelsForMakeIdYear(CarModelREQ_ENT REQ)
        {
            ReturnResponse<IList<Result>> RES = new();
            string url = $"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{REQ.CarMakeId}/modelyear/{REQ.ModelYear}?format=json";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string jsonString = await response.Content.ReadAsStringAsync();
                    RES = JsonConvert.DeserializeObject<ReturnResponse<IList<Result>>>(jsonString);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return RES;
        }
    }
}
