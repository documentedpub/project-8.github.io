Random dice = new();  // instance of a class <class>
int roll1 = dice.Next(1,7); // method calling <method>
int roll2 = dice.Next(1,7); // 7 is the exclusive upper bound
int roll3 = dice.Next(1,7);
roll1 = 0;
roll2 = 1;
roll3 = 2;
int  total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1==roll2) || (roll1 == roll3) || (roll2==roll3))
{
    if ((roll1==roll2) && (roll2==roll3)) // The second if executes the else branch
    { // roll1 == roll3 by subtraction >> math roll1-roll2 = 0, and roll2-roll3 = 0, so roll1 - roll3 = 0+0 = 0 means equal to each others
    Console.WriteLine("You rolled Triples! +6 bonus to total");
    total+=6;
    }
    else
    {
        Console.WriteLine("You rolled Doubles! +2 bonus to total!");
        total+=2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
    
}


if (total >= 16) // if keyword + boolean expression
{
    Console.WriteLine("You win a new car!"); // code block
}
else if (total >= 10)
{
    Console.WriteLine($"You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine($"You win a trip for two!");
}
else
{
    Console.WriteLine($"You win a kitten!");
}
