#include <cstring>
#include <iostream>
#include "MyString.h"

//MAJOR TAKEAWAY: 
// A POOINTER EXPECTS AN ADDRESS
// A REFERENCE EXPECTS data 
// FUNCTIONS THAT RETURN A REFERENCE HSOULD RETURN DATA - see overloaded assignment operator

//also use option -fno-elide-constructors to see copy/move in action. this removes copy elision


//No args ctor
MyString::MyString() : 
    str(nullptr) {

    //allocate memory in the heap
    //string length 1 only for terminating null character
    str = new char[1];
    *str = '\0'; 
}

//overloaded operator
MyString::MyString(const char * s):
    str(nullptr) {
    
    //if we receive a null ptr then we make a empty MyString obj
    if(s == nullptr) {
        str = new char[1];
        *str = '\0'; 
    } 
    else 
    {
        //allocate memory on the heap of s length + 1
        str = new char[std::strlen(s) + 1];
        //copy s to str
        std::strcpy(str, s);

    }
}

//copy ctor
//we make a deep copy since this class has a pointer and we do not want
//multiple instances to point to the same data in the heap
//note copy constructor called either when we do:
//type name {name_to_copy}
//and also
//type name = type() <-- in this case a new type() is created and copied to name
MyString::MyString(const MyString &source) 
    :str(nullptr) {

    str = new char[std::strlen(source.str + 1)]; //can access str since we are in member function
    std::strcpy(str, source.str);
}

//move ctor
MyString::MyString(MyString &&source)
    :str(source.str) {//steal the data instead of making a copy
    //null out the the source's pointer
    source.str = nullptr;
}

MyString::~MyString() {
    delete [] str;
}

// operator = overloading (copy)
// where lhs = rhs = lhs.operator=(rhs)
MyString &MyString::operator=(const MyString &rhs) {
    if(this == &rhs)
        //reason why we return '*this' and not 'this' is because this is an address while '*this' is
        //a Mystring obj (after we dereference this). remember a pointer expects a 
        return *this;
    
    //deallocate current storage on heap
    delete [] str;

    //same as copy here
    str = new char[std::strlen(rhs.str + 1)];
    std::strcpy(str, rhs.str);

    //finaly return the new MyString obj
    return *this;

}

//operator = (move)
MyString &MyString::operator=(MyString &&rhs) {
    if(this == &rhs)
        return *this;
    
    //deallocate current storage on heap
    delete [] str;
    
    //steal pointer
    str = rhs.str;

    //null out the other pointer
    rhs.str = nullptr;

    return *this;

}

//unary operator -: make things lower case
//lower case
//note: return by val since here we are creating a whole new object (temp)
//if we return a ref, temp dies at the end of this block and we get garbage data
//before in move and copy operators (=) we return by ref since those objects already exist on the 
//stack in main scope
MyString MyString::operator-() const {

    //alocate an area in memory
    char *buff = new char[std::strlen(str) + 1];

    //str of this or lhs
    std::strcpy(buff, str);

    //make it to lower
    for (size_t i{0}; i < std::strlen(buff); i++ ) {
        buff[i] = std::tolower(buff[i]);
    }

    //create a MyString obj
    MyString temp{buff};

    //deallocate the memory
    delete [] buff;

    //return the MyString obj
    return temp; 
}

//binary operators

//equality
bool MyString::operator==(const MyString &rhs) const{
    return (std::strcmp(str, rhs.str) == 0);
}

//concatenate
MyString MyString::operator+(const MyString &rhs) const {
    char * buff = new char[std::strlen(str) + std::strlen(rhs.str) + 1];

    std::strcpy(buff, str);
    std::strcat(buff, rhs.str);

    MyString temp{buff};

    delete [] buff;

    return temp;
}

//overload insertion operator
//no scope resolution operator since it is a global function?
std::ostream &operator<<(std::ostream &os, const MyString &rhs) {
    os << rhs.str;
    return os;
}

//overloaded extraction operator
std::istream &operator>>(std::istream &is, MyString &rhs) {
    char * buff = new char[1000]; //bad way but not the point of this exercice
    is >> buff;
    rhs = MyString{buff}; //this will use move assignment and steal the pointer - very efficient

    delete [] buff;
    return is; 
}

void MyString::display() const {
    std::cout << str << " " << getLength() << std::endl;
}

int MyString::getLength() const {
    return std::strlen(str);
}

const char * MyString::getStr() const {
    return str;
}