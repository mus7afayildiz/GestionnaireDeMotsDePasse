/// ETML
/// Auteur: Mustafa Yildiz
/// Date:   mardi 19 Mars 2024
/// Lie:    Vennes
/// Description: Concevoir un gestionnaire de mot de passe local qui permet de 
/// sauvegarder de manière sécurisée le site Internet, le nom d’utilisateur et le 
/// mot de passe.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeMotsDePasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password(pass);
            if (password.)
            { 
            
            
            }
            Console.WriteLine("Saisir un Master Password");
            string pass = Console.ReadLine();
            Password password = new Password(pass);
            
            Show();


        }


        /// <summary>
        /// Permet d'affichage introduction et choisir les menus
        /// </summary>
        private static void Show()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Sélectionnez une action");
            Console.WriteLine("1. Consulter un  mot de passe ");
            Console.WriteLine("2. Ajouter un mot de passe");
            Console.WriteLine("3. Suprimer un mot de passe");
            Console.WriteLine("4. Quitter le programme");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************\n");
            Console.Write("Faites votre choix : ");
            Console.ReadLine();
        }

        private static void CheckPassword(string password)
        {
            
        
        
        
        }
    }
}
