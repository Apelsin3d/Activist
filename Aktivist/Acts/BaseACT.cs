// Ignore Spelling: Aktivist

namespace AktivistBL.Acts
{
    public abstract class BaseACT
    {
        public string? Id { get; set; }
        public DateTime Date { get; set; }
        public string? City { get; set; }
        public string? GoodName { get; set; }
        public string? SerialNumber { get; set; }
        public string? Defect { get; set; }
        public string? Assembly { get; set; }
        public byte[]? SignatureImage { get; set; }
        public string ServiceManager { get; set; }
        public ACTTemplate ACTTemplate { get; }

        public abstract string GenerateContent();

        public BaseACT()
        {
            
        }
    }


}
