namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        var resumeFactory = new ResumeFactory();
        var resume = resumeFactory.CreateDocument();
        resume.CreatePages();

        var reportFactory = new ReportFactory();
        var report = reportFactory.CreateDocument();
        report.CreatePages();
    }
}

public interface IDocument
{
    public void CreatePages();
}

public class Resume : IDocument
{
    public void CreatePages()
    {
        System.Console.WriteLine("Creating Resume pages...");
    }

}

public class Report : IDocument
{
    public void CreatePages()
    {
        System.Console.WriteLine("Creating Report pages...");
    }
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

public class ResumeFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new Resume();
    }
}

public class ReportFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new Report();
    }
}