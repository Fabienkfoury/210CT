// Node_Delete_function.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

//Nodes and lists use public data members for convenience
//This may make some software engineers froth at the mouth

class Node
{
public:
	int value; //This could really be any type
	Node* next;
	Node* prev;
	Node(int val){								// constructeur 
		std::cout << "Node constructor!" << std::endl;
		this->value = val;
		this->next = (Node*)0;
		this->prev = (Node*)0;
	}
	~Node(){
		std::cout << "Node destructor" << std::endl;
		std::cout << "I had the value " << this->value << std::endl;
	}
};

class List
{

public:
	Node* head;
	Node* tail;

	List(){							// Constructor 
		std::cout << "List Constructor!" << std::endl;
		this->head = 0;				// head = tail at the begining because the list is empty 
		this->tail = 0;
	}

	~List(){						// Destructor 
		std::cout << "List destructor!" << std::endl;	
		
		Node* n;
		while (this->head != 0)
		{
			n = head->next;
			delete(head);
			this->head = n;
		}
		std::cout << " All nodes deleted" << std::endl;

		

	}

	void insert(Node* n, Node* x){
		std::cout << "insert node " << x << std::endl;

		if (n != 0 ){					// (head)--><--(n)-><--(x)--><--(tail)
										// x is the node just after n
			x->next = n->next;
			n->next = x;
			x->prev = n;
			if (x->next != 0)
				x->next->prev = x;
		}
		if (this->head == 0){					// if there is no elements in the list 
			this->head = x;
			this->tail = x;
			x->prev = 0;
			x->next = 0;
		}
		else if (this->tail == n){				//if we want to insert at the end of the list 
			this->tail = x;
		}
	}

	void remove(Node* n)
	{											// n is the node we want to delete 
		std::cout << "remove node " << n << std::endl;

		if (n != 0 && this->head != n && this->tail != n)
		{
			//std::cout << "Not the head and not the tail " << n << std::endl;
			n->next->prev = n->prev;
			n->prev->next = n->next;
		}

		if (this->head == n)
		{
			//std::cout << " HEAD " << n << std::endl;
			this->head = n->next;
		}

		else if (this->tail == n)
		{
			//std::cout << " TAIL " << n << std::endl;
			n->prev->next = 0;
			this->tail = n->prev;
		}
	}

	void display(){
		Node* i = this->head;
		std::cout << "List: ";
		while (i != 0){
			std::cout << i->value << ",";
			i = i->next;
		}
		std::cout << std::endl;
	}

	Node *find(int val)
	{
		Node *n = this->head;
		while ( n != 0 )
		{
			if (n->value == val) {
				break;
			}
		
			n = n->next;
		}
		return n;
	}
};

int main(int argc, char *argv[])
{
	List* l = new List();

	l->insert(l->head, new Node(4));
	l->insert(l->head, new Node(6));
	l->insert(l->head, new Node(8));
	l->display();
	l->remove(l->find(4));
	l->display();

	delete l;
	getchar();
	return 0;
}