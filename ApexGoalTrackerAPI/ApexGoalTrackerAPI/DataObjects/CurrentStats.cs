
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class CurrentStats
    {

        [Key]
        public int Id { get; set; }
        public string ApexID { get; set; }
        public string UserName { get; set; }
        [ForeignKey("UserName")]
        public User User { get; set; }
        public DateTime Date { get; set; }
        public int RankSore { get; set; }
        public string RankName { get; set; }
        public string banner { get; set; }

    }
}
