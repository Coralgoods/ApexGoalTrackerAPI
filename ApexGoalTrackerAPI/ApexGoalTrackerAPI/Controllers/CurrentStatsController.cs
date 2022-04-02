using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;
using ApexGoalTrackerAPI.DataObjects; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApexGoalTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentStatsController : ControllerBase
    {

        List<CurrentStats> _UserStats;
        List<global> _UserGlobal;
        List<Global_legends> _UserGlobalLegends;
        List<PlayerList> _PlayerList;



        // GET: api/<CurrentStatsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<CurrentStatsController>
        [HttpPost]
        public void Post([FromBody] CreatedAtActionResult name)
        {

            string apiUri = $"https://apex-legends.p.rapidapi.com/stats/{name}/PC";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "apex-legends.p.rapidapi.com",
                x_rapidapi_key = "8e11e7cd1bmsh10d1c1dfc12f043p1ed678jsnb8551f95bb79"
            }).GetJsonAsync<PlayerList>();

            apiTask.Wait();

            _UserGlobalLegends = apiTask.Result.global_Legends;

            CurrentStats currentStats = new CurrentStats();
            using(ApexContext context = new ApexContext()) 
            {
                global UserGlobal;
                legends legends;

                UserGlobal = apiTask.Result.global_Legends.First().global;
                legends = apiTask.Result.global_Legends.First().legends; 

                currentStats.ApexID = UserGlobal.name;
                currentStats.Date = DateTime.Now;
                currentStats.RankSore = UserGlobal.rank.rankScore;
                currentStats.RankName = UserGlobal.rank.rankName; 
                currentStats.banner = legends.selected.banner.banner; 

                context.currentStats.Add(currentStats);
                context.SaveChanges();
            }

        }

            // PUT api/<CurrentStatsController>/5
            [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CurrentStatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
