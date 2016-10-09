using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoDelegate
{
    class Calcul
    {
        public static int somme(int a, int b)
        {
            return a + b;
        }
        public static int produit(int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {
        public delegate int OperationMathematique(int a, int b);
        private static int ExecuterOperationMathematique(OperationMathematique operationAeffectuer, int a, int b)
        {
            return operationAeffectuer(a, b);
        }
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("premier nb svp:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("deuxième nb svp:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quelle operation '+' ou '*':");
            char choix = (char)Console.Read();
            switch (choix)
            {
                case '+':
                    { result = ExecuterOperationMathematique(Calcul.somme,n1, n2); break; }
                case '*':
                    { result = ExecuterOperationMathematique(Calcul.produit, n1, n2); break; }
            }
            Console.WriteLine("resultat:" + result.ToString());
            Console.ReadLine();
            Console.ReadLine();
        }
       
    }
}
