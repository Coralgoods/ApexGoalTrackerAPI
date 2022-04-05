
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;


namespace ApexGoalTrackerAPI.DataObjects
{
    public class CurrentStatsUpdate
    {
        //Not used. 
        public int Id { get; set; }
        public string ApexID { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public int RankSore { get; set; }
        public string RankName { get; set; }
        public string banner { get; set; }
 
    }
}
