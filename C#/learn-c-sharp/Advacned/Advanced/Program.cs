using System;
using System.Collections.Generic;
using Advanced.Generics;
using Advanced.Delegates;
using Advanced.LambdaExpressions;



namespace Advanced
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //generics test
            //Console.WriteLine("Hello World!");
            //Book b1 = new Book { isbn = 1243,
            //    title = "The Lord of The Rings" };

            //Book b2 = new Book
            //{
            //    isbn = 2345,
            //    title = "Game of Thrones"
            //};
            //Book b3 = new Book
            //{
            //    isbn = 3456,
            //    title = "Harry Potter"
            //};



            //var intList = new GenericList<int>();
            //var bookList = new GenericList<Book>();

            //intList.add(1);
            //intList.add(2);

            //bookList.add(b1);
            //bookList.add(b2);
            //bookList.add(b3);

            ////can just use built in
            //var list2 = new List<Book>();

            //var number = new Nullable<int>(5);
            //Console.WriteLine("has value: {0}", number.hasValue);
            //Console.WriteLine("value: {0}", number.getValueOrDefault());

            //delegates test
            //var photoProcessor = new PhotoProcessor();
            //var photoFilters = new PhotoFilters();

            ////delegate can hold a reference to one or multiple functions
            //Action<Photo> handler = photoFilters.ApplyContrast;
            //handler += photoFilters.ApplyBrightness;
            //handler += photoFilters.Resize;
            //handler += RemoveRedEyeFilter;
            //photoProcessor.Process("some path", handler);

            //Lambda Expressions test
            var lambdaTest = new LambdaExpressionTest();



        }

        //example of a generic comparison method
        //max<T> T is the template parameter
        //here we use constraint to an interface
        //see generics classes for more examples
        public T max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Removed Red eye");
        }

    }



    public class GenericList<T>
    {
        public void add (T value)
        {  


        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


}
