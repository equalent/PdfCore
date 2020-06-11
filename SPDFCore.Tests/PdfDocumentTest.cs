using Xunit;

namespace SPDFCore.Tests
{
    public class PdfDocumentTest
    {
        [Fact]
        public void ValidDefaultDocumentProducer()
        {
            var producer = PdfDocument.DefaultDocumentProducer;
            var validProducer = $"SPDFCore RT {typeof(PdfDocument).Assembly.GetName().Version}";
            Assert.Equal(producer, validProducer);
        }
    }
}