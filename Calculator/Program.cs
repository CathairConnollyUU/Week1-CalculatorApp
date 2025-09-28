//Varible names should be short yet meaningful
//The choice of a varibel name should be mnemonic- this is,
//designed to indicate to the casual observer the intent of its use.

//This integer varible stores the first number
//Ask the user to input the first number
Console.WriteLine("Type in the first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//Ask the user to input the second number
Console.WriteLine("Type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Perform Calculation
int result = firstNumber +  secondNumber;

//Output the answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
