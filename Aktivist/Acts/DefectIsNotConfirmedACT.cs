
namespace AktivistBL.Acts
{
    public class DefectIsNotConfirmedACT : BaseACT
    {
        public DefectIsNotConfirmedACT(string id, DateTime data, string city, string serviceManager, string goodsName, string serialNumber, string defect, string assembly, byte[] signature) : base(id, data, city, serviceManager, goodsName, serialNumber, defect, assembly, signature)
        {

        }

        public string? Reason { get; set; }

        public override string GenerateContent()
        {
            //TODO: Implement this method
            var baseACT = base.GenerateContent();


            return baseACT + $"Причина відсутності дефекту: {Reason} \r\n";
        }
    }
}
