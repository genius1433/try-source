#include <iostream>
#include <cstdlib>
#include <string>
#include <cmath>
#include <algorithm>
using namespace std;
 string  ToTen(string number, int st)
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
	int b = 0, k = 1, st, stnew;
	string a = "";
	string result = "";
	int tempresult = atoi(a.c_str());;
	cout << "Введите число: ";
	cin >> a;
	cout << "Введите систему текущую счисления:";
	cin >> st;
	cout << "Введите новую систему счисления:";
	cin >> stnew;
	result = FromTen(ToTen(a, st), stnew);
	cout << result;
	return 0;
}
