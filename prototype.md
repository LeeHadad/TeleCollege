TeleCollage Prototypes:
*required _CRT_SECURE_NO_WARNINGS
*required <string> library.
*required <iostream> library.
*required <time.h> library.
*Lead functions do not verify if input is valid.

enum { not_interested = 0, low, moderate, good, interested = 4 }
typedef customer_potential;
struct Lead;

void SetLeadName(Lead &, std::string);
void SetLeadEmail(Lead &, std::string);
void SetLeadNum(Lead &, int);
void SetLeadId(Lead &, int);
void SetLeadPhone (Lead &, int);
void SetLeadPotential(Lead &,customer_potential);
void AddLeadDoc(Lead &, std::string saler_name, std::string doc);

bool CheckValidName(std::string);

struct Leadlist;
struct Node;

void AddToList(Leadlist &, Lead &);
void RemoveNode(Leadlist &, Node *);
Node* ExtractFromList(Leadlist &, int);

void SortListByLetters(Leadlist &);
void SortListByPotential(Leadlist &);

void SaveFile(std::string , Leadlist& );

const std::string currentDateTime();
// Visit http://en.cppreference.com/w/cpp/chrono/c/strftime
	// for more information about date/time format

