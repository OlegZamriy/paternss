using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class RealImageService : IImageService
    {
        private string imageFilePath;

        public RealImageService(string imageFilePath)
        {
            this.imageFilePath = imageFilePath;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {imageFilePath}");
        }

        public void DisplayImage()
        {
            Console.WriteLine($"Displaying image: {imageFilePath}");
        }
    }

}
