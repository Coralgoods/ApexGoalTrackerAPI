using ApexGoalTrackerAPI.DataObjects;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApexGoalTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGoalController : ControllerBase
    {
        // GET: api/<UserGoalController>
        [HttpGet]
        public async Task<UserGoal> Get()
        {
            string apiUri = "";
            var apiTask = await apiUri.WithHeaders(new
            {
                x_rapidapi_host = "apex-legends.p.rapidapi.com",
                x_rapidapi_key = "a5b04e6222mshe0376e842564881p134a29jsnd3f1bd79e8cc"
            }).GetJsonAsync<UserGoal>();

            return apiTask;
        }

        // POST api/<UserGoalController>
        [HttpPost]
        public void Post([FromBody] UserGoal userGoal)
        {
            UserGoal goal = new UserGoal();
            using (ApexContext context = new ApexContext())
            {
                goal.RankName = userGoal.RankName;
                goal.RankScore = userGoal.RankScore;
                context.userGoals.Add(goal);
                context.SaveChanges();
            }
        }

        // PUT api/<UserGoalController>/5
        [HttpPut("{id}")]
        public void Put(string ApexId, [FromBody] UserGoal userGoal)
        {
            UserGoal goal = new UserGoal();
            using (ApexContext context = new ApexContext())
            {
                goal.RankName = userGoal.RankName;
                goal.RankScore = userGoal.RankScore;
                context.userGoals.Add(goal);
                context.SaveChanges();
            }
        }

        // DELETE api/<UserGoalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}