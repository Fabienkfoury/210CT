// Unweighted graph.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class MyGraph 
{
public :
		Vertice	ArrayVertices[10];
		bool edges [10][10];				// Adjacency matrix

		MyGraph(Vertice ArrayVertices[], bool edges[][10][10])
		{
			this->ArrayVertices = ArrayVertices;
			this->edges = edges;
		}
		~MyGraph(){
			std::cout << "Graph destructor" << std::endl;
		}

};

class Vertice {
public:
	int value;

	Vertice( int value)
	{
		
		this->value = value;
	}

	Vertice()
	{
		this->value = 0;
	}

	~Vertice() {
		std::cout << "Graph destructor" << std::endl;
	}

	
};

void addVertice(Vertice*ArrayVertices[], int value)
{
	Vertice* V = new Vertice(value);
	ArrayVertices[value] = V;
}

void addEdge(bool edges[][10][10],Vertice V1, Vertice V2)
{
	edges[V1.value][V2.value] = true;
	edges[V2.value][V1.value] = true;
}


int main()
{
	Vertice* ArrayVertices[10];
	addVertice(ArrayVertices, 1);
	addVertice(ArrayVertices, 2);
	addVertice(ArrayVertices, 3);
	addVertice(ArrayVertices, 4);


    return 0;
}

