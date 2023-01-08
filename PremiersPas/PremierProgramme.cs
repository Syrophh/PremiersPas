using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiersPas
{
    class PremierProgramme
    {
        static String maVille;
        static void Main(string[] args)
        {
            String monNom = "Thomas";
            maVille = "La Seyne";
            Console.WriteLine("Bienvenue " + monNom + " dans l'univers C#");
            Console.WriteLine("Vous habitez à {0}", maVille);
            String[] lesNoms = new String[] { "Durand", "Dupont", "Martin", "Genton" };
            AfficheNoms(lesNoms);
            AfficheNomsV2(lesNoms);
            RemplirAfficherTableau();
            byte[] tablo = RemplirTableau(6);
            AfficherTableau(tablo);
            int somme = SommePair(tablo);
            Console.WriteLine("Somme des nombres pairs = {0:G}", somme);
        }

        private static byte[] RemplirTableau(int v)
        {
            throw new NotImplementedException();
        }

        static void AfficheNoms(string[] noms)
        {
            for(int i=0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }
            Console.WriteLine("---- Fin des noms ----");
        }
        static void AfficheNomsV2(String[] noms)
        {
            foreach(String unNom in noms)
            {
                Console.WriteLine(unNom);
            }
            Console.WriteLine("---- Fin des noms ----");
        }
        static void RemplirTableau(byte[] nombres)
        {
            var aleatoire = new Random();
            aleatoire.NextBytes(nombres);
        }
        static void AfficherTableau(byte[] tablo)
        {
            Console.WriteLine(tablo);
        }
        static void SommePair(byte[] tablo)
        {
            int somme = 0;
            for (int i=0; i < tablo.Length; i++)
            {
                if (tablo[i] % 2 == 0)
                {
                    somme += tablo[i];
                }
            }
        }
    }
}
