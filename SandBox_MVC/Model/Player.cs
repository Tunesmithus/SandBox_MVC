using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SandBox_MVC.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        [ForeignKey("TeamId")]
        [ValidateNever]
        public Team Team { get; set; }

        [Display(Name ="Team")]
        public int TeamId { get; set; }

        [Display(Name ="Conract Start")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Conract End")]
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }





    }
}
