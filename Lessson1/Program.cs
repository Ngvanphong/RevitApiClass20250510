// See https://aka.ms/new-console-template for more information
// day la dong code dau tien

/*thi is comment
 * this tishis 
 * this  is is 
 * this s s
 * this si command 2
 */


// this is 1111

using System.Runtime.Intrinsics.Arm;

/// this is mail 
///
Console.WriteLine("Hello, World!");


int a = 8;
int b = 20;
int c;
c = 20;
int d = a + b;

double g = (double)a / (double)b;

int dividePercent = b % a;

var e = 10;
var name = "Phong";

bool isTueday = true;

bool isMonday;

long f = 10L;

uint numberUnit = 0;

float numberFloat = 10.111f;
double numberDouble = 10.555;

char textChar = 'a';

string text = "Text 1000 000 \n Ththa ntntnt hhh";


double number1 = 10.5;
double number2 = 20.5;

double number3 = number1 + number2;

string textReult = $"{number1} + {number2}= {number3}";

Console.WriteLine(textReult);

bool isTrue = number1 > number2;
isTrue = number1 == number2;
isTrue = number1 < number2;
isTrue = number1 != number2;

double valueDouble = 10.5;
valueDouble -= 10;
bool isValid = true;
isValid = !isValid;

int add = 10;
int result = 0;
result += --add;
Console.WriteLine(result);


double value1 = 20;
double value2 = 10;
bool isValid2 = value1 > value2;

string resultString = !isValid2 ? "Value 1 lon hon Value 1" : "Value 1 nho hon value 2";


bool isValid3 = false;
bool isValue4 = false;
bool isValid5 = isValid3 || isValue4; // false;
isValid5 = isValid3 && isValue4; // false;

bool isResult = value1 > value2 || isValid3;



double numberDouble2 = 100;

double resultDouble;
if (numberDouble2 < 20)
{
    resultDouble = 21;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}
else if (numberDouble2 < 90)
{
    resultDouble = 90;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}
else if (numberDouble2 > 200)
{
    resultDouble = 200;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}
else
{
    resultDouble = 300;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}


if (numberDouble2 < 300)
{
    resultDouble = 300;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}
else
{
    resultDouble = 300;
    Console.WriteLine($"Khoi lenh if {resultDouble} ");
}


int intValue = resultDouble > 400 ? -1 : -2;

for (int i = 0; i < 5; i++)
{
    if (i > 2)
    {
        break;
    }
}
for (int index = 0; index < 5; index += 2)
{
    Console.WriteLine(index);
}

for (int index = 0; index < 5; index += 2)
{
    if (index == 2)
    {
        continue;
    }
    Console.WriteLine(index);
}

for (int i = 0; i < 6; i++)
{
    for (int j = 1; j < 3; j++)
    {
        if (j == 1)
        {
            break;
        }
        Console.Write(j);
    }
}
for (int i = 0; i < 6; i++)
{
    for (int j = 1; j < 4; j++)
    {
        if (j == 3)
        {
            continue;
        }
        Console.Write(j);
    }
}


bool isWhile = 20 > 10;
int index2 = 2;
while (isWhile)
{
    Console.WriteLine("1");
    index2++;
    if (index2 > 5)
    {
        break;
    }
}

isWhile = false;
do
{
    Console.WriteLine("1");
    index2++;
    if (index2 > 5)
    {
        isWhile = false;
    }
}
while (isWhile);



string today = "Sunday";
switch (today)
{
    case "Monday":
        {
            Console.WriteLine($"Today is Monday");
            break;
        }
    case "Teuday":
        {
            Console.WriteLine($"Today is Teuday");
            break;
        }
    case "Wedsday":
        {
            Console.WriteLine($"Today is Wedsday");
            break;
        }
    default:
        {
            Console.WriteLine($"Today is Sunday");
            break;
        }

}


int[] arrayInt = new int[5];
arrayInt[0] = 10;
arrayInt[1] = 20;

int firstValue = arrayInt[0];
int secondValue = arrayInt[1];

int[] arrayInt2 = { 10, 5, 7 };

int countArray = arrayInt2.Length;

int total = 0; // 
for(int i = 0; i< arrayInt2.Length; i++)
{
    total+= arrayInt2[i]; 
}
total = 0;
foreach(int valueItem in arrayInt2)
{
    total+= valueItem;
}


double[,] arrayTwoDimension = new double[3, 2];
arrayTwoDimension[0, 0] = 10;
arrayTwoDimension[0, 1] = 30;
arrayTwoDimension[1, 0] = -10;

double[,] arrayDimension2 = { { 10, 2 }, { 5, 7 }, { 3,7 } };

double[][] jaggedArray = new double[2][];
jaggedArray[0] = new double[3];
jaggedArray[1] = new double[1];
jaggedArray[0][2] = 20;
jaggedArray[0][ 0] = -10;
jaggedArray[0][ 1] = -30;
jaggedArray[1][0] = 100;








