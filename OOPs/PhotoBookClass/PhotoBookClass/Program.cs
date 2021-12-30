using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook album1 = new PhotoBook();
            Console.WriteLine(album1.GetNumberPages());

            PhotoBook album2= new PhotoBook(24);
            Console.WriteLine(album2.GetNumberPages());

            BigPhotoBook album3 = new BigPhotoBook();
            Console.WriteLine(album3.GetNumberPages());

            Console.ReadKey();

        }
    }
    
    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
     
    } 
    public class BigPhotoBook:PhotoBook
    {
       
        public BigPhotoBook()
        {
             numPages = 64;
        }
    }


}
