using ApexGoalTrackerAPI.ApexApiDataObjects;
using ApexGoalTrackerAPI.DataObjects;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApexGoalTrackerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: /<UserController>/userName
        [HttpGet("{userName}")]
        public async Task<User> Get(string userName)
        {
            User user = null;
            using (ApexContext context = new ApexContext())
            {
                user = context.Users.Single(u => u.UserName == userName);
            }
            return user;
        }


        // POST api/<UserController>
        [HttpPost]
        public void Create([FromBody] User user)

        {
            
            using (ApexContext context = new ApexContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{userName}")]
        public void Update(string userName, [FromBody] string ApexId)
        {
            User user = null;
            using (ApexContext context = new ApexContext())
            {
                user = context.Users.Single(u => u.UserName == userName);
                user.ApexID = ApexId;
                context.SaveChanges();
            }
            
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{userName}")]
        public void Delete(string userName)
        {
            User user = null;
            using (ApexContext context = new ApexContext())
            {
                user = context.Users.Single(u => u.UserName == userName);
                context.Users.Remove(user);
                context.SaveChanges();
                
            }

            //open db context
            //grab user by userName
            //delete user
            //save changes

        }
    }
}

//    // GET: /<UserController>/name
//    [HttpGet("{name}")]
//    public async Task<User> Get(string name)
//    {
//        string apiUri = $"https://apex-legends.p.rapidapi.com/stats/{name}/PC";
//        var apiTask = await apiUri.WithHeaders(new
//        {
//            x_rapidapi_host = "apex-legends.p.rapidapi.com",
//            x_rapidapi_key = "a5b04e6222mshe0376e842564881p134a29jsnd3f1bd79e8cc"
//        }).GetJsonAsync<ApexApiDataObject>();
//        var user = new User();
//        user.UserName = apiTask.global.name;
//        user.ApexID = apiTask.global.uid.ToString();
//       // user.Password = 
//        return user;
//    }