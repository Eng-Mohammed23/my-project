using System.ComponentModel.DataAnnotations;

namespace Hospital.Wep.Core.Models
{
    public class PatientEntry
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(14)]
        public string SSN { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedOn { get; set; }

    }
}
