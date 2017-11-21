using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = @"D:\Temp\test.jpg";
            var distination = @"D:\Temp\test_thumb.jpg";
            var dHeight = 300;
            var dWidth = 300;
            var flag = 50;
            ImageCompressor.Compress(source, distination, dHeight, dWidth, flag);
        }
    }
}
