using System.ComponentModel.DataAnnotations;

namespace Hospital.Wep.Core.ViewModels
{
    public class PatientEntryFormViewModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(14)]
        public string SSN { get; set; } = null!;
    }
}
