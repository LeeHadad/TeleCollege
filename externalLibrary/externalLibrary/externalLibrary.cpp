#include "externalLibrary.h"
/*int main()
{
	fileToList();
	//printList(globalList);
	int size;
	Customer* arr = listToArray(globalList, &size);


	Customerlist dem;
	dem.head = new Node();
	for (int i = 0; i < size; i++)
	{
		dem.head->customer = &(arr[i]);
		printList(dem);
	}

	freeArray(arr);
	freeMem(globalList);
	getchar();
}*/

Customer* __stdcall exportCustomers(int* length)
{
	globalList = new Customerlist();
	fileToList();
	//printList(*globalList);
	return listToArray(*globalList, length);
}
void _stdcall freeGlobalList()
{
	freeMem(*globalList);
	globalList = NULL;
	std::cout << "list pointer status: " + std::to_string((int)globalList) << std::endl;
	delete globalList;
}

void fileToList()
{
	std::ifstream CustomersFile("Customers.txt");
	if (!CustomersFile.is_open())
	{
		std::cout << "Error reading Customers.txt!" << std::endl;
		return;
	}
	string currLine = "";
	string brokenInfo;
	Customer* temp = NULL;
	while (CustomersFile.peek() != EOF)
	{
		temp = new Customer();

		std::getline(CustomersFile, currLine);
		std::getline(CustomersFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Name:") + 5);
		strcpy(temp->firstname, brokenInfo.substr(0, brokenInfo.find(' ')).c_str());
		strcpy(temp->lastname, brokenInfo.substr(brokenInfo.find(' ') + 1).c_str());

		std::getline(CustomersFile, currLine);
		strcpy(temp->id, currLine.substr(currLine.find("Id:") + 3).c_str());

		std::getline(CustomersFile, currLine);
		strcpy(temp->email, currLine.substr(currLine.find("Email:") + 6).c_str());

		std::getline(CustomersFile, currLine);
		strcpy(temp->phone, currLine.substr(currLine.find("Phone:") + 6).c_str());

		std::getline(CustomersFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Birthdate:") + 10);
		if (brokenInfo != "")
		{
			size_t firstSlash = brokenInfo.find("/");
			size_t secondSlash = brokenInfo.find("/", firstSlash + 1);
			temp->birthday.day = atoi(brokenInfo.substr(0, firstSlash).c_str());
			temp->birthday.month = atoi(brokenInfo.substr(firstSlash + 1, secondSlash - firstSlash + 1).c_str());
			temp->birthday.year = atoi(brokenInfo.substr(secondSlash + 1).c_str());
		}

		std::getline(CustomersFile, currLine);
		temp->status = atoi(currLine.substr(currLine.find("Status:") + 7).c_str());

		std::getline(CustomersFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Insertion date:") + 15);
		if (brokenInfo != "")
		{
			size_t firstSlash = brokenInfo.find("/");
			size_t secondSlash = brokenInfo.find("/", firstSlash + 1);
			temp->inserted.day = atoi(brokenInfo.substr(0, firstSlash).c_str());
			temp->inserted.month = atoi(brokenInfo.substr(firstSlash + 1, secondSlash - firstSlash + 1).c_str());
			temp->inserted.year = atoi(brokenInfo.substr(secondSlash + 1).c_str());
		}
		std::getline(CustomersFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Courses:") + 8);
		if (brokenInfo != "")
		{

			char str[12];
			strcpy(str, brokenInfo.c_str());
			char* course = strtok(str, ",");
			while (course != NULL)
			{
				temp->courses[atoi(course) - 1] = true;
				course = strtok(NULL, ",");
			}
		}
		addToList(*globalList, temp);
	}
	assignHistory(*globalList);
	assignCallLater(*globalList);
	CustomersFile.close();
}
void assignHistory(Customerlist &list)
{
	std::ifstream historyFile("History.txt");
	if (!historyFile.is_open())
	{
		std::cout << "Error reading History.txt!" << std::endl;
		return;
	}
	string currLine = "";
	string id;
	Node* nodeToInsert = NULL;
	string brokenInfo;
	while (historyFile.peek() != EOF)
	{
		std::getline(historyFile, currLine);
		if (currLine == "****")
		{
			std::getline(historyFile, currLine);
			id = currLine.substr(currLine.find("Id:") + 3);
			nodeToInsert = findNodeById(list, id);
			if (nodeToInsert == NULL)//in case Customer does not exist
				continue;
			//else if (nodeToInsert->customer->history_amount == 30)
				//continue;
			std::getline(historyFile, currLine);
			strcpy(nodeToInsert->customer->history[nodeToInsert->customer->history_amount].representativeName, (currLine.substr(currLine.find("Rep. name:") + 10)).c_str());
			std::getline(historyFile, currLine);
			strcpy(nodeToInsert->customer->history[nodeToInsert->customer->history_amount].representativeId, (currLine.substr(currLine.find("Rep. id:") + 8)).c_str());
			std::getline(historyFile, currLine);
			brokenInfo = currLine.substr(currLine.find("Date:") + 5);
			if (brokenInfo != "")
			{
				size_t firstSlash = brokenInfo.find("/");
				size_t secondSlash = brokenInfo.find("/", firstSlash + 1);
				nodeToInsert->customer->history[nodeToInsert->customer->history_amount].date.day = atoi(brokenInfo.substr(0, firstSlash).c_str());
				nodeToInsert->customer->history[nodeToInsert->customer->history_amount].date.month = atoi(brokenInfo.substr(firstSlash + 1, secondSlash - firstSlash + 1).c_str());
				nodeToInsert->customer->history[nodeToInsert->customer->history_amount].date.year = atoi(brokenInfo.substr(secondSlash + 1).c_str());
			}
			nodeToInsert->customer->history_amount++;
			std::getline(historyFile, currLine);//get rid of "Note:"
			continue;
		}
		if (nodeToInsert == NULL)//in case Customer does not exist
			continue;
		//else if (nodeToInsert->customer->history_amount == 30)
			//continue;

		if (currLine != "-&-")
			strcat(nodeToInsert->customer->history[nodeToInsert->customer->history_amount - 1].Note, (currLine + '\n').c_str());
		//else
			//nodeToInsert->customer->history_amount++;

	}
	historyFile.close();
}

bool __stdcall tryLogin(char id[])
{
	std::ifstream usersFile("Users.txt");
	if (!usersFile.is_open())
	{
		std::cout << "Error reading Users.txt!" << std::endl;
		return false;
	}
	std::cout << id << std::endl;
	string idCheck = "";
	string curr = "";
	while (usersFile.peek() != EOF)
	{
		std::getline(usersFile, curr);//****
		std::getline(usersFile, idCheck);//Id:___
		std::getline(usersFile, curr);//Name:___
		if (idCheck.substr(idCheck.find("Id:") + 3) == id)
		{
			usersFile.close();
			return true;
		}
	}
	usersFile.close();
	return false;
}
void assignCallLater(Customerlist &list)
{
	std::ifstream callLaterFile("CallLater.txt");
	if (!callLaterFile.is_open())
	{
		std::cout << "Error reading CallLater.txt!" << std::endl;
		return;
	}
	string currLine = "";
	string id;
	Node* nodeToInsert = NULL;
	string brokenInfo;
	while (callLaterFile.peek() != EOF)
	{
		std::getline(callLaterFile, currLine);
		if (currLine == "****")
		{
			std::getline(callLaterFile, currLine);
			id = currLine.substr(currLine.find("Id:") + 3);
			nodeToInsert = findNodeById(list, id);
			if (nodeToInsert == NULL)//in case Customer does not exist
				continue;
			std::getline(callLaterFile, currLine);
			brokenInfo = currLine.substr(currLine.find("At:") + 3);
			size_t firstSlash = brokenInfo.find("/");
			size_t secondSlash = brokenInfo.find("/", firstSlash + 1);
			size_t space = brokenInfo.find(" ");
			size_t colon = brokenInfo.find(":");
			nodeToInsert->customer->callLaterDate.day = atoi(brokenInfo.substr(0, firstSlash).c_str());
			nodeToInsert->customer->callLaterDate.month = atoi(brokenInfo.substr(firstSlash + 1, secondSlash - firstSlash + 1).c_str());
			nodeToInsert->customer->callLaterDate.year = atoi(brokenInfo.substr(secondSlash + 1).c_str());
			nodeToInsert->customer->callLaterTime.hour = atoi(brokenInfo.substr(space + 1, colon - space + 1).c_str());
			nodeToInsert->customer->callLaterTime.minutes = atoi(brokenInfo.substr(colon + 1).c_str());
		}

	}
	callLaterFile.close();
}
Node* findNodeById(Customerlist &list, string id)
{
	Node* curr = list.head;
	while (curr != NULL)
	{
		if (id == curr->customer->id)
			break;
		curr = curr->next;
	}
	return curr;
}

void printList(Customerlist &list)
{
	Node* curr = list.head;
	while (curr != NULL)
	{
		std::cout << curr->customer->firstname << std::endl;

		std::cout << curr->customer->lastname << std::endl;

		std::cout << curr->customer->id << std::endl;

		std::cout << curr->customer->email << std::endl;

		std::cout << curr->customer->phone << std::endl;

		std::cout << curr->customer->status << std::endl;

		std::cout << curr->customer->birthday.day << "." << curr->customer->birthday.month << "." << curr->customer->birthday.year << std::endl;

		std::cout << curr->customer->inserted.day << "." << curr->customer->inserted.month << "." << curr->customer->inserted.year << std::endl;

		std::cout << curr->customer->courses[0] << ", " << curr->customer->courses[1] << ", " << curr->customer->courses[2] << ", " << curr->customer->courses[3] << ", "
			<< curr->customer->courses[4] << ", " << curr->customer->courses[5] << ", " << std::endl << std::endl;

		std::cout << "****History:****" << std::endl;
		for (int i = 0; i < curr->customer->history_amount; i++)
		{
			std::cout << i + 1 << std::endl << curr->customer->history[i].date.day << "." << curr->customer->history[i].date.month << "." << curr->customer->history[i].date.year << std::endl << curr->customer->history[i].representativeName
				<< std::endl << curr->customer->history[i].representativeId << std::endl << "Note:\n" << curr->customer->history[i].Note << std::endl << "---" << std::endl;
		}
		std::cout << "****************" << std::endl << std::endl;
		curr = curr->next;
	}
}
void freeMem(Customerlist &list)
{
	while (list.head != NULL)
	{
		removeNode(list, list.tail);
	}
}

Customer* listToArray(Customerlist &list, int* length) {
	Customer* cust_arr = new Customer[list.size];
	Customer* curr;
	for (int i = 0; i < list.size; i++) {
		curr = extractFromList(list, i)->customer;
		strcpy(cust_arr[i].firstname, curr->firstname);
		strcpy(cust_arr[i].lastname, curr->lastname);
		strcpy(cust_arr[i].id, curr->id);
		cust_arr[i].birthday = curr->birthday;
		strcpy(cust_arr[i].phone, curr->phone);
		strcpy(cust_arr[i].email, curr->email);
		cust_arr[i].status = curr->status;
		cust_arr[i].inserted = curr->inserted;
		for (int j = 0; j < 6; j++)
			cust_arr[i].courses[j] = curr->courses[j];
		cust_arr[i].history_amount = curr->history_amount;
		for (int j = 0; j < cust_arr[i].history_amount; j++)
		{
			cust_arr[i].history[j].date = curr->history[j].date;
			strcpy(cust_arr[i].history[j].representativeName, curr->history[j].representativeName);
			strcpy(cust_arr[i].history[j].representativeId, curr->history[j].representativeId);
			strcpy(cust_arr[i].history[j].Note, curr->history[j].Note);

		}
		cust_arr[i].callLaterDate = curr->callLaterDate;
		cust_arr[i].callLaterTime = curr->callLaterTime;
	}
	*length = list.size;
	return cust_arr;
}

void __stdcall freeArray(Customer* arr) {
	delete[] arr;
	arr = NULL;
}

std::string dateToStr(Date date) {
	//date -> xx/xx/xxxx'\0'
	std::string str;
	str += std::to_string(date.day) + "/" + std::to_string(date.month) + "/" + std::to_string(date.year);
	return str;
}

void __stdcall addToList(Customerlist &list, Customer* customer) {
	if (list.head == NULL) {
		list.head = new Node;
		list.head->customer = customer;
		list.tail = list.head;

	}
	else if (list.tail == list.head) {
		list.tail = new Node;
		list.tail->customer = customer;
		list.head->next = list.tail;
		list.tail->previous = list.head;
	}
	else {
		Node* node = new Node;
		node->previous = list.tail;
		node->customer = customer;
		list.tail->next = node;
		list.tail = node;
	}
	list.size++;
}

void removeNode(Customerlist &list, Node *node) {
	if (list.head == node) {
		if (list.head->next != NULL)
			list.head = node->next;
		else
		{
			list.head = NULL;
			list.tail = NULL;
		}
	}
	else if (list.tail == node) {
		list.tail->previous->next = NULL;
		list.tail = node->previous;
	}
	else {
		node->next->previous = node->previous;
		node->previous->next = node->next;
	}
	delete node->customer;
	delete node;
	list.size--;
}

Node* extractFromList(Customerlist &list, int index) {
	Node* node;
	if (list.head != NULL && index < list.size) {
		node = list.head;
		for (int i = 0; i < index; i++) {
			node = node->next;
		}
		return node;
	}
	return NULL;
}

bool addToCustomerFile(Customer cust) {
	///Add new customer to the end of the file.

	string file_name = "Customers";
	string txt = "";
	string line = "";

	std::ofstream file_out(file_name + ".txt", std::ios::app);
	if (!file_out.is_open())
	{
		std::cout << "Error writing to Customers.txt!" << std::endl;
		return false;
	}
	file_out.seekp(0, std::ios_base::end);
	if (file_out.tellp() != 0)
		txt += "\n";
	txt += "****\n";
	txt += "Name:";
	txt += cust.firstname;
	txt += " ";
	txt += cust.lastname;
	txt += "\n";
	txt += "Id:";
	txt += cust.id;
	txt += "\n";
	txt += "Email:";
	txt += cust.email;
	txt += "\n";
	txt += "Phone:";
	txt += cust.phone;
	txt += "\n";
	txt += "Birthdate:";
	txt += dateToStr(cust.birthday);
	txt += "\n";
	txt += "Status:";
	txt += std::to_string(cust.status);
	txt += "\n";
	txt += "Insertion date:";
	txt += dateToStr(cust.inserted);
	txt += "\n";
	txt += "Courses:";
	for (int i = 0; i < 6; i++)
	{
		if (cust.courses[i])
		{
			if (i != 0)
				txt += ",";
			txt += std::to_string(i + 1);
		}
	}

	file_out << txt;

	file_out.close();

	Customer* temp = new Customer();
	strcpy(temp->firstname, cust.firstname);
	strcpy(temp->lastname, cust.lastname);
	strcpy(temp->id, cust.id);
	temp->birthday = cust.birthday;
	strcpy(temp->phone, cust.phone);
	strcpy(temp->email, cust.email);
	temp->status = cust.status;
	temp->inserted = cust.inserted;
	for (int j = 0; j < 6; j++)
		temp->courses[j] = cust.courses[j];
	temp->history_amount = cust.history_amount;
	for (int j = 0; j < cust.history_amount; j++)
	{
		temp->history[j].date = cust.history[j].date;
		strcpy(temp->history[j].representativeName, cust.history[j].representativeName);
		strcpy(temp->history[j].representativeId, cust.history[j].representativeId);
		strcpy(temp->history[j].Note, cust.history[j].Note);

	}
	temp->callLaterDate = cust.callLaterDate;
	temp->callLaterTime = cust.callLaterTime;
	addToList(*globalList, temp);
	printList(*globalList);
	return true;
}

bool addToHistoryFile(Customer cust, bool newCustomer) {
	///Add new customer to the end of the file.

	string file_name = "History";
	string txt = "";
	string line = "";
	std::ofstream file_out(file_name + ".txt", std::ios::app);
	if (!file_out.is_open())
	{
		std::cout << "Error writing to History.txt!" << std::endl;
		return false;
	}
	file_out.seekp(0, std::ios_base::end);
	if (file_out.tellp() != 0)
		txt += "\n";

	txt += "****\n";
	txt += "Id:";
	txt += cust.id;
	txt += "\n";
	txt += "Rep. name:";
	txt += cust.history[cust.history_amount - 1].representativeName;
	txt += "\n";
	txt += "Rep. id:";
	txt += cust.history[cust.history_amount - 1].representativeId;
	txt += "\n";
	txt += "Date:";
	txt += dateToStr(cust.history[cust.history_amount - 1].date);
	txt += "\n";
	txt += "Note:\n";
	txt += cust.history[cust.history_amount - 1].Note;
	txt += "-&-";

	file_out << txt;

	file_out.close();
	if (!newCustomer)
	{
		Node* temp = findNodeById(*globalList, cust.id);
		strcpy(temp->customer->history[cust.history_amount - 1].representativeName, cust.history[cust.history_amount - 1].representativeName);
		strcpy(temp->customer->history[cust.history_amount - 1].representativeId, cust.history[cust.history_amount - 1].representativeId);
		temp->customer->history[cust.history_amount - 1].date = cust.history[cust.history_amount - 1].date;
		strcpy(temp->customer->history[cust.history_amount - 1].Note, cust.history[cust.history_amount - 1].Note);
	}
	return true;
}

bool addToCallLaterFile(Customer cust, bool newCustomer)
{

	string file_name = "CallLater";
	string txt = "";
	string line = "";
	std::ofstream file_out(file_name + ".txt", std::ios::app);
	if (!file_out.is_open())
	{
		std::cout << "Error writing to CallLater.txt!" << std::endl;
		return false;
	}
	file_out.seekp(0, std::ios_base::end);
	if (file_out.tellp() != 0)
		txt += "\n";

	txt += "****\n";
	txt += "Id:";
	txt += cust.id;
	txt += "\n";
	txt += "At:";
	txt += dateToStr(cust.callLaterDate) + " " + std::to_string(cust.callLaterTime.hour) + ":" + std::to_string(cust.callLaterTime.minutes);

	file_out << txt;

	file_out.close();
	if (!newCustomer)
	{
		Node* temp = findNodeById(*globalList, cust.id);
		temp->customer->callLaterDate = cust.callLaterDate;
		temp->customer->callLaterTime = cust.callLaterTime;
	}
	return true;
}

bool __stdcall updateDatabase(char id[], Customer cust, int action, int editCallLater, int editHistory, int index)
{
	std::cout << id << std::endl;
	std::cout << action << std::endl;
	if (action == edited || action == deleted)
		return editOrRemoveCustomer(id, cust, action, editCallLater, editHistory, index);
	else if (action == added)
	{
		bool res = true;
		res = res && addToCustomerFile(cust);
		if (editHistory == added)
			res = res && addToHistoryFile(cust, true);
		if (editCallLater == added)
			res = res && addToCallLaterFile(cust, true);
		return res;
	}
	else if (action == no_change)
	{
		if (editHistory == edited || editHistory == deleted)
			return editOrRemoveHistory(id, cust, index, editHistory);
		if (editHistory == added)
			return addToHistoryFile(cust, false);

	}
	return false;
}

bool editOrRemoveCustomer(char id[], Customer cust, int action, int editCallLater, int editHistory, int index)
{
	std::ifstream customerFile("Customers.txt");
	if (!customerFile.is_open())
	{
		std::cout << "Error reading Customers.txt!" << std::endl;
		return false;
	}
	string res = "";
	string curr = "";
	string nameLine = "";
	bool found = false;
	while (customerFile.peek() != EOF)
	{

		std::getline(customerFile, curr);//****
		std::getline(customerFile, nameLine);//Name:___
		std::getline(customerFile, curr);//Id:___
		//std::cout << curr << std::endl;
		if (!found && curr.substr(curr.find("Id:") + 3) == id)
		{
			//std::cout << curr.substr(curr.find("Id:")+3) << std::endl;

			if (action == edited)//if the desired action is editing
			{
				if (res != "")
					res += "\n";
				res += "****\n";
				res += "Name:";
				res += cust.firstname;
				res += " ";
				res += cust.lastname;
				res += "\n";
				res += "Id:";
				res += cust.id;
				res += "\n";
				res += "Email:";
				res += cust.email;
				res += "\n";
				res += "Phone:";
				res += cust.phone;
				res += "\n";
				res += "Birthdate:";
				res += dateToStr(cust.birthday);
				res += "\n";
				res += "Status:";
				res += std::to_string(cust.status);
				res += "\n";
				res += "Insertion date:";
				res += dateToStr(cust.inserted);
				res += "\n";
				res += "Courses:";

				for (int i = 0; i < 6; i++)
				{
					if (cust.courses[i])
					{
						if (i != 0)
							res += ",";
						res += std::to_string(i + 1);
					}
				}
			}

			while (curr.find("Courses:") == string::npos)//get rid of rest of the old customer text data
				std::getline(customerFile, curr);


			found = true;
			if (action == deleted)
				continue;
		}
		else
		{
			if (res != "")
				res += "\n";
			res += "****\n";
			res += nameLine + "\n";
			res += curr;
			while (curr.find("Courses:") == string::npos)
			{
				res += "\n";
				std::getline(customerFile, curr);
				res += curr;
			}
		}
	}
	if (!found)
		return false;
	customerFile.close();
	std::ofstream updatedCustomerFile;
	updatedCustomerFile.open("Customers.txt", std::ios::out | std::ofstream::trunc);//clearing it out
	//updatedCustomerFile.close();
	//updatedCustomerFile.open("Customers.txt", std::ios::trunc);
	if (!updatedCustomerFile.is_open())
	{
		std::cout << "Error writing to Customers.txt!" << std::endl;
		return false;
	}
	updatedCustomerFile << res;
	updatedCustomerFile.close();
	////////////////////////////////////////////////////////////////////////////////
	bool fine = true;

	if (action == deleted)
	{
		fine = fine && editOrRemoveHistory(id, cust, -1, action) && editOrRemoveCallLater(id, cust, action);
		if (fine)
			removeNode(*globalList, findNodeById(*globalList, id));
		return fine;
	}
	else if (action == edited)
	{
		if (editHistory == edited || editHistory == deleted)
		{
			fine = fine && editOrRemoveHistory(id, cust, index, editHistory);
		}
		else if (editHistory == added)
			addToHistoryFile(cust, false);

		if (editCallLater == edited || editCallLater == deleted)
		{
			fine = fine && editOrRemoveCallLater(id, cust, editCallLater);
		}
		else if (editCallLater == added)
			addToCallLaterFile(cust, false);
		Customer* toEdit = findNodeById(*globalList, id)->customer;
		strcpy(toEdit->firstname, cust.firstname);
		strcpy(toEdit->lastname, cust.lastname);
		strcpy(toEdit->id, cust.id);
		toEdit->birthday = cust.birthday;
		strcpy(toEdit->phone, cust.phone);
		strcpy(toEdit->email, cust.email);
		toEdit->status = cust.status;
		toEdit->inserted = cust.inserted;
		for (int j = 0; j < 6; j++)
			toEdit->courses[j] = cust.courses[j];
		toEdit->history_amount = cust.history_amount;
		for (int j = 0; j < toEdit->history_amount; j++)
		{
			toEdit->history[j].date = cust.history[j].date;
			strcpy(toEdit->history[j].representativeName, cust.history[j].representativeName);
			strcpy(toEdit->history[j].representativeId, cust.history[j].representativeId);
			strcpy(toEdit->history[j].Note, cust.history[j].Note);

		}
		toEdit->callLaterDate = cust.callLaterDate;
		toEdit->callLaterTime = cust.callLaterTime;

	}

	return fine;

}
bool editOrRemoveHistory(char id[], Customer cust, int index, int action)
{
	std::ifstream historyFile("History.txt");
	if (!historyFile.is_open())
	{
		std::cout << "Error reading History.txt!" << std::endl;
		return false;
	}
	string res = "";
	string curr = "";
	int currIndex = 0;
	while (historyFile.peek() != EOF)
	{
		std::getline(historyFile, curr);//****
		std::getline(historyFile, curr);//Id:___
		if (curr.substr(curr.find("Id:") + 3) == id)
		{
			if (action == edited || (action == deleted && index != -1 && currIndex != index))//if the desired action is editing or the entry isn't the one desired to be deleted 
			{
				if (res != "")
					res += "\n";
				res += "****\n";
				res += "Id:";
				res += cust.id;
				res += "\n";
				res += "Rep. name:";
				res += cust.history[currIndex].representativeName;
				res += "\n";
				res += "Rep. id:";
				res += cust.history[currIndex].representativeId;
				res += "\n";
				res += "Date:";
				res += dateToStr(cust.history[currIndex].date);
				res += "\n";
				res += "Note:\n";
				res += cust.history[currIndex].Note;

				res += "-&-";
			}

			std::getline(historyFile, curr);
			while (curr != "-&-")//get rid of rest of the old customer text data
				std::getline(historyFile, curr);

			currIndex++;
			if (action == deleted)
				continue;
		}
		else
		{
			if (res != "")
				res += "\n";
			res += "****\n";
			res += curr;
			while (curr != "-&-")
			{
				res += "\n";
				std::getline(historyFile, curr);
				res += curr;
			}
		}

	}
	historyFile.close();
	std::ofstream updatedHistoryFile;
	updatedHistoryFile.open("History.txt", std::ofstream::out | std::ofstream::trunc);
	if (!updatedHistoryFile.is_open())
	{
		std::cout << "Error writing to History.txt!" << std::endl;
		return false;
	}
	updatedHistoryFile << res;
	updatedHistoryFile.close();
	Node* temp = findNodeById(*globalList, id);
	if (action == deleted)
	{
		std::cout << "index: " << index << std::endl;
		int i = 0;
		if (index == -1)
		{
			std::cout << "max amount: " << temp->customer->history_amount << std::endl;
			for (i = 0; i < temp->customer->history_amount; i++)
			{
				std::cout << "curr: " << i << std::endl;
				strcpy(temp->customer->history[i].representativeId, "");
				strcpy(temp->customer->history[i].representativeName, "");
				strcpy(temp->customer->history[i].Note, "");
				Date dt;
				temp->customer->history[i].date = dt;
				std::cout << i << " ended" << std::endl;
			}
			temp->customer->history_amount = 0;
		}
		else
		{
			for (i = index; i < temp->customer->history_amount - 1; i++)
			{
				strcpy(temp->customer->history[i].representativeId, temp->customer->history[i + 1].representativeId);
				strcpy(temp->customer->history[i].representativeName, temp->customer->history[i + 1].representativeName);
				strcpy(temp->customer->history[i].Note, temp->customer->history[i + 1].Note);
				temp->customer->history[i].date = temp->customer->history[i + 1].date;
			}
			strcpy(temp->customer->history[i].representativeId, "");
			strcpy(temp->customer->history[i].representativeName, "");
			strcpy(temp->customer->history[i].Note, "");
			Date dt;
			temp->customer->history[i].date = dt;
			temp->customer->history_amount--;
		}
	}
	else if (action == edited)
	{

		if (index == -1)
		{

			for (int i = 0; i < temp->customer->history_amount; i++)
			{

				strcpy(temp->customer->history[i].representativeId, cust.history[i].representativeId);
				strcpy(temp->customer->history[i].representativeName, cust.history[i].representativeName);
				strcpy(temp->customer->history[i].Note, cust.history[i].Note);
				temp->customer->history[i].date = cust.history[i].date;

			}
		}
		else
		{
			strcpy(temp->customer->history[index].representativeId, cust.history[index].representativeId);
			strcpy(temp->customer->history[index].representativeId, cust.history[index].representativeId);
			strcpy(temp->customer->history[index].representativeName, cust.history[index].representativeName);
			strcpy(temp->customer->history[index].Note, cust.history[index].Note);
			temp->customer->history[index].date = cust.history[index].date;
		}
	}
	return true;
}
bool editOrRemoveCallLater(char id[], Customer cust, int action)
{
	std::ifstream callLaterFile("CallLater.txt");
	if (!callLaterFile.is_open())
	{
		std::cout << "Error reading CallLater.txt!" << std::endl;
		return false;
	}
	string res = "";
	string curr = "";
	bool found = false;
	while (callLaterFile.peek() != EOF)
	{
		std::getline(callLaterFile, curr);//****
		std::getline(callLaterFile, curr);//Id:___
		std::cout << curr << std::endl;

		if (!found && curr.substr(curr.find("Id:") + 3) == id)
		{
			std::cout << curr.substr(curr.find("Id:") + 3) << std::endl;
			if (action == edited)//if the desired action is editing
			{
				if (res != "")
					res += "\n";
				res += "****\n";
				res += "Id:";
				res += cust.id;
				res += "\n";
				res += "At:";
				res += dateToStr(cust.callLaterDate) + " " + std::to_string(cust.callLaterTime.hour) + ":" + std::to_string(cust.callLaterTime.minutes);
			}
			std::getline(callLaterFile, curr);//At:___
			found = true;
			if (action == deleted)
				continue;
		}
		else
		{
			if (res != "")
				res += "\n";
			res += "****\n";
			res += curr + "\n";
			std::getline(callLaterFile, curr);//At:___
			res += curr;
		}

	}
	callLaterFile.close();
	std::ofstream updatedCallLaterFile;
	updatedCallLaterFile.open("CallLater.txt", std::ofstream::out | std::ofstream::trunc);
	if (!updatedCallLaterFile.is_open())
	{
		std::cout << "Error writing to CallLater.txt!" << std::endl;
		return false;
	}
	updatedCallLaterFile << res;
	updatedCallLaterFile.close();
	/////////////////////////////////////////

	Node* temp = findNodeById(*globalList, id);
	if (action == deleted)
	{
		Date dt;
		Time tm;
		temp->customer->callLaterDate = dt;
		temp->customer->callLaterTime = tm;
	}
	else
	{
		temp->customer->callLaterDate = cust.callLaterDate;
		temp->customer->callLaterTime = cust.callLaterTime;
	}
	return true;

}


int checkValidName(char* _name) {
	std::string name = _name;
	if (name.length() < 2)
		return 0;
	for (int i = 0; i < (int)name.length(); i++) {
		if (!((name.at(i) >= 'A' && name.at(i) <= 'Z') || (name.at(i) >= 'a' && name.at(i) <= 'z'))) {
			return 0;
		}
	}

	return 1;
}

int __stdcall checkValidID(char* Id) {
	std::string id = Id;
	if (id.length() != 9) 
		return 0;
	for (int i = 0; i < id.length(); i++) {
		if (id.at(i) < '0' || id.at(i) > '9') {
			return 0;
		}
	}
	return 1;
}

int checkValidPhoneNum(char* num) {
	std::string phone = num;
	size_t dash = phone.find('-');
	if ((phone.length()-dash-1) !=7)
		return 0;
	
	if (dash == string::npos || dash >3 || dash < 2) {
		return 0;
	}
	for (int i = 0; i < phone.length(); i++) {
		if (i != dash)
		{
			if (phone.at(i) < '0' || phone.at(i) > '9') {
				return 0;
			}
		}
	}

	return 1;
}

int checkValidEmail(char* Email) {
	std::string email = Email;
	if (email.find('@') == string::npos) {
		return 0;
	}
	if (email.find('.', email.find('@')) == string::npos) {
		return 0;
	}
	return 1;
}


void __stdcall validateAndUpdate(int* res,Customer cust,char originalId[], int action) {
	const int size = 5;
	//[0]First name, [1]Last name, [2]id, [3]phone, [4]email.
	
	res[0] = checkValidName(cust.firstname);
	res[1] = checkValidName(cust.lastname);
	res[2] = checkValidID(cust.id);
	res[3] = checkValidPhoneNum(cust.phone);
	res[4] = checkValidEmail(cust.email);

	if ((action == added || (action == edited && strcmp(cust.id, originalId) != 0)) && findNodeById(*globalList, cust.id) != NULL)
	{
		res[5] = 0;
	}
	else
		res[5] = 1;
	/*
	if (flag == true) {
		std::cout << "[Save in file:" << (flag=updateDatabase(id,cust,action,editCallLater,editHistory,index) == true ? "true" : "false") << "]";
		std::cout << "\nworked and all true!\n";
	}
	else {
		std::cout << "\nsomthing is not right..\n";
	}*/
}