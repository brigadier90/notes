using System;

namespace Advanced.Generics
{
    //class constraint. can be product or any of its subclasses
    public class DiscountCalculator<TProduct> where TProduct: Product
    {
        public double calculateDiscount(TProduct product)
        {
            //point is we have access to price
            return product.price * 0.25;
        }
    }


    //value Type constraint
    public class Nullable<T> where T : struct
    {
        //value types cannot be null
        //can use this class to give value types the ability to be nullable
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool hasValue
        {
            get { return _value != null; }
        }

        public T getValueOrDefault()
        {
            if (hasValue)
                return (T)_value;

            return default(T);
        }




    }

    public class Product
    {
        public double price { get; set; }
        public String title { get; set; }
    }

    public class Book : Product
    {
        public Book(string Title, double Price)
        {
            this.title = Title;
            this.price = Price;
        }
        public int isbn { get; set; }
    }
}
