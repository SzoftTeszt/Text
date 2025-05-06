// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string szoveg1 = "Almafa12;";
string szoveg2 = "Almafa12;";

if (szoveg1.Equals(szoveg2))
    Console.WriteLine("Egyenlőek");

int[] t1 = { 1, 2, 3 };
int[] t2 = { 1, 2, 3 };

if (t1 == t2)
    Console.WriteLine("Tömbök Egyenlőek");
else Console.WriteLine("A tömbök nem egyenlőek");

string s1 = "";
s1 = null;
s1 = "SzoftI/K";
s1 = s1 + s1;
s1 += " Cica";
Console.WriteLine(s1); 
Console.WriteLine(s1.Length);
Console.WriteLine(s1[20]);
//s1[20] = '§';
s1 = "0123456789";
Console.WriteLine(s1.Remove(3,2));
Console.WriteLine(s1.Substring(3,2));
s1 = s1.Insert(3, "\talma\n".TrimEnd([ 'a','\n'] ) ) ;
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1);
Console.WriteLine(s1.IndexOf("alm"));

string sor = "Ez egy sor egy versből!";
var szavak = sor.Split(' ');

Console.WriteLine(szavak.ToString());

for (int i = 0; i < szavak.Length; i++)
{
    Console.Write(szavak[i] + "; ");
}
Console.WriteLine();

foreach (var szo in szavak) Console.Write(szo + ", ");
Console.WriteLine();

Console.WriteLine(String.Join(": ",szavak));

var charTomb= s1.ToCharArray();
charTomb[0] = 'B';
Console.WriteLine("CharTömb: "+String.Join("",charTomb));