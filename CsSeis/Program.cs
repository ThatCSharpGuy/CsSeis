using System;
using static System.Console; // using static
using static System.Math; // using static

namespace CsSeis
{
    // Ideone http://ideone.com/h7T6f1
    class Program
    {
        static void Main(string[] args)
        {
            #region using static
            Console.WriteLine("using static:");

            // Sin "using static"
            var resultado1 = Math.Pow(2, 3);
            Console.WriteLine(String.Format("Resultado de resultado1 : {0}", resultado1));

            // C# 6 (¡No olvides agregar los "using static" correspondientes!):
            var resultado2 = Pow(2, 3);
            WriteLine(String.Format("Resultado de resultado2: {0}", resultado2));

            #endregion

            #region nameof
            Console.WriteLine("nameof:");

            // Sin nameof:
            WriteLine(String.Format("Resultado de resultado1 : {0}", resultado1));

            // C# 6:
            WriteLine(String.Format("Resultado de {1} : {0}", resultado1, nameof(resultado1)));

            #endregion

            #region String interpolation
            Console.WriteLine("String interpolation:");

            // Sin "string interpolation"
            WriteLine(String.Format("Resultado de {1} : {0}", resultado1, nameof(resultado1)));

            // C# 6:
            WriteLine($"Resultado de {nameof(resultado1)} : {resultado1}");

            #endregion


            #region Auto-property enhancements

            Person defaultPerson = new Person();
            Person juanito = new Person("Juan de la Barrera", 19);
            juanito.Parent = new Person("Pedro de la Barrera", 54);

            #endregion

            #region Expression bodies on method-like members

            WriteLine(defaultPerson.SayHi());

            WriteLine(juanito.SayHi(defaultPerson.Name));

            #endregion

            #region Null-conditional operators

            // Sin Null-conditional operators:
            //string defaultPersonParentName = null;
            //if(defaultPerson.Parent != null)
            //{
            //    defaultPersonParentName = defaultPerson.Parent.Name;
            //}

            // Con Null-conditional operators en C# 6:
            string defaultPersonParentName = defaultPerson.Parent?.Name;

            WriteLine($"Default person parent name: {defaultPersonParentName}");

            int? juanitosParentAge = juanito.Parent?.Age;

            WriteLine($"Juanito's parent age: {juanitosParentName}");

            #endregion

            Read();
        }
    }
}
