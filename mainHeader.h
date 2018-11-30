#pragma once
#include<iostream>

struct
{
	int day;
	int month;
	int year;
}typedef Date;

enum e_status_num
{
	new_lead = 1,
	call_later = 2,
	send_email = 3,
	success = 4,
	irrelevent = 5
}typedef Status;

struct
{
	Date date;
	char id[10];//client id
	char firstname[20];
	char lastname[20];
	char salesmanID[10];
	char data[50];//content
}typedef History;



struct {
	Status status;
	char firstname[20];
	char lastname[20];
	char id[10];
	bool courses[6];
	char phone[20];
	char email[30];
	Date birthday;
	Date insertion_date;
	History history[20];
}typedef Customer;



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

std::string DateToStr(Date date) {
	//date -> xx/xx/xxxx'\0'
	std::string str;
	str += std::to_string(date.day) + "/" + std::to_string(date.month) + "/" + std::to_string(date.year);
	return str;
}

List global_list;

