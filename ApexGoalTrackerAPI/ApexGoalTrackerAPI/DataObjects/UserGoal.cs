
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class UserGoal
    {
        [Key]
        public string ApexID { get; set; }
        [ForeignKey("ApexID")]
        public User User { get; set; }
        public int RankScore { get; set; }
        public string RankName { get; set; }

    }
}
