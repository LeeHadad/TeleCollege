#define _CRT_SECURE_NO_WARNINGS
#include<iostream>
#include<fstream>
#include<string>
#include <time.h>


// Get current date/time, format is YYYY-MM-DD.HH:mm:ss
const std::string currentDateTime() {
	time_t     now = time(0);
	struct tm  tstruct;
	char       buf[80];
	tstruct = *localtime(&now);
	// Visit http://en.cppreference.com/w/cpp/chrono/c/strftime
	// for more information about date/time format
	strftime(buf, sizeof(buf), "%Y-%m-%d.%X", &tstruct);

	return buf;
}

/*required string library
for lead and lead functions. */
enum { not_interested = 0, low, moderate, good, interested = 4 }typedef customer_potential;

struct Lead {
	int num = 0;
	int id = 0;
	customer_potential potential = not_interested;
	std::string name = "unknown";
	int phone_num = 0;
	std::string email = "no email.";

	std::string* documentation = nullptr;
	int size_of_docs = 0;
}typedef Lead;

void SetLeadName(Lead &lead, std::string valid_name) {
	lead.name = valid_name;
}

void SetLeadEmail(Lead &lead, std::string valid_email) {
	lead.email = valid_email;
}

void SetLeadNum(Lead &lead, int num) {
	lead.num = num;
}

void SetLeadId(Lead &lead, int valid_id) {
	lead.id = valid_id;
}

void SetLeadPhone(Lead &lead, int valid_phone) {
	lead.phone_num = valid_phone;
}

void SetLeadPotential(Lead &lead, customer_potential cp) {
	lead.potential = cp;
}

void AddLeadDoc(Lead &lead, std::string saler_name, std::string valid_doc) {
	valid_doc = "Saler name:" + saler_name + "\nTime:" + currentDateTime() + "\n" + valid_doc + "\n";
	if (lead.size_of_docs == 0) {
		lead.documentation = new std::string[1];
		lead.documentation[0] = valid_doc;
		lead.size_of_docs++;
	}
	else {
		std::string* templist = new std::string[lead.size_of_docs];

		for (int i = 0; i < lead.size_of_docs; i++) {
			templist[i] = lead.documentation[i];
		}

		delete[] lead.documentation;

		lead.documentation = new std::string[lead.size_of_docs + 1];

		for (int i = 0; i < lead.size_of_docs; i++) {
			lead.documentation[i] = templist[i];
		}

		lead.documentation[lead.size_of_docs] = valid_doc;
		lead.size_of_docs++;
		delete[] templist;
	}

}

/*required string library.
"name" must start with uppercase letter,with no symbols
or numbers and less than 20 letters.*/
bool CheckValidName(std::string name) {

	if (name.length() > 20) return false;

	if (name.at(0) < 'A' || name.at(0) > 'Z') {
		return false;
	}

	for (int i = 0; i < name.length(); i++) {
		if ((name.at(i) < 'A' || name.at(i) > 'Z') && (name.at(i) < 'a' || name.at(i) > 'z') && (name.at(i) != ' ')) {
			return false;
		}
	}

	return true;
}

/*
LeadList suppose to replace linked list and work only with leads struct.
*/
struct  Node
{
	Node* next = nullptr;
	Node* Previous = nullptr;
	Lead* lead = nullptr;
};

struct Leadlist
{
	Node* head = nullptr;
	Node* tail = nullptr;
	int size = 0;
}typedef Leadlist;


void AddToList(Leadlist &list, Lead &lead) {
	if (list.head == nullptr) {
		list.head = new Node;
		list.head->lead = &lead;
	}
	else if (list.tail == nullptr) {
		list.tail = new Node;
		list.tail->lead = &lead;
		list.head->next = list.tail;
		list.tail->Previous = list.head;
	}
	else {
		Node* node = new Node;
		node->Previous = list.tail;
		node->lead = &lead;
		list.tail->next = node;
		list.tail = node;
	}
	list.size++;
}

void RemoveNode(Leadlist &list, Node *node) {
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

/*
Extract node from the list in the the chosen index.
*/
Node* ExtractFromList(Leadlist &list, int index) {
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

void SortListByLetters(Leadlist &list) {
	if (list.size > 3) {
		Node* node3;//pre node.
		Node* node2;//next node.
		Node* node1 = list.head;//currenct node.
		bool flag = true;

		while (flag)
		{
			flag = false;
			node1 = list.head;
			for (int i = 0; i < list.size; i++) {
				if (node1->next != nullptr) {
					if (node1->lead->name.at(0) > node1->next->lead->name.at(0)) {
						if (node1 == list.head) {
							node3 = node1->next->next;
							node2 = node1->next;
							node2->Previous = nullptr;
							node2->next = node1;
							node1->Previous = node2;
							node1->next = node3;
							node3->Previous = node1;
							list.head = node2;

						}
						else
						{
							if (node1->next == list.tail) {
								node2 = node1->next;
								node2->Previous = node1->Previous;
								node2->next = node1;
								node1->Previous = node2;
								node1->next = nullptr;

							}
							else
							{
								node3 = node1->next->next;
								node2 = node1->next;
								node2->Previous = node1->Previous;
								node2->next = node1;
								node2->Previous->next = node2;
								node1->Previous = node2;
								node1->next = node3;
								node3->Previous = node1;
							}

						}
						flag = true;
					}
					else
					{
						node1 = node1->next;
					}
				}
			}
			node1 = list.head;
		}
	}
}

void SortListByPotential(Leadlist &list) {
	if (list.size > 3) {
		Node* node3;//pre node.
		Node* node2;//next node.
		Node* node1 = list.head;//currenct node.
		bool flag = true;

		while (flag)
		{
			flag = false;
			node1 = list.head;
			for (int i = 0; i < list.size; i++) {
				if (node1->next != nullptr) {
					if (node1->lead->potential > node1->next->lead->potential) {
						if (node1 == list.head) {
							node3 = node1->next->next;
							node2 = node1->next;
							node2->Previous = nullptr;
							node2->next = node1;
							node1->Previous = node2;
							node1->next = node3;
							node3->Previous = node1;
							list.head = node2;

						}
						else
						{
							if (node1->next == list.tail) {
								node2 = node1->next;
								node2->Previous = node1->Previous;
								node2->next = node1;
								node1->Previous = node2;
								node1->next = nullptr;

							}
							else
							{
								node3 = node1->next->next;
								node2 = node1->next;
								node2->Previous = node1->Previous;
								node2->next = node1;
								node2->Previous->next = node2;
								node1->Previous = node2;
								node1->next = node3;
								node3->Previous = node1;
							}

						}
						flag = true;
					}
					else
					{
						node1 = node1->next;
					}
				}
			}
			node1 = list.head;
		}
	}
}


void SaveFile(std::string file_name, Leadlist& list) {
	using namespace std;
	string lead_info = "";
	ofstream file;
	file.open(file_name+".txt");
	for (int i = 0; i < list.size; i++) {
		Lead* lead = ExtractFromList(list, i)->lead;
		lead_info = lead_info + "\nstart_lead:" + "\n";
		lead_info = lead_info + to_string(lead->num) + "\n";
		lead_info = lead_info + lead->name + "\n";
		lead_info = lead_info + to_string(lead->id) +"\n";
		lead_info = lead_info + to_string(lead->phone_num) + "\n";
		lead_info = lead_info + lead->email;
		lead_info = lead_info + to_string(lead->potential);
		lead_info = lead_info + "\n\nstart_docs:\n\n";
		for (int j = 0; j < lead->size_of_docs; j++) {
			lead_info = lead_info + lead->documentation[j] + "\n\n";
		}
		lead_info = lead_info + "\nend_docs.";
		lead_info = lead_info + "\nend_lead.\n";
		file << lead_info;
		lead_info = "";
	}
	file.close();
}

void LoadFile(Leadlist& list, std::string file_name) {
	using namespace std;
	string txt = "";
	string line = "";
	ifstream file(file_name + ".txt");
	if (file.is_open()){
		while (getline(file, line)){
			txt = txt + line + "\n";
		}
		file.close();
	}
	else
	{
		cout << "unable to open file.";
	}

	for (int i = 0; i < txt.length ; i++){
		//need to load leads from "string txt;"
	}

	//cout << txt;
}


void main() {
	Leadlist list;
	Leadlist list2;
	Lead lead1;
	SetLeadNum(lead1, 1);
	SetLeadName(lead1, "Bar");
	SetLeadEmail(lead1, "bar@gmail.com");
	SetLeadId(lead1, 203564463);
	SetLeadPhone(lead1, 112353523);
	SetLeadPotential(lead1, low);
	AddLeadDoc(lead1,"Sar" ,"work work bla bla bla moshi moshi moshi yah1.");
	AddLeadDoc(lead1,"Bar", "work work bla bla bla moshi moshi moshi yah2.");

	Lead lead2;
	SetLeadNum(lead2, 2);
	SetLeadName(lead2, "Sar");
	SetLeadEmail(lead2, "sar@gmail.com");
	SetLeadId(lead2, 3451235346);
	SetLeadPhone(lead2, 12323523);
	SetLeadPotential(lead2, moderate);
	AddLeadDoc(lead2, "Bar", "work work bla bla bla moshi moshi moshi yah.");

	Lead lead3;
	SetLeadNum(lead3, 3);
	SetLeadName(lead3, "Xar");
	SetLeadEmail(lead3, "xar@gmail.com");
	SetLeadId(lead3, 2353461);
	SetLeadPhone(lead3, 456345253);
	SetLeadPotential(lead3, low);
	AddLeadDoc(lead3, "Bar", "work work bla bla bla moshi moshi moshi yah1.");
	AddLeadDoc(lead3, "Xar", "work work bla bla bla moshi moshi moshi yah2.");
	AddLeadDoc(lead3, "Xar", "work work bla bla bla moshi moshi moshi yah3.");


	Lead lead4;
	SetLeadNum(lead4, 4);
	SetLeadName(lead4, "Car");
	SetLeadEmail(lead4, "car@gmail.com");
	SetLeadId(lead4, 567346252);
	SetLeadPhone(lead4, 0345121233);
	SetLeadPotential(lead4, good);
	AddLeadDoc(lead4, "Car", "work work bla bla bla moshi moshi moshi yah.");

	Lead lead5;
	SetLeadNum(lead5, 5);
	SetLeadName(lead5, "Aar");
	SetLeadEmail(lead5, "aar@gmail.com");
	SetLeadId(lead5, 789567345);
	SetLeadPhone(lead5, 2452412314);
	SetLeadPotential(lead5, low);
	AddLeadDoc(lead5, "Aar", "work work bla bla bla moshi moshi moshi yah.");


	AddToList(list, lead1);
	AddToList(list, lead2);
	AddToList(list, lead3);
	AddToList(list, lead4);
	AddToList(list, lead5);
	
	/*for (int i = 0; i < list.size; i++)
	{
		std::cout << ExtractFromList(list, i)->lead->name << std::endl;
	}*/

	LoadFile(list2, "Leads");
	//SaveFile("Leads", list);

	getchar();
}