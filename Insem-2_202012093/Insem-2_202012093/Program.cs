using System;
using System.Collections.Generic;

namespace Insem_2_202012093
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Q4();
        }*/

        enum PhotoType { Jpeg, Png, Bmp };
        class Jpeg { } /* represents a JPEG file */
        class Filter
        {
            public T GrayScale<T>(T img) { /*convert to grayscale*/ return img; }
        }
        class Png { } /* represents a PNG file */
        class Bmp { } /* represents a BMP file */

        class PhotoStudio
        {
            private Filter filter;
            private List<Jpeg> jpegs;
            private List<Png> pngs;
            private List<Bmp> bmps;
            public void PlaceOrder(List<Jpeg> jpegPhotos, List<Png> pngPhotos, List<Bmp> bmpPhotos, PhotoType
           image)
            {
                switch (image)
                {
                    case PhotoType.Jpeg:
                        filter = new Filter();
                        jpegs = jpegPhotos;
                        break;
                    case PhotoType.Png:
                        filter = new Filter();
                        pngs = pngPhotos;
                        break;
                    case PhotoType.Bmp:
                        filter = new Filter();
                        pngs = pngPhotos;
                        break;
                }
            }
            public List<Jpeg> GetGrayScaleAlbumForJpeg()
            {
                List<Jpeg> album = new List<Jpeg>();
                foreach (var photo in jpegs)
                    album.Add(filter.GrayScale(photo));
                return album;
            }
            public List<Png> GetGrayScaleAlbumForPng()
            {
                List<Png> album = new List<Png>();
                foreach (var photo in pngs)
                    album.Add(filter.GrayScale(photo));
                return album;
            }
        }


        //Q2
        class Embassy
        {
            public static void Main(string[] args)
            {
                List<Applicant> applicants = new List<Applicant>()
            { new Applicant(1), new Applicant(2)};
                VisaProcessor visaProcessor = new VisaProcessor();
                visaProcessor.SetCallbackForVisaStatus(
                    () => { Console.WriteLine("Function CalledBack!!"); }
                );
                foreach (var applicant in applicants)
                    visaProcessor.ProcessVisa(applicant);
                Console.ReadLine();
            }
        }

        class VisaProcessor
        {
            public delegate void MyCallBack();
            public void SetCallbackForVisaStatus(MyCallBack callBackObj)
            {
                callBackObj();
            }

            public void ProcessVisa(Applicant applicant)
            {
                Console.WriteLine("Applicant Id: {0}, Status: {1}", applicant.ID, "Approved");
            }
        }

        class Applicant
        {
            public Applicant(int ID) { this.ID = ID; }
            public int ID { get; }
        }


        //Q3 
        //Line number 6 is Boxing 
        //Line number 8 is unboxing

        //Q4
        public static void Q4()
        {
            

        }
        interface IAnimal
        {
            void Breathe();

        }
        interface IMammal : IAnimal
        {
            void Walk();
        }
        interface IFish : IAnimal
        {
            void Swim();

        }
        class Fish : IFish
        {
            public void Breathe()
            {
                throw new NotImplementedException();
            }

            public void Swim()
            {
                throw new NotImplementedException();
            }
        }
        class Bull : IMammal
        {
            public void Breathe()
            {
                throw new NotImplementedException();
            }

            public void Walk()
            {
                throw new NotImplementedException();
            }
        }

    }
}

