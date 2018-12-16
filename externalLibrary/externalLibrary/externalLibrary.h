#pragma once
#ifdef ExternalLib_EXPORTS
#define ExternalLib_API __declspec(dllimport)
#else
#define ExternalLib_API __declspec(dllexport)
#endif

#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <fstream>
#include <string>

using std::string;

enum actions
{
	no_change=-1,
	edited=0,
	deleted=1,
	added=2
};
typedef struct
{
	int day=-1;
	int month=-1;
	int year=-1;

}Date;
typedef struct
{
	int hour=-1;
	int minutes=-1;
}Time;

typedef struct
{
	
	char representativeName[42];
	char representativeId[10];
	char Note[182];

	Date date;
}History;

typedef struct
{
	char firstname[21];
	char lastname[21];
	char id[10];
	Date birthday;
	char phone[12];
	char email[31];
	int status;
	Date inserted;

	int history_amount = 0;
	
	History history[30];
	
	bool courses[6] = { false };
	Date callLaterDate;
	Time callLaterTime;

}Customer;

typedef struct Node
{
	Customer* customer = NULL;
	Node* previous = NULL;
	Node* next = NULL;
}Node;

typedef struct Customerlist
{
	Node* head = NULL;
	Node* tail = NULL;
	int size = 0;
}Customerlist;

Customerlist* globalList;

extern "C" ExternalLib_API Customer* __stdcall exportCustomers(int* length);
extern "C" ExternalLib_API void _stdcall freeGlobalList();

void fileToList();
void assignHistory(Customerlist &);
void assignCallLater(Customerlist &list);
Node* findNodeById(Customerlist &, string);

bool addToCustomerFile(Customer);
bool addToHistoryFile(Customer, bool);
bool addToCallLaterFile(Customer, bool);

bool editOrRemoveCustomer(char[], Customer, int, int, int, int);
bool editOrRemoveHistory(char[], Customer, int, int);
bool editOrRemoveCallLater(char[], Customer, int);

extern "C" ExternalLib_API bool __stdcall updateDatabase(char id[], Customer cust, int action, int editCallLater=no_change, int editHistory= no_change, int index = -1);

void printList(Customerlist&);
void freeMem(Customerlist &);

Node* extractFromList(Customerlist &, int);
void removeNode(Customerlist &, Node *);
extern "C" ExternalLib_API void __stdcall addToList(Customerlist &, Customer*);

extern "C" ExternalLib_API void __stdcall validateAndUpdate(int*, Customer cust,char[], int action);
extern "C" ExternalLib_API bool __stdcall tryLogin(char id[]);

int checkValidName(char*);
extern "C" ExternalLib_API int __stdcall checkValidID(char*);
int checkValidPhoneNum(char*);
int checkValidEmail(char*);

string dateToStr(Date);
extern "C" ExternalLib_API void __stdcall freeArray(Customer*);
Customer* listToArray(Customerlist &, int*);

