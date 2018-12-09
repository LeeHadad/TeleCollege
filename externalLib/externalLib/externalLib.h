#pragma once
#define _CRT_SECURE_NO_WARNINGS
#define WIN32_LEAN_AND_MEAN
#include <Windows.h>
#include <iostream>
#include <fstream>
#include <string>

using std::string;

typedef struct
{
	int day;
	int month;
	int year;

}Date;

typedef struct
{
	Date date;
	char representativeName[42];
	char representativeId[10];
	char Note[184];
}History;

typedef struct Customer
{
	char firstname[21];
	char lastname[21];
	char id[10];
	Date birthday;
	char phone[12];
	char email[31];
	int status;
	Date inserted;

	bool courses[6] = { false };
	History history[30];
	int history_amount = 0;
	Customer* next = NULL;

}Customer;

typedef struct Node
{
	Customer* customer = nullptr;
	Node* previous = nullptr;
	Node* next = nullptr;
}Node;

typedef struct Customerlist
{
	Node* head = nullptr;
	Node* tail = nullptr;
	int size = 0;
}Customerlist;

Customerlist globalList;

Customer* fileToList();
void assignHistory(Customer* head);
Customer* findNodeById(string id, Customer* Node);

void printList(Customer* node);
void freeMem(Customer* Node);

Node* ExtractFromList(int);
void RemoveNode(Node *);
void AddToList(Customer*);

bool* validateANDupdate(Customer, int);
bool AddToEOF(Customer);
bool CheckValidName(char*);
bool CheckValidID(char*);
bool CheckValidPhoneNum(char*);
bool CheckValidEmail(char*);

std::string DateToStr(Date);
void freeArray(Customer* arr);
Customer* listToArray(int* size);


