using Proyecto4_Calculadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_4_Calculadora
{
    internal class Program
    {
        static int Prioridad(char operador)
        {
            if (operador == '+' || operador == '-')
                return 1;

            if (operador == '*' || operador == '/')
                return 2;

            if (operador == '^')
                return 3;
        }

        static string InfijaAPostfija(string expresion)
        {
            Pila pila = new Pila();
            string salida = "";


            foreach (char caracter in expresion)
            {
                if (char.IsDigit(caracter))
                {
                    salida += caracter;
                }
                else if (caracter == '(')
                {
                    pila.Apilar(caracter);
                }
                else if (caracter == ')')
                {
                    while (!Pila.Vacia() && pila.Tope() != '(')
                    {
                        salida += pila.Desapilar();
                    }

                    pila.Desapilar();
                }
                else if ("+-*/".Contains(caracter))
                {
                    while (!pila.Vacia() && Prioridad(pila.Tope()) >= Prioridad(caracter))
                    {
                        salida += pila.Desapilar();
                    }

                    pila.Apilar(caracter);
                }
            }

            while (!pila.Vacia())
                salida += pila.Desapilar();

            return salida;
        }

        static void Main()
        {
            Console.WriteLine("===CALCULADORA===");

            Console.Write("Exprecion.");
            string exprecion = Console.ReadLine();

            string postfija = InfijaAPostfija(exprecion);

            Console.WriteLine($"Postfija: {postfija}");

            Console.ReadKey();
        }
    }
}