using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FactoryMethod
{
    interface IImageReader
    {
        DecodedImage Decode();
    }

    class DecodedImage
    {
        public string Image { get; set; }
    }

    class GifReader : IImageReader
    {
        public DecodedImage Decoded { get; set; }

        public GifReader(string image)
        {
            Decoded = new DecodedImage() { Image = image };
        }

        public DecodedImage Decode()
        {
            Console.WriteLine("Gif image is decoded!");
            return Decoded;
        }
    }

    class JpgReader : IImageReader
    {
        public DecodedImage Decoded { get; set; }

        public JpgReader(string image)
        {
            Decoded = new DecodedImage() { Image = image };
        }

        public DecodedImage Decode()
        {
            Console.WriteLine("Jpg image is decoded!");
            return Decoded;
        }
    }
}
