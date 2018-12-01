
#include "Header.h"


a* __stdcall testRet(int* length)
{

	a* arr = new a[5];
	customers = arr;
	*length = 5;
	for (int i = 0; i < 5; i++)
	{
		arr[i].i = i;
		strcpy(arr[i].b, "A");
		std::cout << "arr[" << i << "] = " << arr[i].b << std::endl;
	}
	return arr;
}

int __stdcall rem(a arr[])
{
	for (int i = 0; i < 5; i++)
	{
		std::cout << "arr[" << i << "] = " << customers[i].b << std::endl;
	}
	std::cout << "almost"<<std::endl;
	delete[] arr;
	std::cout << "all fine"<<std::endl;

	return 25;
}
