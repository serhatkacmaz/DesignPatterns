namespace DesignPatterns.ChainOfResponsibility;

public class PdfDownloadHandler : IFileHandler
{
    private IFileHandler _next;

    public void SetNext(IFileHandler next)
    {
        _next = next;
    }

    public void Handle(FileContext context)
    {
        Console.WriteLine("PDF indiriliyor...");
        context.PdfPath = "/local/path/document.pdf"; // Simülasyon
        Console.WriteLine($"PDF indirildi: {context.PdfPath}");

        _next?.Handle(context);
    }
}
