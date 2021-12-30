using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Album_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum albm1 = new PhotoAlbum();
            Console.WriteLine(albm1.GetNumberOfPages());

            PhotoAlbum albm2 = new PhotoAlbum();
            Console.WriteLine(albm2.GetNumberOfPages());

            BigPhotoAlbum albm3 = new BigPhotoAlbum();
            Console.WriteLine(albm1.GetNumberOfPages());

            Console.ReadKey();
        }
    }
    public class PhotoAlbum
    {
        protected int numPages;
        public int GetNumberOfPages()
        {
            
            return numPages;
        }
        public PhotoAlbum()
        {
            numPages =16;
        }
    }
    public class BigPhotoAlbum:PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numPages = 64;
        }
    }
}
