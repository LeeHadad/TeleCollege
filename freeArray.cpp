#include "mainHeader.h"
int freeArray(Customer* arr) {
	delete arr;
	arr = NULL;
	return 1;
}