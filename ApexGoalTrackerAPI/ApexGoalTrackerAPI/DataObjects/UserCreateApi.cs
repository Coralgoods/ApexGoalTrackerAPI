using System.ComponentModel.DataAnnotations; 

namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserCreateApi
    {
       
        
        public string UserName { get; set; }
       
        public string ApexID { get; set; }
       
        public string Password { get; set; }
    }
}
