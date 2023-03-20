using ElonIsVeryRich.Data.Models;
using Newtonsoft.Json;

namespace ElonIsVeryRich.Data
{
    public class ApiHelper
    {
        public static HttpClient HttpClient { get; set; } = new();

        public static void InitializeClient()
        {
            HttpClient.BaseAddress = new Uri("https://api.spacexdata.com/v3/");
        }
        public async Task<List<LaunchModel>> GetLaunches()
        {

            List<LaunchModel> launches = new();

            var response = await HttpClient.GetAsync("launches");

            var responseString = await response.Content.ReadAsStringAsync();

            List<LaunchRoot>? launchRoot = JsonConvert.DeserializeObject<List<LaunchRoot>>(responseString);

            foreach (var launchModel in launchRoot)
            {
                LaunchModel newLaunchModel = new()
                {
                    MissionName = launchModel.MissionName,
                    FlightNumber = launchModel.FlightNumber,
                    LaunchYear = launchModel.LaunchYear,
                    Rocket = launchModel.Rocket
                };

                launches.Add(newLaunchModel);
            }

            return launches;

        }

        public async Task<List<RocketModel>> GetRockets()
        {
            List<RocketModel> rockets = new();

            var response = await HttpClient.GetAsync("rockets");

            var responseString = await response.Content.ReadAsStringAsync();

            List<RocketRoot>? rocketRoot = JsonConvert.DeserializeObject<List<RocketRoot>>(responseString);

            foreach (var rocketModel in rocketRoot)
            {
                RocketModel newRocketModel = new()
                {
                    RocketId = rocketModel.RocketId,
                    CostPerLaunch = rocketModel.CostPerLaunch
                };

                rockets.Add(newRocketModel);
            }

            return rockets;
        }

    }
}