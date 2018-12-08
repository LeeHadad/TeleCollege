#include "fileOperations.h"

int main()
{
	Client* head = fileToList();
	
	printList(head);
	if(head!=NULL)
		freeMem(head);
	
	getchar();
}

Client* fileToList()
{
	std::ifstream clientsFile("Clients.txt");
	if (!clientsFile.is_open())
	{
		std::cout << "Error opening Clients.txt!\n";
		return NULL;
	}
	string currLine = "";
	string brokenInfo;
	Client* head = NULL;
	Client* temp = NULL;
	while (clientsFile.peek() != EOF)
	{
		if (head == NULL)
		{
			temp = new Client();
			head = temp;
		}
		else
		{
			temp->next = new Client();
			temp = temp->next;
		}
		std::getline(clientsFile, currLine);
		std::getline(clientsFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Name:") + 5);
		strcpy(temp->firstname, brokenInfo.substr(0, brokenInfo.find(' ')).c_str());
		strcpy(temp->lastname, brokenInfo.substr(brokenInfo.find(' ') + 1).c_str());

		std::getline(clientsFile, currLine);
		strcpy(temp->id, currLine.substr(currLine.find("Id:") + 3).c_str());

		std::getline(clientsFile, currLine);
		strcpy(temp->email, currLine.substr(currLine.find("Email:") + 6).c_str());

		std::getline(clientsFile, currLine);
		strcpy(temp->phone, currLine.substr(currLine.find("Phone:") + 6).c_str());

		std::getline(clientsFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Birthdate:") + 10);
		if (brokenInfo != "")
		{
			temp->birthday.day = atoi(brokenInfo.substr(0, 2).c_str());
			temp->birthday.month = atoi(brokenInfo.substr(3, 2).c_str());
			temp->birthday.year = atoi(brokenInfo.substr(6, 4).c_str());
		}

		std::getline(clientsFile, currLine);
		temp->status = atoi(currLine.substr(currLine.find("Status:") + 7).c_str());

		std::getline(clientsFile, currLine);
		brokenInfo = currLine.substr(currLine.find("Insertion date:") + 15);
		if (brokenInfo != "")
		{
			temp->inserted.day = atoi(brokenInfo.substr(0, 2).c_str());
			temp->inserted.month = atoi(brokenInfo.substr(3, 2).c_str());
			temp->inserted.year = atoi(brokenInfo.substr(6, 4).c_str());
		}
		std::getline(clientsFile, currLine);
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

	}
	assignHistory(head);
	clientsFile.close();
	return head;
}
void assignHistory(Client* head)
{
	std::ifstream historyFile("History.txt");
	if (!historyFile.is_open())
	{
		std::cout << "Error opening History.txt!\n";
		return;
	}
	string currLine = "";
	string id;
	Client* nodeToInsert = NULL;
	string brokenInfo;
	while (historyFile.peek() != EOF)
	{
		std::getline(historyFile, currLine);
		if (currLine == "****")
		{
			std::getline(historyFile, currLine);
			id = currLine.substr(currLine.find("Id:") + 3);
			nodeToInsert = findNodeById(id, head);
			if (nodeToInsert == NULL)//in case client does not exist
				continue;
			std::getline(historyFile, currLine);
			strcpy(nodeToInsert->history[nodeToInsert->history_amount].representativeName, (currLine.substr(currLine.find("Rep. name:") + 10)).c_str());
			std::getline(historyFile, currLine);
			strcpy(nodeToInsert->history[nodeToInsert->history_amount].representativeId, (currLine.substr(currLine.find("Rep. id:") + 8)).c_str());
			std::getline(historyFile, currLine);
			brokenInfo = currLine.substr(currLine.find("Date:") + 5);
			if (brokenInfo != "")
			{
				nodeToInsert->history[nodeToInsert->history_amount].date.day = atoi(brokenInfo.substr(0, 2).c_str());
				nodeToInsert->history[nodeToInsert->history_amount].date.month = atoi(brokenInfo.substr(3, 2).c_str());
				nodeToInsert->history[nodeToInsert->history_amount].date.year = atoi(brokenInfo.substr(6, 4).c_str());
			}
			nodeToInsert->history_amount++;
			std::getline(historyFile, currLine);//get rid of "Note:"
			continue;
		}
		if (nodeToInsert == NULL)//in case client does not exist
			continue;

		strcat(nodeToInsert->history[nodeToInsert->history_amount - 1].Note, (currLine + '\n').c_str());

	}
}
Client* findNodeById(string id, Client* Node)
{
	while (Node != NULL)
	{
		if (id == Node->id)
			break;
		Node = Node->next;
	}
	return Node;
}

void printList(Client* node)
{
	while (node != NULL)
	{
		std::cout << node->firstname << std::endl;

		std::cout << node->lastname << std::endl;

		std::cout << node->id << std::endl;

		std::cout << node->email << std::endl;

		std::cout << node->phone << std::endl;

		std::cout << node->status << std::endl;

		std::cout << node->birthday.day << "." << node->birthday.month << "." << node->birthday.year << std::endl;

		std::cout << node->inserted.day << "." << node->inserted.month << "." << node->inserted.year << std::endl;

		std::cout << node->courses[0] << ", " << node->courses[1] << ", " << node->courses[2] << ", " << node->courses[3] << ", "
			<< node->courses[4] << ", " << node->courses[5] << ", " << std::endl << std::endl;

		std::cout << "****History:****" << std::endl;
		for (int i = 0; i < node->history_amount; i++)
		{
			std::cout << i + 1 << std::endl << node->history[i].date.day << "." << node->history[i].date.month << "." << node->history[i].date.year << std::endl << node->history[i].representativeName
				<< std::endl << node->history[i].representativeId << std::endl << "Note:\n" << node->history[i].Note << std::endl << "---" << std::endl;
		}
		std::cout << "****************" << std::endl << std::endl;
		node = node->next;
	}
}
void freeMem(Client* Node)
{
	if (Node->next != NULL)
		freeMem(Node->next);
	delete Node;
}
