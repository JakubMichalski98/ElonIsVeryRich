using ElonIsVeryRich.Data;
using ElonIsVeryRich.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonIsVeryRich.Logic
{
    public class AppManager
    {
        private ApiHelper apiHelper = new();
        public async Task<List<LaunchModel>> GetAllLaunches()
        {
            List<LaunchModel> allLaunches = await apiHelper.GetLaunches();

            return allLaunches;
        }

        public async Task<List<RocketModel>> GetAllRockets()
        {
            List<RocketModel> allRockets = await apiHelper.GetRockets();

            return allRockets;
        }

        public async Task<int> CalculateTotalPrice()
        {
            List<LaunchModel> launches = await GetAllLaunches();
            List<RocketModel> rockets = await GetAllRockets();
            int totalCost = 0;

            foreach (var launch in launches)
            {
                string rocketId = launch.Rocket.RocketId;
                RocketModel? rocket = rockets.FirstOrDefault(r => r.RocketId == rocketId);
                totalCost += rocket.CostPerLaunch;
            }

            return totalCost;
        }
    }
}
