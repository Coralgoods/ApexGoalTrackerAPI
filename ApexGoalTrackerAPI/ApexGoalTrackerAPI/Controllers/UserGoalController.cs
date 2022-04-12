using ApexGoalTrackerAPI.DataObjects;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexGoalTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGoalController : ControllerBase
    {
        // GET: api/<UserGoalController>
        [HttpGet("{name}")]
        public async Task<UserGoal> Get(string name)
        {
            UserGoal user = null;
            using (ApexContext context = new ApexContext())
            {
                user = context.userGoals.Single(u => u.ApexID == name);
            }
            return user;
        }

        // POST api/<UserGoalController>
        [HttpPost]
        public void Post([FromBody] UserGoalApi userGoal)
        {
            UserGoal goal = new UserGoal();
            using (ApexContext context = new ApexContext())
            {
                goal.UserID = userGoal.UserID;
                goal.UserName = userGoal.UserName;
                goal.RankName = userGoal.RankName;
                goal.RankScore = userGoal.RankScore;
                goal.ApexID = userGoal.ApexID;
                context.userGoals.Add(goal);
                context.SaveChanges();
            }
        }

        // PUT api/<UserGoalController>/5
        [HttpPut("{id}")]
        public void Put(int ID,[FromBody] UserGoalApi userGoal)
        {        
            using (ApexContext context = new ApexContext())
            {
                UserGoal goal = context.userGoals.Single(u => u.GoalID == ID);
                goal.UserName = userGoal.UserName;
                goal.RankName = userGoal.RankName;
                goal.RankScore = userGoal.RankScore;
                goal.ApexID = userGoal.ApexID;
                context.userGoals.Update(goal);
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