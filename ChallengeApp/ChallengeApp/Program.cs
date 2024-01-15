bool isWoman = true;
int age = 29;
string name = "Ewa";


if (isWoman  == true && age < 30)
{
    Console.WriteLine("KOBIETA PONIŻEJ 30 LAT");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("EWA, LAT 30");
}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("NIEPEŁNOLETNI MEZCZYZNA");
}   
else
{
    Console.WriteLine("KTOS INNY");
}