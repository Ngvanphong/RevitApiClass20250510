// See https://aka.ms/new-console-template for more information
// day la dong code dau tien

/*thi is comment
 * this tishis 
 * this  is is 
 * this s s
 * this si command 2
 */


// this is 1111
// this is  isisi

using Lessson1;

#region b1

//using System.Runtime.Intrinsics.Arm;

///// this is mail 
/////



//int a = 8;
//int b = 20;
//int c;
//c = 20;
//int d = a + b;

//double g = (double)a / (double)b;

//int dividePercent = b % a;

//var e = 10;
//var name = "Phong";

//bool isTueday = true;

//bool isMonday;

//long f = 10L;

//uint numberUnit = 0;

//float numberFloat = 10.111f;
//double numberDouble = 10.555;

//decimal money = 10.3M;

//char textChar = 'a';

//string text = "Text 1000 000 \n Ththa ntntnt hhh";


//double number1 = 10.5;
//double number2 = 20.5;

//double number3 = number1 + number2;

//string textReult = $"{number1} + {number2}= {number3}";

//Console.WriteLine(textReult);

//bool isTrue = number1 > number2;
//isTrue = number1 == number2;
//isTrue = number1 < number2;
//isTrue = number1 != number2;

//double valueDouble = 10.5;
//valueDouble -= 10;
//bool isValid = true;
//isValid = !isValid;

//int add = 10;
//int result = 0;
//result += --add;
//Console.WriteLine(result);


//double value1 = 20;
//double value2 = 10;
//bool isValid2 = value1 > value2;

//string resultString = !isValid2 ? "Value 1 lon hon Value 1" : "Value 1 nho hon value 2";


//bool isValid3 = false;
//bool isValue4 = false;
//bool isValid5 = isValid3 || isValue4; // false;
//isValid5 = isValid3 && isValue4; // false;

//bool isResult = value1 > value2 || isValid3;



//double numberDouble2 = 100;

//double resultDouble;
//if (numberDouble2 < 20)
//{
//    resultDouble = 21;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}
//else if (numberDouble2 < 90)
//{
//    resultDouble = 90;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}
//else if (numberDouble2 > 200)
//{
//    resultDouble = 200;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}
//else
//{
//    resultDouble = 300;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}


//if (numberDouble2 < 300)
//{
//    resultDouble = 300;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}
//else
//{
//    resultDouble = 300;
//    Console.WriteLine($"Khoi lenh if {resultDouble} ");
//}


//int intValue = resultDouble > 400 ? -1 : -2;

//for (int i = 0; i < 5; i++)
//{
//    if (i > 2)
//    {
//        break;
//    }
//}
//for (int index = 0; index < 5; index += 2)
//{
//    Console.WriteLine(index);
//}

//for (int index = 0; index < 5; index += 2)
//{
//    if (index == 2)
//    {
//        continue;
//    }
//    Console.WriteLine(index);
//}

//for (int i = 0; i < 6; i++)
//{
//    for (int j = 1; j < 3; j++)
//    {
//        if (j == 1)
//        {
//            break;
//        }
//        Console.Write(j);
//    }
//}
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 1; j < 4; j++)
//    {
//        if (j == 3)
//        {
//            continue;
//        }
//        Console.Write(j);
//    }
//}


//bool isWhile = 20 > 10;
//int index2 = 2;
//while (isWhile)
//{
//    Console.WriteLine("1");
//    index2++;
//    if (index2 > 5)
//    {
//        break;
//    }
//}

//isWhile = false;
//do
//{
//    Console.WriteLine("1");
//    index2++;
//    if (index2 > 5)
//    {
//        isWhile = false;
//    }
//}
//while (isWhile);



//string today = "Sunday";
//switch (today)
//{
//    case "Monday":
//        {
//            Console.WriteLine($"Today is Monday");
//            break;
//        }
//    case "Teuday":
//        {
//            Console.WriteLine($"Today is Teuday");
//            break;
//        }
//    case "Thurday":
//    case "Wedsday":
//        {
//            Console.WriteLine($"Today is Wedsday");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine($"Today is Sunday");
//            break;
//        }

//}


//int[] arrayInt = new int[5];
//arrayInt[0] = 10;
//arrayInt[1] = 20;

//int firstValue = arrayInt[0];
//int secondValue = arrayInt[1];

//int[] arrayInt2 = { 10, 5, 7 };

//int countArray = arrayInt2.Length;

//int total = 0; // 
//for(int i = 0; i< arrayInt2.Length; i++)
//{
//    total+= arrayInt2[i]; 
//}
//total = 0;
//foreach(int valueItem in arrayInt2)
//{
//    total+= valueItem;
//}


//double[,] arrayTwoDimension = new double[3, 2];
//arrayTwoDimension[0, 0] = 10;
//arrayTwoDimension[0, 1] = 30;
//arrayTwoDimension[1, 0] = -10;

//double[,] arrayDimension2 = { { 10, 2 }, { 5, 7 }, { 3,7 } };

//double[][] jaggedArray = new double[2][];
//jaggedArray[0] = new double[3];
//jaggedArray[1] = new double[1];
//jaggedArray[0][2] = 20;
//jaggedArray[0][ 0] = -10;
//jaggedArray[0][ 1] = -30;
//jaggedArray[1][0] = 100;

//for(int indexParent = 0; indexParent < jaggedArray.Length; indexParent++)
//{
//    for(int indexChildren= 0; indexChildren< jaggedArray[indexParent].Length; indexChildren++)
//    {
//        Console.WriteLine(jaggedArray[indexParent][indexChildren]);
//    }
//}


//foreach (var parent in jaggedArray)
//{
//    foreach(var child in parent)
//    {

//    }
//}

//List<List<List<double>>> threeDimension = new List<List<List<double>>>();
//List<double> oneDimension = new List<double>();
//List<List<double>> twoDimension2 = new List<List<double>>();

//IList<double> listDouble= new List<double>();
//IEnumerable<double> iEnumberable;

#endregion

//Animal animal1 = new Animal(50, 4);
//Animal.CountInstance = 1;
//Animal.PrintInformation();
//double addResult = animal1.Add(1.5, 2.5, 2);
//double weighAnimal1 = animal1.WeightKg;

//Animal animal2 = new Animal();
//Animal.CountInstance = 2;
//animal2.WeightKg = 20;
//animal2.FootCount = 2;
//Animal.PrintInformation();

//int countInstance = Animal.CountInstance;


//TableInfomation table1 = new TableInfomation();
//table1.Length = 10;
//table1.Width = 4;
//table1.Name = "Table 1";
//double areaTable1 = table1.AreaCalculate();
//string table1Infomation = table1.Infomation();
//table1Infomation += "This is table 1";


//TableInfomation table2 = new TableInfomation();
//table2.Length = 5;
//table2.Width = 2;
//table2.Name = "Table 2";
//double areaTable2 = table2.AreaCalculate();

//Cat cat1= new Cat();
//cat1.WeightKg = 4;
//cat1.Name = "Black Cat";cat1.FootCount = 4;cat1.Color = "Black";
//cat1.CatInformation();
//double subtract1 = cat1.Subtract(10, 5);


//Dog dog1= new Dog();
//double subtract2= dog1.Subtract(7, 8);

//Student student1= new Student();
//student1.Infomation("St1", 1111, 15);

//Family famiy1 = new Family();
//famiy1.Address = "1111";
//famiy1.Count = 10;
//famiy1.SetInt();



Building building1= new Building();
building1.Street = "Nguyen huu canh";
building1.City = "HCM";
building1.PrintInformation();

Company company= new Company();
company.Street = " HHH";
company.City = "HN";
company.PrintInformation();
company.CityInfo();
company.CityInfo("Da nang");
company.CityInfo(1111);

Cat cat2= new Cat();




Wall wall = new Wall();
wall.Height = 100;
wall.Thickness = 10;
double height= wall.Height;

Chair chair1= new Chair();
chair1.Width = 100;

DayEnums today = DayEnums.Sunday;
if(today == DayEnums.Monday) 
{ 

}

string stringValue = "This is sunday - hhhh";
var listString= stringValue.Split('-',StringSplitOptions.RemoveEmptyEntries);




Circle circle1 = new Circle();
circle1.Name = " Circle 1";
circle1.Radius = 10;

Circle circle2 = new Circle();
circle2.Name = "Circle 2";
circle2.Radius = 3;

Circle subtractCircle = circle1 - circle2;

double radius = subtractCircle.Radius;
string name = subtractCircle.Name;



Circle circle3 = new Circle();
circle3.Name = " Circle 1";
circle3.Radius = 10;

Circle[] circleArray = new Circle[3];
circleArray[0] = circle1;
circleArray[1] = circle2;
circleArray[2] = circle2;

List<Circle> listCircle = new List<Circle>();
List<int> listInt= new List<int>(); 
List<double> listDouble = new List<double>();
listCircle.AddRange(new List<Circle> { circle1, circle2, circle3 });

listCircle= new List<Circle> { circle1, circle3, circle2 };

foreach(Circle circle in listCircle)
{

}

IList<Circle> listCircle2= new List<Circle>();
listCircle2.Add(circle1);
listCircle2.Add(circle2);
listCircle2.Add(circle3);

var value0= listCircle[0];

Circle newCircle;
double? doubleNull;


//revit.Document doc = null;

//IEnumerable<Wall> ienumerabeCircle = new revit.FilteredElementCollector(doc).OfClass(typeof(revit.Wall))
//    .Cast<Wall>();

ICollection<Circle> colleciton2;

Element<double> elementDouble = new Element<double>();
elementDouble.ListElements = new List<double>();
elementDouble.ListElements.Add(102.2);
elementDouble.ListElements.Add(105.2);


Element<int> elementInt = new Element<int>();
elementInt.ListElements = new List<int>();
elementInt.ListElements.Add(102);
elementInt.ListElements.Add(102);

Element<Circle> elementCircle = new Element<Circle>();
elementCircle.ListElements = new List<Circle>();
elementCircle.ListElements.Add(circle1);
elementCircle.ListElements.Add(circle2);



List<List<Circle>> listListCircle = new List<List<Circle>>();

 foreach(List<Circle> parent in listListCircle)
{
    foreach(Circle child in parent)
    {

    }
}









// 

Animal an1 = new Animal();

Cat cat1= new Cat();

Dog dog1 = new Dog();



Animal animalFromCat= cat1 as Animal;



string valueString = "10rr";

int valueInt = 0;
bool isSuccess= int.TryParse(valueString, out valueInt);
if (isSuccess)
{

}

//int valueInt= int.Parse(valueString);

//double valueDouble= double.Parse(valueString);


Wall wall3 = new Wall();
wall3.Height = 10;
wall3.Thickness = 10;
double volume = 0;
double area = 0;
wall3.Volume(1000, out volume, out area);

List<Circle> listRefCircle = new List<Circle>();
wall3.AddList(new List<Circle>(listRefCircle));


double areaRef = 2;
wall3.Area(10,ref areaRef);


int int333 = 4;