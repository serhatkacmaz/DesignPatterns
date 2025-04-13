namespace DesignPatterns.ChainOfResponsibility;

public class ExcelToCdnHandler : IFileHandler
{
    private IFileHandler _next;

    public void SetNext(IFileHandler next)
    {
        _next = next;
    }

    public void Handle(FileContext context)
    {
        if (string.IsNullOrEmpty(context.ExcelPath))
        {
            Console.WriteLine("Excel dosyası yok. Yükleme yapılamaz.");
            return;
        }

        Console.WriteLine("CDN'e yükleniyor...");
        Console.WriteLine("CDN yolu: cdn://uploads/document.xlsx");
    }
}
