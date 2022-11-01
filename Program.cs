// Création calculatrice 



Console.WriteLine("Calculatrice\n");



// texte visuel
Console.WriteLine("Vous pouvez effectuer le calcul que vous souhaitez.\n");


// premier nombre
Console.Write("Premier chiffre de votre calcul: ");
int numberA = Convert.ToInt32(Console.ReadLine());

//opérateur demandé
Console.Write("\nOpérateur (+,-,*,/,^) : ");
string operateur = Console.ReadLine();

    

    if (operateur == "+")
    {
        Console.Write("\nDeuxième chiffre de votre calcul: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int result = numberA + numberB;
        Console.Write("\nResultats: ");
        Console.WriteLine(result);
        Console.Write("\n");
    }
    if (operateur == "-")
    {
        Console.Write("\nDeuxième chiffre de votre calcul: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int result = numberA - numberB;
        Console.Write("\nResultats: ");
        Console.WriteLine(result);
        Console.Write("\n");
    }
    if (operateur == "*")
    {
        Console.Write("\nDeuxième chiffre de votre calcul: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int result = numberA * numberB;
        Console.Write("\nResultats: ");
        Console.WriteLine(result);
        Console.Write("\n");
    }
    if (operateur == "/")
    {
        Console.Write("\nDeuxième chiffre de votre calcul: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int result = numberA / numberB;
        Console.Write("\nResultats: ");
        Console.WriteLine(result);
        Console.Write("\n");
    }
    if (operateur == "^")
    {
        Console.Write("\nPuissance: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        double result = Math.Pow(numberA, numberB);
        Console.Write("\nResultats: ");
        Console.WriteLine(result);
        Console.Write("\n");
    }

Console.Write("Voulez vous refaire un calcul?");

bool refaire = true;
bool arreter = true;

    if (refaire = )







