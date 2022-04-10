using System.ComponentModel.DataAnnotations; 

namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserLoginApi
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
