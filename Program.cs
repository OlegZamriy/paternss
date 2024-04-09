using paternss;
using System;

class Program
{
    static void Main()
    {
        IImageService imageProxy = new ImageProxy("sample_image.jpg");

        imageProxy.DisplayImage();

        Console.ReadLine();
    }
}
