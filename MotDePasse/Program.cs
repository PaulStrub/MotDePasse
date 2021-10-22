using System;

namespace MotDePasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Worlddddddddddd ! comment ca va toi ? Moi ca va bon aujourd'hui on est la pour te faire un mot de passe tu veux combien de caractères ?");
            int nbCar = NbCarChoice();
            Console.WriteLine("OKKKAYYYYY let's goooo tu veux quoi comme type de mot de passe maintenant ?");
            Console.WriteLine("1  -  Uniquement des caractères en minuscule");
            Console.WriteLine("2  -  caractères en majuscule et minuscule");
            Console.WriteLine("3  -  caractères et chiffres");
            Console.WriteLine("4  -  la total chef salade, tomates, oignons");
            Console.Write("Votre choix : ");
            int choix = NbCarChoice(); 
            
        }

        static int NbCarChoice()
        {
            try
            {
                int res = int.Parse(Console.ReadLine());
                return (res);
            }
            catch
            {
                Console.WriteLine("ERROR ERROR, un nombre est demandé s'il te plaît");
                return NbCarChoice();
            }
        }       


    }
}
