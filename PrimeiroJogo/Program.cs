void LogotypeMenu()
{
    string massageTitle = "E aí? Beleza? Venha jogar meu primeiro jogo em C#: Advinhe o número, se for capaz! (Muahaha)!";
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░█████╗░██╗░░██╗░█████╗░██╗░░██╗░█████╗░██╗░░██╗░█████╗░██╗
████╗░████║██║░░░██║██╔══██╗██║░░██║██╔══██╗██║░░██║██╔══██╗██║░░██║██╔══██╗██║
██╔████╔██║██║░░░██║███████║███████║███████║███████║███████║███████║███████║██║
██║╚██╔╝██║██║░░░██║██╔══██║██╔══██║██╔══██║██╔══██║██╔══██║██╔══██║██╔══██║╚═╝
██║░╚═╝░██║╚██████╔╝██║░░██║██║░░██║██║░░██║██║░░██║██║░░██║██║░░██║██║░░██║██╗
╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝");
    Console.WriteLine(massageTitle);

}

Random aleatory = new Random();
int secretNumber = aleatory.Next(1, 20);

void DisplayChallenge()
{

    do
    {

        Console.Write("\nDigite um número que esteja passando pela sua mente, mas é de 1 a 20: ");
        int guess = int.Parse(Console.ReadLine()!);
        if (guess == secretNumber)
        {
            Console.WriteLine("Ok Ok, você acertou, mas estava esperando que NÃO! Congratulations :) !");
            break;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Ouw, da um jeito aí, o número é maior!");
        }
        else
        {
            Console.WriteLine("Vishi heih, quer uma ajudinha? O número é menor!");
        }

    } while (true);

}

LogotypeMenu();
DisplayChallenge();
