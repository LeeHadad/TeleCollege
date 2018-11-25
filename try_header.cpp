#include "mainHeader.h"
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string.h>
#include <time.h>
using namespace std;
int main() {
	Customer c1;
	c1.status = new_lead;
	strcpy(c1.email,"mymaor89@gmail.com");
	strcpy(c1.lastname, "Yatskan");
	strcpy(c1.firstname, "Maor");
	strcpy(c1.id, "301791380");
	for (bool b : c1.courses) {
		b = false;
	}
	c1.birthday = { 2,10,1989 };
	c1.insertion_date = { 2,12,2018 };
	strcpy(c1.phone, "0558845014");

	History h;
	h.date = { 2,2,2020 };
	strcpy(h.firstname, c1.firstname);
	strcpy(h.lastname, c1.lastname);
	strcpy(h.id, c1.id);
	strcpy(h.salesmanID, "12345678");
	strcpy(h.data, "bla bla bla\n bla bla bla");

	cout << "first name: " << c1.firstname << '\n'
		<< "last name: " << c1.lastname << '\n'
		<< "ID: " << c1.id << '\n'
		<< "status: " << c1.status << '\n'
		<< "TEL: " << c1.phone << '\n'
		<< "E-mail: " << c1.email << '\n'
		<< "Insertion date: " << c1.insertion_date.day << '/'
		 << c1.insertion_date.month << '/'
		 << c1.insertion_date.year << endl;
	c1.history = &h;
	time_t rawtime;
	struct tm * timeinfo;
	time(&rawtime);
	timeinfo = localtime(&rawtime);
	char date_string[80];
	strftime(date_string, sizeof(date_string) - 1, "%d/%m/%Y", timeinfo);
	cout << "History:\n"
		<< "date added: " << date_string << '\n'
		<< "Salesman ID: " << h.salesmanID << '\n'
		<< "Details: " << c1.history[0].data << endl;


	system("pause");
}