// Unweighted graph.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;       
#include <list>           
#include <queue>
#include <stack>

class Vertice {
public:
	int value;
	bool edges[15][15];				// Adjacency matrix

	Vertice(int value)
	{
		this->value = value;
	}

	void addEdges(Vertice *V1, Vertice *V2)
	{
		edges[V1->value][V2->value] = true;
		//edges[V2.value][V1.value] = true;
	}

	void InitializationOfEdge()
	{
		for (int i = 0;  i < 14; i++)
		{
			for (int j = 0;  j < 14 ; j++)
			{
				edges[i][j] = false;
			}
		}
	}



	~Vertice() {
		std::cout << "Graph destructor" << std::endl;
	}
};

class MyGraph 
{
public :
		int n;								// number of vertices ?
		list<Vertice*> listVertices;

		MyGraph(int n/*, bool edges[15][15]*/)
		{
			//this->edges = edges;
			this->n = n;
		}
		
		~MyGraph(){
			std::cout << "Graph destructor" << std::endl;
		}

		 Vertice* addVertex(int i)
		{
			listVertices.push_back(new Vertice(i));
			return listVertices.back();
		}

};





list <int> BFS(MyGraph *G, Vertice *V)
{	
	// i think that the queue shoud be an array or a list , dont know how to create one
	
	//int n = G->n;							// number of vertices of the graph
	queue <int> Q;							// Creation of a queue thanks to "#include <queue>"	
	list <int> visited;
	Q.push(V->value);						// ADD the value of the vertice in the queue

	//bool visited [15];						// Array to know if a vertice has been visited
	//visited[V->value] = true;				// first vertice is visted
	
	//vector<int> wasVisited;

											// Q.front() = next thing in the queue
											// Q.back() = the last think in the queue
	while (!Q.empty())
	{
		int u = Q.front();
		Q.pop();
		//std::cout <<  u << std::endl;		// Display u

		if (find(visited.begin(), visited.end(), u) == visited.end())
		{
			//wasVisited.emplace_back(u);
			visited.push_back(u);
			for (int i = 0; i < G->n; i++)		// edges is a matrix (2D)
			{
				for (int j = 0; j < G->n; j++)
				{
					if (V->edges[i][j])
					{
						Q.push(j);				// i have to push the value of the vertice wich is edged
					}
				}
			}
		}

		/*if (!visited[u])			
		{
			visited[u] = true;
		}*/
		
	}
	//return wasVisited;
	return visited;
}

vector <int> DFS(MyGraph *G, Vertice *V)
{
	stack <int> s;
	int n = G->n;
	//bool visited[15];
	vector<int> wasVisited;
	//visited[V->value] = true;		// Automaticaly visited
	s.push(V->value);

	while (!s.empty())
	{
		std::cout << s.top();
		int u = s.top();
		 s.pop();

		 if (find(wasVisited.begin(), wasVisited.end(), u) == wasVisited.end())
		 {
			 wasVisited.emplace_back(u);
			 for (int i = 0; i < n; i++)		
			 {
				 for (int j = 0; j < n; j++)
				 {
					 if (V->edges[i][j])
					 {
						 s.push(j);				
					 }
				 }
			 }
			 
		 }
	}
	return wasVisited;
}


int main()
{
	//list<Vertice*>listVertices;
	Vertice *V1 = new Vertice(1);
	V1->InitializationOfEdge();

	MyGraph *G = new MyGraph(10);
	

	// for each 

	G->addVertex(1);
	G->addVertex(2);
	G->addVertex(3);
	G->addVertex(4);
	G->addVertex(5);
	G->addVertex(6);
	G->addVertex(7);
	G->addVertex(8);
	G->addVertex(9);
	G->addVertex(10);

	//Vertice *V1 = new Vertice(1);
	Vertice *V2 =new Vertice(2);
	Vertice *V3 =new Vertice(3);
	Vertice *V4 =new Vertice(4);
	Vertice *V5 =new Vertice(5);
	Vertice *V6 =new Vertice(6);
	Vertice *V7 =new Vertice(7);
	Vertice *V8 =new Vertice(8);
	Vertice *V9 =new Vertice(9);
	Vertice *V10 =new Vertice(10);
		
	V1->addEdges(V1, V2);
	
	V1->addEdges(V2, V3);
	V1->addEdges(V3, V4);
	V1->addEdges(V3, V6);
	V1->addEdges(V5, V6);
	V1->addEdges(V1, V6);
	V1->addEdges(V4, V7);
	V1->addEdges(V7, V8);
	V1->addEdges(V8, V5);

	list<int> result = BFS(G, V1);
	std::list<int>::const_iterator iterator;
	
	for (iterator = result.begin() = result.begin(); iterator != result.end(); iterator++)
		cout << *iterator << " ";
    return 0;
}

