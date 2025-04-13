namespace DesignPatterns.ChainOfResponsibility;

public interface IFileHandler
{
    void SetNext(IFileHandler next);
    void Handle(FileContext context);
}
