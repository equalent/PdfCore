namespace SPDFCore
{
    public class PdfDocument
    {
        public static string DefaultDocumentProducer => $"SPDFCore RT {typeof(PdfDocument).Assembly.GetName().Version}";
        
        public string DocumentProducer = DefaultDocumentProducer;
    }
}