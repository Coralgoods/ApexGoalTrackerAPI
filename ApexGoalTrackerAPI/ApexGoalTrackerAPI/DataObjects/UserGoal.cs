
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserGoal
    {
        [Key]
        public string UserName { get; set; }      
        [ForeignKey("UserName")]
        public User User { get; set; }
        public int RankScore { get; set; }
        public string RankName { get; set; }
        public string ApexID { get; set; }
    }
}
