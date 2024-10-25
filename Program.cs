
System.Console.Write("Lets play 'Rock, Paper & Scissors, press y/n 🤺⚔️😎: ");

string? userChoice = Console.ReadLine();
string[] autChoice = {"Rock", "Paper", "Scissor"};
int lives = 3;


if(userChoice == "y"){
        Console.Clear();
        // System.Console.WriteLine(autChoice[index]);


    while(true) {
        Random random = new Random();
        int index = random.Next(autChoice.Length);
        System.Console.Write("Pick your weapon: ");
        // System.Console.WriteLine(index);
        string? weaponChoice = Console.ReadLine();
        string? userLower = weaponChoice?.ToLower();
        string? computerLower = autChoice[index].ToLower();
  
        if(userLower == "rock" && computerLower == "paper" 
        || userLower == "paper" && computerLower == "rock" 
        || userLower == "scissor" && computerLower == "rock" 
        || userLower == "paper" && computerLower == "scissor" ) {
            ErrorLine($"You Lost, the computer chose {computerLower}!");
            Console.ResetColor();
            lives--;
            
            if (lives <= 0) {
                System.Console.WriteLine("Game over, you lost!🦴");
                Console.ResetColor();
                break;
            }
            continue;
            
        } else if (userLower == computerLower) {
            TieLine("Its a Tie! 👔");
            Console.ResetColor();
            continue;
        } else if (string.IsNullOrEmpty(userLower)){
            ErrorLine("Cannot be empty, choose a weapon please!");
            Console.ResetColor();
            continue;
        } else {
            WinLine("You won! 🤺");
            Console.ResetColor();
            break;
        }

    }

}

static void ErrorLine(string message = "") {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
}

static void WinLine(string message ="") {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
}

static void TieLine(string message ="") {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
}
