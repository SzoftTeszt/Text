string[] szavak= { "törpe", "pálinka", "bor", "sör", "nyuszi", "cica" };
Random rnd = new Random();

Char[] kitalalando= szavak[rnd.Next(0,szavak.Length)].ToCharArray();

Char[] kitalalt = new char[kitalalando.Length];
for (int i = 0; i < kitalalt.Length; i++) kitalalt[i] = '*'; 

int maxTipp = kitalalando.Length + 2;
int tippSzam = 0;
do
{
    Console.WriteLine("\n"+string.Join(" ", kitalalt));
    Console.Write("Tippelj egy betűt: ");
    var tipp = Console.ReadKey().KeyChar;
    tippSzam++;
    char[] ujKitalalt = new char[kitalalt.Length];
    for (int i = 0; i < kitalalando.Length; i++)
    {
        if (kitalalando[i] == tipp)
        {
            kitalalt[i] = tipp;
        }
    }
}
while ((tippSzam<=maxTipp) && (String.Join("",kitalalando) != String.Join("",kitalalt)) );

if (String.Join("", kitalalando) == String.Join("", kitalalt))
    Console.WriteLine("Kitaláltad! Ügyes vagy!");
else
    Console.WriteLine("Sajnos ez most nem sikerült!");

Console.WriteLine("Még egy játék (i/n)?");

