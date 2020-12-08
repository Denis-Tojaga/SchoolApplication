using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    /// <summary>
    /// Class Image Helper has two static methods
    /// One converts Image to byte array
    /// Second converts byte array to Image
    /// </summary>
    public class ImageConventer
    {

        public static Image FromByteToImage(byte[] byteArray)
        {
            //convert bytes to stream, load image from that stream
            if (byteArray!=null && byteArray.Length!=0)
            {
                MemoryStream ms = new MemoryStream(byteArray);
                return Image.FromStream(ms);
            }
            return null;
        }

        public static byte[] FromImageToByte(Image image)
        {
            //convert image as an array of bytes
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            //return bytes as an array
            return ms.ToArray();
        }
    }
}
