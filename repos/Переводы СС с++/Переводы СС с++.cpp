// Переводы СС с++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cstdlib>
#include <string>
#include <cmath>
#include <algorithm>
using namespace std;

string ToTen(string number, int st)
{
	int tempresult = 0;
	for (int i = 0; i < number.length(); i++)
	{
		if (number[i] == 'A')
		{
			tempresult = tempresult + 10 * pow(st, number.length() - i - 1);
		}
		else if (number[i] == 'B')
		{
			tempresult = tempresult + 11 * pow(st, number.length() - i - 1);
		}
		else if (number[i] == 'C')
		{
			tempresult = tempresult + 12 * pow(st, number.length() - i - 1);
		}
		else if (number[i] == 'D')
		{
			tempresult = tempresult + 13 * pow(st, number.length() - i - 1);
		}
		else if (number[i] == 'E')
		{
			tempresult = tempresult + 14 * pow(st, number.length() - i - 1);
		}
		else if (number[i] == 'F')
		{
			tempresult = tempresult + 15 * pow(st, number.length() - i - 1);
		}
		else tempresult = tempresult + (number[i] - '0') * pow(st, number.length() - i - 1);
	}
	return to_string(tempresult);
}
string FromTen(string number, int stnew)
{
	string tempresult1 = "";
	int tempnumber = stoi(number);
	for (int i = 0; i < number.length(); i++)
	{
		tempresult1 = tempresult1 + to_string(tempnumber % stnew);
		tempnumber = tempnumber / stnew;
	}
	reverse(tempresult1.begin(), tempresult1.end());
	return tempresult1;
}
int main()
{
	setlocale(LC_ALL, "Russian");
	int a, b = 0, k = 1, st, stnew;
	string result = "";
	int tempresult = a;
	cout << "Введите число: ";
	cin >> a;
	cout << "Введите систему текущую счисления:";
	cin >> st;
	cout << "Введите новую систему счисления:";
	cin >> stnew;
	result = FromTen(ToTen(to_string(a), st), stnew);
	cout << result;
	return 0;
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
