#include"mainHeader.h"

List global_list;

void main() {
	
	Customer cust1 = { new_lead,"Ariel","Gueta","234654654" };
	Customer cust2 = { new_lead,"Briel","Zueta","654231321" };
	Customer cust3 = { new_lead,"Sriel","Aueta","564987987" };
	Customer cust4 = { new_lead,"Zriel","Dueta","316546" };
	Customer cust5 = { new_lead,"Griel","Fueta","23165468" };
	Customer cust6 = { new_lead,"Rriel","Zueta","654623132" };
	Customer cust7 = { new_lead,"Triel","Cueta","6549872" };
	Customer cust8 = { new_lead,"Yriel","Vueta","468796231" };


	List list;
	AddToList(list, cust1);
	AddToList(list, cust2);
	AddToList(list, cust3);
	AddToList(list, cust4);
	AddToList(list, cust5);
	AddToList(list, cust6);
	AddToList(list, cust7);
	AddToList(list, cust8);


	std::cout << "[List names]:" << std::endl;
	for (int i = 0; i < list.size; i++) {
		std::cout << ExtractFromList(list, i)->customer->firstname << std::endl;
	}
	std::cout << std::endl << "[List names after remove some nodes]:" << std::endl;

	RemoveNode(list, ExtractFromList(list, 4));
	RemoveNode(list, ExtractFromList(list, 4));
	RemoveNode(list, ExtractFromList(list, 4));

	for (int i = 0; i < list.size; i++) {
		std::cout << ExtractFromList(list, i)->customer->firstname << std::endl;
	}


	getchar();
}