// Tree_sort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <stack>
using namespace std;

class BinTreeNode{
public:
	BinTreeNode(int value){
		this->value = value;
		this->left = NULL;
		this->right = NULL;
	}
	int value;
	BinTreeNode* left;
	BinTreeNode* right;

};

BinTreeNode* tree_insert(BinTreeNode* tree, int item){
	if (tree == NULL)
		tree = new BinTreeNode(item);
	else
		if (item < tree->value)
			if (tree->left == NULL)
				tree->left = new BinTreeNode(item);
			else
				tree_insert(tree->left, item);
		else
			if (tree->right == NULL)
				tree->right = new BinTreeNode(item);
			else
				tree_insert(tree->right, item);
	return tree;

}

void postorder(BinTreeNode* tree){
	if (tree->left != NULL)
		postorder(tree->left);
	if (tree->right != NULL)
		postorder(tree->right);
	std::cout << tree->value << std::endl;

}

/*void in_order(BinTreeNode* tree){
	if (tree->left != NULL)
		in_order(tree->left);
	std::cout << tree->value << std::endl;
	if (tree->right != NULL)
		in_
		order(tree->right);
}
*/

void in_order(BinTreeNode* tree)
{

	stack <BinTreeNode*> s  ;
	s.push(tree);
	//tree = tree->left;

	while (!s.empty())			// we go throw the stack until it gets empty
	{
		if (tree->left != NULL)		// then we check the left node
		{
			s.push(tree);			// if its not NULL we add it to the top of the stack
			tree = tree->left;		// And we say that the new node is the left one
		}
		else  if(tree->left == NULL)
		{							// if the left node is empty, then we display the node value
			s.push(tree);
			std::cout << s.top()->value << std::endl;
			s.pop();
			
			if (tree->right != NULL)
			{
				tree = tree->right;
			}
			else 
			{
				tree->value = s.top()->value;
				std::cout << s.top()->value << std::endl;
				s.pop();
			
			}
			
			
			// And tell to check the same on the right node
		}
		
		
	}
}

int main(int argc, char *argv[])
{
	BinTreeNode* t = tree_insert(0, 6);
	tree_insert(t, 10);
	tree_insert(t, 5);
	tree_insert(t, 2);
	tree_insert(t, 3);
	tree_insert(t, 4);
	tree_insert(t, 11);
	in_order(t);
	//postorder(t);
	return 0;
}

