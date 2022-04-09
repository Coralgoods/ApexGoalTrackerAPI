using System.ComponentModel.DataAnnotations; 

namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserApi
    {
        public int UserID { get; set; } 
        public string ApexID { get; set; }
        public string UserName { get; set; }
    }
}
