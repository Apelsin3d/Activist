using AktivistBL.Acts;

namespace AktivistBL.Interface
{
    public interface IReportGenerator
    {
        Task<string> GenerateAsync(BaseACT sertificate);
    }
}
