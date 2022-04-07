using System.ComponentModel.DataAnnotations; 

namespace ApexGoalTrackerAPI.DataObjects
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        public string ApexID { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}
