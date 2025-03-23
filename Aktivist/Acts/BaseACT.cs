// Ignore Spelling: Aktivist

namespace AktivistBL.Acts
{
    public abstract class BaseACT
    {
        internal const string ACTTitle = "АКТ №";
        internal const string ACTTitle2 = "огляду технічного стану пристрою /товару";
        public readonly string ManagerText = "Цим Актом сервіс менеджер в особі {0}, з метою оцінки технічного  стану пристрою провів огляд на предмет відсутності дефектів в товарі.";
        internal const string DeclaredDefect = "Заявлений споживачем недолік:";
        internal const string Examination = "При проведенні обстеження оцінювалися:  \r\n" +
            "1. Перевірка зовнішнього вигляду товару. \r\n" +
            "2. Перевірка механічних пошкоджень, розривів або вм'ятин на самому товарі.  \r\n" +
            "3. Перевірка на працездатність та відповідність заявлених характеристик.\r\n";
        internal const string Result = "Висновок: \r\n";
        public string? Id { get; set; }
        public DateTime Date { get; set; }
        public string? City { get; set; }
        public string? GoodName { get; set; }
        public string? SerialNumber { get; set; }
        public string? Defect { get; set; }
        public string? Assembly { get; set; }
        public byte[]? SignatureImage { get; set; }
        public string ServiceManager { get; set; }

        public virtual string GenerateContent()
        {
            return $"{ACTTitle} {Id} \r\n" +
                $" {ACTTitle2} \r\n" +
                $"м.: {City} \r\n" +
                $"Найменування товару: {GoodName} \r\n" +
                $"Серійний номер: {SerialNumber} \r\n" +
                $"Дата: {Date} \r\n" +
                $"Сервіс менеджер: {ServiceManager} \r\n" +
                $"{ManagerText} \r\n" +
                $"{DeclaredDefect} {Defect} \r\n" +
                $"{Examination} \r\n" +
                $"{Result} \r\n";
        }

        public BaseACT(string id, DateTime data, string city, string serviceManager, string goodsName, string serialNumber, string defect, string assembly, byte[] signature)
        {
            Id = id;
            Date = data;
            City = city;
            ServiceManager = serviceManager;
            GoodName = goodsName;
            SerialNumber = serialNumber;
            Defect = defect;
            Assembly = assembly;
            SignatureImage = signature;
            ManagerText = string.Format(ManagerText, serviceManager);
            SignatureImage = signature;
        }
    }


}
