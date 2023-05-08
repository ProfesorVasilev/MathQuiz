using System.Collections.Concurrent;
using System.Security.Cryptography;

int score = 0;
for (int i = 0; i < 10; i++)
{
    Random numberGenerator = new Random();
    int n1 = numberGenerator.Next(10, 100);
    int n2 = numberGenerator.Next(10, 100);
    int act = numberGenerator.Next(1, 4); //1+ 2- 3*
    switch (act)
    {
        case 1://+
            int sum = n1 + n2;
            Console.Write($"{n1} + {n2} = ");
            int guess1 = int.Parse(Console.ReadLine());
            if (guess1 == sum)
            {
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
                Console.WriteLine($"Wrong , the correct answer was {sum}");
            break;
        case 2:
            int diff = n1 - n2;
            Console.Write($"{n1} - {n2} = ");
            int guess2 = int.Parse(Console.ReadLine());
            if (guess2 == diff)
            {
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
                Console.WriteLine($"Wrong , the correct answer was {diff}");
            break;
        case 3:
            int mult1 = numberGenerator.Next(1, 12);
            int mult2 = numberGenerator.Next(1, 12);
            int result = mult1 * mult2;
            Console.Write($"{mult1} x {mult2} = ");
            int guess3 = int.Parse(Console.ReadLine());
            if (guess3 == result)
            {
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
                Console.WriteLine($"Wrong , the correct answer was {result}");
            break;
    }
}
if (score == 0)
{
    Console.WriteLine($"Your scored {score} / 10.");
    Console.Write("How could you be this dumb?");
}
else if (score > 0 && score <= 3)
{
    Console.WriteLine($"Your scored {score} / 10.");
    Console.Write("You definitely need more practice!");
}
else if (score > 3 && score <= 6)
{
    Console.WriteLine($"Your scored {score} / 10.");
    Console.Write("You're getting there!");
}
else if (score > 6 && score <= 9)
{
    Console.WriteLine($"Your scored {score} / 10.");
    Console.Write("Wow, good job!");
}
else if (score == 10)
{
    Console.WriteLine($"Your scored {score} / 10.");
    Console.Write("You're a genius!");
}
else
{
    Console.WriteLine("This isn't supposed to happen!!");
} 
