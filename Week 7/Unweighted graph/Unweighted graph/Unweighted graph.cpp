// Unweighted graph.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;       
#include <list>           
#include <queue>
#include <stack>

class MyGraph 
{
public :
		int n;								// number of vertices ?
		//Vertice	*ArrayVertices[15];
		bool edges [15][15];				// Adjacency matrix

		MyGraph(int n, bool edges[15][15])
		{
			this->edges = edges;
			this->n = n;
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

	~Vertice() {
		std::cout << "Graph destructor" << std::endl;
	}
};

void addVertice(list <Vertice> l, int value)
{
	
	l[value];
}

void addEdge(MyGraph *G,Vertice* V1, Vertice* V2)			// do not forget the pointer MyGraph *G otherwise, i cant access to the attributes
{
	G->edges[V1->value][V2->value] = true;
	G->edges[V2->value][V1->value] = true;
	
}

bool BFS(MyGraph *G, Vertice *V)
{	
	// i think that the queue shoud be an array or a list , dont know how to create one
	
	int n = G->n;							// number of vertices of the graph
	queue <int> Q;							// Creation of a queue thanks to "#include <queue>"	
	Q.push(V->value);						// ADD the value of the vertice in the queue

	bool visited [n];						// Array to know if a vertice has been visited
	visited[V->value] = true;				// first vertice is visted
	
											// Q.front() = next thing in the queue
											// Q.back() = the last think in the queue
	while (!Q.empty())
	{
		int u = Q.front();					// Dequeue
		std::cout <<  u << std::endl;		// Display u

		if (!visited[u])			
		{
			visited[u] = true;
		}
		for (int i = 0 ; i < n  ; i++)		// edges is a matrix (2D)
		{
			for (int j = 0 ; j < n ; j++)
			{
				if (G->edges[i][j])
				{
					Q.push(j);				// i have to push the value of the vertice wich is edged
				}
			}
		}
	}
	return visited;
}

bool DFS(MyGraph *G, Vertice *V)
{
	stack <int> s;
	int n = G->n;
	bool visited[n];
	visited[V->value] = true;		// Automaticaly visited
	s.push(V->value);

	while (!s.empty())
	{
		std::cout << s.top();
		int u = s.top();
		 s.pop();

		 if (!visited[u])
		 {
			 visited[u] = true;
		 }
	}
}


int main()
{
	list<Vertice>listVertices;
	bool edge[15][15];
	MyGraph *G = new MyGraph(10, edge);

	addVertice(listVertices, 1);
	addVertice(listVertices, 2);
	addVertice(listVertices, 3);
	addVertice(listVertices, 4);
	addVertice(listVertices, 5);
	addVertice(listVertices, 6);
	addVertice(listVertices, 7);
	addVertice(listVertices, 8);
	addVertice(listVertices, 9);
	addVertice(listVertices, 10);

	addEdge(G, ArrayVertices[1], ArrayVertices[2]);
	addEdge(G, ArrayVertices[2], ArrayVertices[3]);
	addEdge(G, ArrayVertices[3], ArrayVertices[4]);
	addEdge(G, ArrayVertices[3], ArrayVertices[6]);
	addEdge(G, ArrayVertices[5], ArrayVertices[6]);
	addEdge(G, ArrayVertices[1], ArrayVertices[6]);
	addEdge(G, ArrayVertices[4], ArrayVertices[7]);
	addEdge(G, ArrayVertices[7], ArrayVertices[8]);
	addEdge(G, ArrayVertices[8], ArrayVertices[5]);



    return 0;
}

