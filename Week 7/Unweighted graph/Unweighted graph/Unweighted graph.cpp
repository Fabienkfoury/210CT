// Unweighted graph.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;       
#include <list>           
#include <queue>
#include <fstream>
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
		edges[V2->value][V1->value] = true;
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
		int n;								
		list<Vertice*> listVertices;

		MyGraph(int n)
		{
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



list <int> DFS(MyGraph *G, Vertice *V)			//DEPTH FIRST SEARCH
{	
	stack <int> S;
	list <int> visited;
	S.push(V->value);	

	while (!S.empty())
	{
		int u = S.top();
		S.pop();

		if (find(visited.begin(), visited.end(), u) == visited.end())			// if u has not been visited
		{
			visited.emplace_back(u);				// append u to visited
			
			for (int j = G->n; j >0 ; j--)
				{
					if (V->edges[u][j])			// we start from j = n because its a stack, so it will alway start from the top
															// the probleme was that if a vertice has a least 2 edges, the second edge will come on the top of the stack
															// instead of the first one
					{
						S.push(j);							// I have to push the value of the vertice wich is edged , push J, value of the vertice
					}
				}
		}	
	}

	return visited;
}

list <int> BFS(MyGraph *G, Vertice *V)			//BREADTH FIRST SEARCH
{
	queue <int> Q;
	list<int> visited;
	Q.push(V->value);

	while (!Q.empty())
	{
		int u = Q.front();
		 Q.pop();
		 
		 if (find(visited.begin(), visited.end(), u) == visited.end())
		 {
			 visited.push_back(u);
			 
				 for (int j = 0; j < G->n; j++)
				 {
					 if (V->edges[u][j])						// it is a queue so the last element will be display in first 
					 {
						 Q.push(j);				
					 }
				 }				 
		 }
	}
	return visited;
}



int main()
{
	MyGraph *G = new MyGraph(10);
	
	Vertice *V1 = new Vertice(1);
	Vertice *V2 = new Vertice(2);
	Vertice *V3 = new Vertice(3);
	Vertice *V4 = new Vertice(4);
	Vertice *V5 = new Vertice(5);
	Vertice *V6 = new Vertice(6);
	Vertice *V7 = new Vertice(7);
	Vertice *V8 = new Vertice(8);
	Vertice *V9 = new Vertice(9);
	Vertice *V10 = new Vertice(10);

	V1->InitializationOfEdge(); 
	
	G->addVertex(1);
	G->addVertex(2);
	G->addVertex(3);
	G->addVertex(4);
	G->addVertex(5);
	G->addVertex(6);
	G->addVertex(7);
	G->addVertex(8);
	//G->addVertex(9);
	//G->addVertex(10);
	
	V1->addEdges(V1, V2);
	V1->addEdges(V1, V3);
	V1->addEdges(V3, V4);
	V1->addEdges(V3, V6);
	V1->addEdges(V6, V7);
	V1->addEdges(V6, V9);
	V1->addEdges(V4, V5);
	V1->addEdges(V4, V8);
	V1->addEdges(V8, V9);

	list<int> resultBFS = BFS(G, V1);
	list<int> resultDFS = DFS(G, V1);
	std::list<int>::const_iterator iterator;
	
	std::cout << "BFS" << std::endl;
	for (iterator = resultBFS.begin() = resultBFS.begin(); iterator != resultBFS.end(); iterator++)
		cout << *iterator << " ";
		
	std::cout << "" << std::endl;
	std::cout << "DFS" << std::endl;
	for (iterator = resultDFS.begin() = resultDFS.begin(); iterator != resultDFS.end(); iterator++)
		cout << *iterator << " ";

	//ofstream outputfile ("Data.txt");
	//outputfile.open("Data.txt");
	

	/*outputfile << "BFS" << std::endl;
	for (iterator = resultBFS.begin() = resultBFS.begin(); iterator != resultBFS.end(); iterator++)
		outputfile << *iterator << " ";

	outputfile << "" << std::endl;
	outputfile << "DFS" << std::endl;
	for (iterator = resultDFS.begin() = resultDFS.begin(); iterator != resultDFS.end(); iterator++)
		outputfile << *iterator << " ";
		*/	
		
	ofstream outputfile("Data.txt"); 
	if (outputfile.is_open())
	{
		
		cout << "File Opened successfully." << endl;

		for (int i = 0; i< 10; i++)
		{
			outputfile << i; 
		}
		cout << "Array data successfully saved" << endl;
	}
	else 
	{
		cout << "File could not be opened." << endl;
	}
    return 0;
}

/*
	class Vertice
		value
		edges[][] <- false

		Vertice(value)
			this.value <- value

		addEdges(V1,V2)
		edges[V1.value][V2.value] <-true;
		edges[V2.value][V1.value] <-true;

*	class MyGraph
			ArrayVertices <- []
			n <- number of vertices
			
			MyGraph(n)
				this.n <- n

			addVertice(VerticeValue)
				push(VerticeValue);
*/