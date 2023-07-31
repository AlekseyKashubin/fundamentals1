// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("loop that prints all values from 1-255");
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("loop that generates 5 random numbers between 10 and 20");
Random rand = new Random();
int sum = 0;
int random = 0;
for (int q = 1; q <= 5; q++)
{
    random = rand.Next(10, 21);
    Console.WriteLine("Random Number is : " + random);
    sum += random;
    Console.WriteLine("Total = " + sum);
}


Console.WriteLine("loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both");
for (int j = 1; j < 101; j++)

    if (j % 3 == 0 || j % 5 == 0)
    {
        Console.WriteLine(j);
    }


Console.WriteLine("Fizz or Buzz : ");
for (int x = 1; x < 101; x++)

    if (x % 3 == 0){
        Console.WriteLine("Fizz");
    }else if(x % 5 == 0){
        Console.WriteLine("Buzz");
    }else{
        Console.WriteLine(x);
    }



Console.WriteLine("Fizz Buzz FizzBuzz : ");
for (int z = 1; z < 101; z++)

    if (z % 3 == 0 && z % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }else if(z % 5 == 0){
        Console.WriteLine("Buzz");
    }else if(z % 3 == 0){
        Console.WriteLine("Fizz");
    }else{
        Console.WriteLine(z);
    }