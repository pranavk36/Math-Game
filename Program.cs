Console.WriteLine("Enter Name: ");
string name = Console.ReadLine();

Console.WriteLine($"Hello {name}! We are learning C# basics /n");
Console.WriteLine("/n");
Console.WriteLine("This is a Math Game, To learn and understand Core C# Concepts /n");
Console.WriteLine(@$"Please Select an Option: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quitting The Game");

var GameSelected = Console.ReadLine();

 switch(GameSelected){
case  "a": 
Additiongame();
break;
case  "s": 
SubtractionGame();
break;
case  "m": 
MultiplicationGame();
break;
case  "d": 
DivisionGame();
break;
case  "q": 
Console.WriteLine("Good Bye");
Environment.Exit(1);
break;
 }

 void Additiongame(){};
 void SubtractionGame(){};
 void MultiplicationGame(){};
 void DivisionGame(){};