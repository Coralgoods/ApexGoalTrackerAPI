using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;
using ApexGoalTrackerAPI.DataObjects;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApexGoalTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentStatsController : ControllerBase
    {
        global _Userglobal = null; 
        legends _Legends = null;

        // GET: api/<CurrentStatsController>
        //[HttpGet("{ApexID}")]
        [HttpGet]
        public async Task<AllCurrentStats> GetUserStats([FromBody] UserApi userApi)
        {

           AllCurrentStats currentStats = new AllCurrentStats();

            using (ApexContext context = new ApexContext())
            {               
                //currentStats.allCurrentStats = context.currentStats.ToList(); //Works for all records
                currentStats.allCurrentStats = context.currentStats.Where(u => u.ApexID == userApi.ApexID).ToList();
            }
            return currentStats; 
        }


        //[HttpGet]
        //public async Task<AllCurrentStats> GetAllUserStats()  
        //{
        //    AllCurrentStats currentStats = new AllCurrentStats();

        //    using (ApexContext context = new ApexContext())
        //    {
        //        currentStats.allCurrentStats = context.currentStats.ToList(); 
        //    }
        //    return currentStats;
        //}

        // POST api/<CurrentStatsController>
        [HttpPost] 
        public void Post([FromBody] UserApi input)  //rename to something better? 
        {
          
            string apiUri = $"https://apex-legends.p.rapidapi.com/stats/{input.ApexID}/PC";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "apex-legends.p.rapidapi.com",
                x_rapidapi_key = "8e11e7cd1bmsh10d1c1dfc12f043p1ed678jsnb8551f95bb79"
            }).GetJsonAsync<Global_legends>();

            apiTask.Wait();

            _Userglobal = apiTask.Result.global;
            _Legends = apiTask.Result.legends;

            CurrentStats currentStats = new CurrentStats();
            using (ApexContext context = new ApexContext())
            {

                currentStats.UserID = input.UserID; 
                currentStats.ApexID = _Userglobal.name; //Might need to change this to input.ApexID 
                currentStats.Date = DateTime.Now;
                currentStats.RankSore = _Userglobal.rank.rankScore; 
                currentStats.RankName = _Userglobal.rank.rankName;
                currentStats.banner = _Legends.selected.ImgAssets.banner;
                currentStats.UserName = input.UserName;
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
