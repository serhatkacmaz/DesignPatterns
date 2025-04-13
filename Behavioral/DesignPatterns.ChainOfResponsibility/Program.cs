
        using DesignPatterns.ChainOfResponsibility;

        var context = new FileContext
        {
            PdfUrl = "https://example.com/report.pdf"
        };

        IFileHandler download = new PdfDownloadHandler();
        IFileHandler convert = new PdfToExcelHandler();
        IFileHandler upload = new ExcelToCdnHandler();

        download.SetNext(convert);
        convert.SetNext(upload);

        download.Handle(context);
    