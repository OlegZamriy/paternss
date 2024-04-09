using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class ImageProxy : IImageService
    {
        private readonly string imageFilePath;
        private RealImageService realImageService;

        public ImageProxy(string imageFilePath)
        {
            this.imageFilePath = imageFilePath;
        }

        public void DisplayImage()
        {
            if (realImageService == null)
            {
                realImageService = new RealImageService(imageFilePath);
            }
            realImageService.DisplayImage();
        }
    }

}
