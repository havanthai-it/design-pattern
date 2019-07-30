using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FactoryMethod
{
    class FactoryMethodProgram
    {
        public static void Run()
        {
            IImageReader reader = null;
            List<string> images = new List<string> { "image1.gif", "image2.jpg" };
            List<DecodedImage> decodedImages = new List<DecodedImage>();

            foreach (var image in images)
            {
                string imageType = image.Split('.')[1];

                switch (imageType)
                {
                    case "gif":
                        reader = new GifReader(image);
                        break;
                    case "jpg":
                        reader = new JpgReader(image);
                        break;
                }

                decodedImages.Add(reader.Decode());
            }
        }
    }
}
