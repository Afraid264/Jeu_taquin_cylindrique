// echo.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;


int main()
{
	string s;
	while (cin.good()) {
		getline(cin, s);
		cout << s << endl;
	}
	return 0;
}

