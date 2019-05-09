#ifndef _MYSTRING_H_
#define _MYSTRING_H_

class MyString {

    private:
        char * str; //pointer to a char[] that holds a c-style string
    
    public:
        MyString();
        MyString(const char * s);
        //copy ctor
        MyString(const MyString &source);
        MyString(MyString &&source); //move does not take const because we will modify source
        ~MyString();

        //operator overloading
        MyString &operator=(const MyString &rhs);
        MyString &operator=(MyString &&rhs);

        //overloading operators as member functins:

        //unary operator overloading:
        //unary operator take no parameters since member function we have access to this.
        MyString operator-() const;

        //binary operators:
        //one param since lhs is this
        MyString operator+(const MyString &rhs) const; //concatenate
        bool operator==(const MyString &rhs) const;

        //overloading operators as global functions by declaring them as friends
        //here unary takes one param and binary take 2 (lhs, rhs)
        //this wont make sense to declare as member operator overload since lhs will be this:
        //we would get myString << cout ---> huh? should be cout << myString
        friend std::ostream &operator<<(std::ostream &os, const MyString &rhs);
        friend std::istream &operator>>(std::istream &os, MyString &rhs);

        void display() const;
        int getLength() const;
        const char * getStr() const;

};

#endif