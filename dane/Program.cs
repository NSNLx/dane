using System;


//1
/*
string Imie = "Aleksander";
string Nazwisko = "W";
int Wiek = 19;
char Plec= 'm';
string PESEL = "12345678900";
int IdPracownika = 0;
*/
//2
char pierwsza = Convert.ToChar("a");
char druga = Convert.ToChar("b");
char trzecia = Convert.ToChar("c");

Console.WriteLine(trzecia);
Console.WriteLine(druga);
Console.WriteLine(pierwsza);
//3
Console.WriteLine("podaj długość a prostokąta: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("podaj długość b prostokąta: ");
double b = Convert.ToDouble(Console.ReadLine());
double b2 = Math.Pow(b, 2);
double a2 = Math.Pow(a, 2);

Console.WriteLine("Długość przekątnej prostokąta to: "+Math.Pow(a2 + b2,0.5));
//4
int liczba = 10;
string str = "Szkoła Dotneta";
double zmiennoprzecinkowa =12.5;
//5
Console.WriteLine("podaj nazwisko");
string nazwisko=Console.ReadLine();
Console.WriteLine("podaj numer telefonu");
string numer= Console.ReadLine();
Console.WriteLine("podaj wiek");
string wiek=Console.ReadLine();
Console.WriteLine("podaj wzrost");
string wzrost= Console.ReadLine();

int.Parse(numer);
int.Parse(wiek);
double.Parse(wzrost);


