using System.ComponentModel.DataAnnotations;

namespace TaxRecordApi.Models
{
    public class TaxRecord
    {
        public int Id { get; set; }

        [Required]
        public string RecordTitle { get; set; } = string.Empty;

        [Required]
        public int TaxYear { get; set; }

        [Required]
        public decimal IncomeAmount { get; set; }

        [Required]
        public decimal DeductionsAmount { get; set; }

        public string? Notes { get; set; }
    }
}
