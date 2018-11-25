#include"mainHeader.h"
#include<iostream>

struct  Node
{
	Node* next = nullptr;
	Node* Previous = nullptr;
	Customer* customer = nullptr;
};

struct Customerlist
{
	Node* head = nullptr;
	Node* tail = nullptr;
	int size = 0;
}typedef List;

void AddToList(List &list, Customer &customer) {
	if (list.head == nullptr) {
		list.head = new Node;
		list.head->customer = &customer;
	}
	else if (list.tail == nullptr) {
		list.tail = new Node;
		list.tail->customer = &customer;
		list.head->next = list.tail;
		list.tail->Previous = list.head;
	}
	else {
		Node* node = new Node;
		node->Previous = list.tail;
		node->customer = &customer;
		list.tail->next = node;
		list.tail = node;
	}
	list.size++;
}

void RemoveNode(List &list, Node *node) {
	if (list.head == node) {
		list.head = node->next;
	}
	else if (list.tail == node) {
		list.tail->Previous->next = nullptr;
		list.tail = node->Previous;

	}
	else {
		node->next->Previous = node->Previous;
		node->Previous->next = node->next;
	}
	delete node;
	list.size--;
}

Node* ExtractFromList(List &list, int index) {
	Node* node;
	if (list.head != nullptr) {
		node = list.head;
		for (int i = 0; i < index; i++) {
			if (node->next != nullptr) {
				node = node->next;
			}
			else
			{
				break;
			}
		}
		return node;
	}
	return 0;
}


void main() {
	Customer cust1 = {new_lead,"Ariel","Gueta","234654654"};
	Customer cust2 = { new_lead,"Briel","Zueta","654231321" };
	Customer cust3 = { new_lead,"Criel","Bueta","3465432" };
	Customer cust4 = { new_lead,"Zriel","Dueta","316546" };
	Customer cust5 = { new_lead,"Ariel","Fueta","23165468" };

	List list;
	AddToList(list, cust1);
	AddToList(list, cust2);
	AddToList(list, cust3);
	AddToList(list, cust4);
	AddToList(list, cust5);
	
	std::cout << "[List names]:" << std::endl;
	for (int i = 0; i < list.size; i++){
		std::cout << ExtractFromList(list, i)->customer->firstname << std::endl;
	}
	getchar();
}
