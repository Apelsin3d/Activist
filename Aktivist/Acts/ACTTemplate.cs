// Ignore Spelling: Aktivist

using System.Reflection.Metadata.Ecma335;

namespace AktivistBL.Acts
{
    public class ACTTemplate
    {
        public const string ACTTitle = "АКТ №";
        public const string ACTTitle2 = "огляду технічного стану пристрою /товару";
        public readonly string ManagerText = "Цим Актом сервіс менеджер в особі {0}, з метою оцінки технічного  стану пристрою провів огляд на предмет відсутності дефектів в товарі.";
        public const string Defect = "Заявлений споживачем недолік:";
        public const string Examination = "При проведенні обстеження оцінювалися:  \r\n" +
            "1. Перевірка зовнішнього вигляду товару. \r\n" +
            "2. Перевірка механічних пошкоджень, розривів або вм'ятин на самому товарі.  \r\n" +
            "3. Перевірка на працездатність та відповідність заявлених характеристик.\r\n";
        public const string Result = "Висновок: \r\n";

        private static string GetName(string managerName) => $"Цим Актом сервіс менеджер в особі {managerName}, з метою оцінки технічного  стану пристрою провів огляд на предмет відсутності дефектів в товарі.";

        public ACTTemplate(string managerName)
        {
            ManagerText = GetName(managerName);
        }

        public override string ToString()
        {
            return ACTTitle + ACTTitle2 + "\r\n" + ManagerText + "\r\n" + Defect + "\r\n" + Examination + "\r\n" + Result;
        }

    }
}
