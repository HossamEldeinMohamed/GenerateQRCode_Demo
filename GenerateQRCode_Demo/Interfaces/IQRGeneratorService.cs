using GenerateQRCode_Demo.Models;

namespace GenerateQRCode_Demo.Interfaces
{
    public interface IQRGeneratorService
    {
        public string GenerateQRCode();
        public void GeneratePDF(Product product);
    }
}
