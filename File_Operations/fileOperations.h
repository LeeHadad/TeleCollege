#pragma once
#define _CRT_SECURE_NO_WARNINGS
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

typedef struct Client
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
	Client* next = NULL;

}Client;

Client* fileToList();
void assignHistory(Client* head);
Client* findNodeById(string id, Client* Node);

void printList(Client* node);
void freeMem(Client* Node);



