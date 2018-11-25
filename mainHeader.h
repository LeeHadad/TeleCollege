#pragma once
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

struct{
	Status status;
	char firstname[20];
	char lastname[20];
	char id[10];
	bool courses[6];
	char phone[20];
	char email[30];
	Date birthday;
	Date insertion_date;
	History* history;
}typedef Customer;





