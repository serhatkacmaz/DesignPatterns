namespace DesignPatterns.ChainOfResponsibility;

public class PdfToExcelHandler : IFileHandler
{
    private IFileHandler _next;

    public void SetNext(IFileHandler next)
    {
        _next = next;
    }

    public void Handle(FileContext context)
    {
        if (string.IsNullOrEmpty(context.PdfPath))
        {
            Console.WriteLine("PDF bulunamadı. Dönüştürme iptal.");
            return;
        }

        Console.WriteLine("Excel'e dönüştürülüyor...");
        context.ExcelPath = "/local/path/document.xlsx"; // Simülasyon
        Console.WriteLine($"Excel oluşturuldu: {context.ExcelPath}");

        _next?.Handle(context);
    }
}
