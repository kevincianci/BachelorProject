namespace WebApi.Models
{
    public class LabelTemplate
    {
        public int Id { get; set; } // Primary Key
        public string TemplateName { get; set; } // Name of the template
        public string StaticElements { get; set; } // JSON for static parts (e.g., logos)
        public string DataMatrixCodeFormat { get; set; } // Format for DataMatrix code
        public string HumanReadableFormat { get; set; } // Text format (e.g., LocationId)
        public string PrinterSettings { get; set; } // Printer-specific settings
    }
}
