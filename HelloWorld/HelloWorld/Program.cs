using System;
using h = System.Console;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1- Hello World");

        int nombre = 0;
        float nombreVirgule = 38.9f;
        string prenom;
        char lettre;
        bool vraiOuFaux = false;

        Console.WriteLine("2- Cinq nouvelles variables ont été définies.");

        Console.WriteLine("3- Saisissez un nombre et pressez la touche entrée, il sera enregistré dans la variable nombre :");
        nombre = int.Parse(Console.ReadLine());

        Console.WriteLine("4- Le nombre saisi est : {0} et le nombre à virgule est : {1}", nombre, nombreVirgule);

        if (nombre > nombreVirgule)
        {
            Console.WriteLine("5- Le nombre saisi est plus grand que le nombre à virgule");
        }
        else
        {
            Console.WriteLine("5- Le nombre saisi est plus petit que le nombre à virgule");
        }

        Console.WriteLine("6- Saisissez votre prénom et pressez la touche entrée, il sera enregistré dans la variable prenom :");
        prenom = Console.ReadLine();

        Console.WriteLine("7- Bonjour {0}", prenom);

        lettre = prenom[0];

        Console.WriteLine("8- Votre prénom commence par la lettre {0}", lettre);

        int i = 1;

        while (vraiOuFaux != true)
        {
            if (prenom.Length == nombre)
            {
                Console.WriteLine("9- Le nombre de lettre contenu dans votre prénom correspond à la valeur contenue dans la variable nombre");
                vraiOuFaux = true;
            }
            else
            {
                if (prenom.Length < nombre)
                    nombre--;
                else
                    nombre++;
                Console.WriteLine("9*-{0}- nombre = {1}", i, nombre);
            }

            i++;
        }

        Console.WriteLine("10- Après {0} passage(s) de boucle, le nombre correspond à la longueur du prénom", i - 1);
    }
}