
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class CurrentStats
    {
        //[ForeignKey("Ticket")]
        //public virtual int ApexID { get; set; }
        [Key]
        public int Id { get; set; }
        public string ApexID { get; set; }
        [ForeignKey("ApexID")]
        public DateTime Date { get; set; }
        public User User { get; set; }
        public int RankSore { get; set; }
        public string RankName { get; set; }
        public string banner { get; set; }
 
    }
}
