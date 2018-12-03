#include "mainHeader.h"
#include<fstream>
#include<string>

//prototypes:
std::string DateToStr(Date);
bool* validateANDupdate(Customer , int );
bool AddToEOF(Customer);
bool CheckValidName(char*);
bool CheckValidID(char*);
bool CheckValidPhoneNum(char*);
bool CheckValidEmail(char*);
bool* validateANDupdate(Customer toCheck, int action);


std::string DateToStr(Date date) {
	//date -> xx/xx/xxxx'\0'
	std::string str;
	str += std::to_string(date.day) + "/" + std::to_string(date.month) + "/" + std::to_string(date.year);
	return str;
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
