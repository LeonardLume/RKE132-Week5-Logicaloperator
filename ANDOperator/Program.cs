//Math -= 90; Biology >=90, Chemisrty >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology resultL");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemisty results:");
chemistry = Int32.Parse(Console.ReadLine());


if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You got accepted");

}
else
{
    Console.WriteLine("Your application cannot be approved");
}

