using Snacklager.Logic.Enums;
using System.ComponentModel.DataAnnotations;

namespace Snacklager.Web.Models
{
    public class SnackCreateVm
    {
        [Display(Name = "Snack Art")]
        [Required]
        public SnackArtEnum SnackArt { get; set; } = SnackArtEnum.Apfel;
        public int SnackArtId => (int)SnackArt;

        [Display(Name = "Snack Name")]
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Display(Name = "Gewicht pro Einheit")]
        public double? GewichtProEinheit { get; set; }
    }
}