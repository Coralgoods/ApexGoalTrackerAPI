
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class CurrentStats
    {

        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public string ApexID { get; set; }
        public int ApexLevel { get; set; }
        public int NextLevelPercent { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public int RankSore { get; set; }
        public string RankName { get; set; }
        public int RankDiv { get; set; }
        public string RankImg { get; set; }
        public string RankedSeason { get; set; }
        public string SelectedLegend { get; set; }
        public string icon { get; set; }
        public string banner { get; set; }

    }
}
