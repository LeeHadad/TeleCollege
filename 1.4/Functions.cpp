#include "mainHeader.h"

List global_list;

std::string DateToStr(Date date) {
	//date -> xx/xx/xxxx'\0'
	std::string str;
	str += std::to_string(date.day) + "/" + std::to_string(date.month) + "/" + std::to_string(date.year);
	return str;
}

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

bool AddToEOF(Customer cust) {
	///Add new customer to the end of file.

	using namespace std;
	string file_name = "Customer Data";
	string txt = "\n***\n";
	string line = "";
	ofstream file_out(file_name + ".txt", ios::app);
	if (!file_out) return false;

	txt += cust.firstname;
	txt += "\n";
	txt += cust.lastname;
	txt += "\n";
	txt += cust.id;
	txt += "\n";
	txt += cust.phone;
	txt += "\n";
	txt += cust.email;
	txt += "\n";
	txt += DateToStr(cust.birthday);
	txt += "\n";
	txt += DateToStr(cust.insertion_date);
	txt += "\n---\n";


	file_out << txt;

	file_out.close();

	return true;
}

bool CheckValidName(char* first_name) {
	std::string name = first_name;

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

bool CheckValidID(char* ID) {
	std::string id = ID;
	if (id.length() != 9) return false;
	for (int i = 0; i < id.length(); i++) {
		if (id.at(i) < '0' || id.at(i) > '9') {
			return false;
		}
	}
	return true;
}


bool CheckValidPhoneNum(char* num) {
	std::string phone = num;
	for (int i = 0; i < phone.length(); i++) {
		if (phone.at(i) < '0' || phone.at(i) > '1') {
			return false;
		}
	}
	return true;
}

bool CheckValidEmail(char* Email) {
	std::string email = Email;
	int stage = 0;
	for (int i = 0; i < email.length(); i++) {
		if (email.at(i) == '@' || stage == 0) {
			if (email.at(0) == email.at(i)) return false;
			stage++;
		}

		if (email.at(i) == '.' || stage == 1) {
			if (email.at(i - 1) == '@') return false;
			stage++;
		}
	}
	return true;
}


bool* validateANDupdate(Customer toCheck, int action) {
	const int size = 5;
	bool* check_list = new bool[size];
	bool flag = true;
	//[0]First name, [1]Last name, [2]id, [3]phone, [4]email.

	check_list[0] = CheckValidName(toCheck.firstname);
	check_list[1] = CheckValidName(toCheck.lastname);
	check_list[2] = CheckValidID(toCheck.id);
	check_list[3] = CheckValidID(toCheck.id);
	check_list[4] = CheckValidEmail(toCheck.email);

	for (int i = 0; i < size; i++) {
		if (check_list[i] == false) {
			flag = false;
			break;
		}
	}

	if (flag == true) {
		std::cout << "[Save in file:" << (AddToEOF(toCheck) == true ? "true" : "false") << "]";
		std::cout << "\nworked and all true!\n";
	}
	else {
		std::cout << "\nsomthing is not right..\n";
	}



	return false;
}

Customer* listToArray(List list,int* size) {
	List local_list = list;
	Customer* cust_arr = new Customer[local_list.size];
	*size = 0;
	for (int i = 0; i < local_list.size; i++) {
		cust_arr[i] = *ExtractFromList(local_list, i)->customer;
		*size += 1;
	}

	return cust_arr;
}

int freeArray(Customer* arr) {
	delete arr;
	arr = NULL;
	return 1;
}

Customer* filterCustomers(char filterBy, char info[20], int* length, int type) {
	List filtered_list;

	/*
	filterby: 'S' = status, 'C' = course.
	info[]: status / course to fliter by.
	*/
	type = 1;
	if (filterBy == 'S') {
		List &temp_list = global_list;
		Status filter_status;
		std::string filter_str = info;
		if (filter_str == "new_lead") {
			filter_status = new_lead;
			type = 0;
		}
		if (filter_str == "call_later") filter_status = call_later;
		if (filter_str == "send_email") filter_status = send_email;
		if (filter_str == "success") filter_status = success;
		if (filter_str == "irrelevent") filter_status = irrelevent;
		

		for (int i = 0; i < global_list.size; i++) {
			Customer *customer = ExtractFromList(temp_list, i)->customer;
			if (customer->status == filter_status) {
				AddToList(filtered_list, *customer);
			}
		}

		return listToArray(filtered_list,length);
	}
	else if (filterBy == 'C') {

		for (int i = 0; i < global_list.size; i++) {
			//work in progress.
		}
	}
	return NULL;
}



void main() {

	Customer cust1 = { new_lead,"Ariel","Gueta","234654654" };
	Customer cust2 = { new_lead,"Briel","Zueta","654231321" };
	Customer cust3 = { call_later,"Sriel","Aueta","564987987" };
	Customer cust4 = { new_lead,"Zriel","Dueta","316546" };
	Customer cust5 = { new_lead,"Griel","Fueta","23165468" };
	Customer cust6 = { call_later,"Rriel","Zueta","654623132" };
	Customer cust7 = { new_lead,"Triel","Cueta","6549872" };
	Customer cust8 = { call_later,"Yriel","Vueta","468796231" };


	List &list = global_list;
	AddToList(list, cust1);
	AddToList(list, cust2);
	AddToList(list, cust3);
	AddToList(list, cust4);
	AddToList(list, cust5);
	AddToList(list, cust6);
	AddToList(list, cust7);
	AddToList(list, cust8);


	std::cout << "[List before filter]:" << std::endl;
	for (int i = 0; i < list.size; i++) {
		std::cout << ExtractFromList(list, i)->customer->firstname << ", status num:" << std::to_string(ExtractFromList(list, i)->customer->status) << "\n";
	}


	int test_size;
	char filter_type[] = "call_later";
	Customer* test_list = filterCustomers('S', filter_type, &test_size, 0);
	std::cout << "\n[after filter[call_later = 2]]:" << std::endl;
	
	for (int i = 0; i < test_size; i++) {
		std::cout << test_list[i].firstname << ", status num:" << std::to_string(test_list[i].status) << "\n";
	}


	/*	std::cout << "[List names]:" << std::endl;
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
	*/

		getchar();
}