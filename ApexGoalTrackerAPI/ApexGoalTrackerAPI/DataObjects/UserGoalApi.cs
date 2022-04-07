
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserGoalApi
    {
        //public int GoalID { get; set; }
        //public int UserID { get; set; }
        public string UserName { get; set; }
        public string ApexID { get; set; }
        public int RankScore { get; set; }
        public string RankName { get; set; }
    }
}
