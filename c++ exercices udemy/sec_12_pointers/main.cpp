#include <iostream>
#include <vector>
#include <string>

using namespace std;

//write a function that prints an array
void print(const int * const array, size_t length) {

    for(size_t i = 0; i < length; i++)
        //careful (*array)++ is different - this simply icrementes the value at addr array
        cout << *(array + i) << endl;
}

int * apply_all(const int * const arr1, size_t len1, const int * const arr2, size_t len2) {
    int *result_ptr = nullptr;
    
    result_ptr = new int[len1 * len2];

    int index = 0;

    for (size_t i = 0; i < len1; i++) {
        for (size_t j = 0; j < len2; j++) {
            result_ptr[index] = arr1[i] * arr2[j];
            index ++;
        }
    }
            

    return result_ptr;
}

int main() {

    int array1[] = {1,2,3,4,5};
    int array2[] = {10,20,30};

    cout << "Array 1:" << endl;
    print(array1, 5);

    cout << "Array 2:" << endl;
    print(array2, 3);

    int *result = apply_all(array1, 5, array2, 3);
    cout << "Result:" << endl;
    print(result, 15);

    delete [] result;


    return 0;
}