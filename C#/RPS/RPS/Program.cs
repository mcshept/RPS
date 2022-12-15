String[] options = {"Rock", "Paper", "Scissors"};
Random random = new Random();
int i = random.Next(options.Length);

Console.WriteLine("Computer has chosen");
Console.WriteLine("Enter your choice: ");

string userChoice = Console.ReadLine();
switch (options[i])
{
    case "Rock":
        switch (userChoice)
        {
            case "Rock":
                Console.WriteLine("Computer has chosen Rock");
                Console.WriteLine("Draw");
                break;
            case "Paper":
                Console.WriteLine("Computer has chosen Rock");
                Console.WriteLine("You won!");
                break;
            case "Scissors":
                Console.WriteLine("Computer has chosen Rock");
                Console.WriteLine("You lost!");
                break;
            default:
                Console.WriteLine("This is not a valid option");
                Console.WriteLine("Please choose Rock, Paper or Scissors");
                break;
        }
        break;
    case "Paper":
        switch (userChoice)
        {
            case "Rock":
                Console.WriteLine("Computer has chosen Paper");
                Console.WriteLine("You lost!");
                break;
            case "Paper":
                Console.WriteLine("Computer has chosen Paper");
                Console.WriteLine("Draw");
                break;
            case "Scissors":
                Console.WriteLine("Computer has chosen Paper");
                Console.WriteLine("You won!");
                break;
            default:
                Console.WriteLine("This is not a valid option");
                Console.WriteLine("Please choose Rock, Paper or Scissors");
                break;
        }
        break;
    case "Scissors":
        switch (userChoice)
        {
            case "Rock":
                Console.WriteLine("Computer has chosen Scissors");
                Console.WriteLine("You won!");
                break;
            case "Paper":
                Console.WriteLine("Computer has chosen Scissors");
                Console.WriteLine("You lost!");
                break;
            case "Scissors":
                Console.WriteLine("Computer has chosen Scissors");
                Console.WriteLine("Draw");
                break;
            default:
                Console.WriteLine("This is not a valid option");
                Console.WriteLine("Please choose Rock, Paper or Scissors");
                break;
        }
        break;
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();