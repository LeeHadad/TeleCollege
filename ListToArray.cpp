#include "mainHeader.h"
#include<string>

Customer* listToArray(int* size) {
	List local_list = global_list;
	Customer* cust_arr = new Customer[local_list.size];
	*size = 0;
	for (int i = 0; i < global_list.size; i++) {
		cust_arr[i] = *ExtractFromList(local_list, i)->customer;
		*size += 1;
	}

	return cust_arr;
}