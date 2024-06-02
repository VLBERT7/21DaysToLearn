//var od wieku i liczby calkowite!

int myAge = 2137;
int myAge2 = myAge + 777;
Console.WriteLine(myAge2);
int myVar = -123;
uint  myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue;
long myVar4 = long.MinValue;

// liczby po przecinku min do max Value
float myNumberComa = float.MaxValue;
double  myNumberComa2 = double.MaxValue;    
decimal myNumberComa3 = decimal.MaxValue;

//teskt - zmienne stringi
string name = " Albi ";
string surname = " Kulawik ";
string result = name + surname;
Console.WriteLine(result);

string result2 = surname + myVar;
Console.WriteLine(result2);

//zmienne chary mary

char myVar5  = 'a';
char myVar6 = 'b';
char myVar7 = 'c';

var result3 = name.ToArray();

Console.WriteLine(result3);

// zmienna t lub n
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);


//if i podstawy

var number1 = 512313123213;
var number2 = 1012451234;
if(number1 > number2)
{
    Console.WriteLine("Dzien dobry polsko, witamy ponizej 47 linijki!");
}
else
{
    Console.WriteLine("Teraz jestem w linii 52 bruh!");
}