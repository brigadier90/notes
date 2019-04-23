using System;
using Advanced;
using System.Collections.Generic;
using Advanced.Generics;

namespace Advanced.LambdaExpressions
{
    public class LambdaExpressionTest
    {
        public LambdaExpressionTest()
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            Action helloWorld = () => Console.WriteLine("Hello World"); //no args
            helloWorld();

            const int factor = 5;

            Func<int, int, int> AddAndMultiplyByFactor = (num1, num2) => (num1 + num2) * factor;
            Console.WriteLine(AddAndMultiplyByFactor(5,10));

            //most common use
            List<Book> booklist = new List<Book>();
            booklist.Add(new Book("b1", 19));
            booklist.Add(new Book("b2", 7));
            booklist.Add(new Book("b3", 9));

            List<Book> cheapBooks = booklist.FindAll(b => b.price < 10);

            foreach(var b in cheapBooks)
            {
                Console.WriteLine("{0} {1}", b.title, b.price);
            }

        }
    }
}
