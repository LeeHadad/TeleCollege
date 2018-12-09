
#include "Header.h"


a* __stdcall testRet(int* length)
{
	
	a* arr = new a[5];
	*length = 5;
	for (int i = 0; i < 5; i++)
	{
		arr[i].i = i;
		strcpy(arr[i].b, "A");
		std::cout << "arr[" << i << "] = " << arr[i].b << std::endl;
		//arr[i].hst.i = i;
	}
	arr[0].hst[0].i = 12;
	arr[0].hst[1].i = 13;
	//arr[0].hst[0] = 12;
	//arr[0].hst[1] = 13;
	return arr;
}

int __stdcall rem(a arr[])
{
	std::cout << "almost"<<std::endl;
	delete[] arr;
	std::cout << "all fine"<<std::endl;

	return 25;
}

int __stdcall remHst(History arr[])
{
	std::cout << "almost" << std::endl;
	delete[] arr;
	std::cout << "all fine" << std::endl;

	return 22;
}

