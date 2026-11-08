using Proyecto_1_Cinica;
using System;

namespace Proyecto1_Clinica
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;
        public Cola()
        {
            frente = null;
            final = null;
        }
        public void Encolar(Paciente paciente)
        {
            Nodo nuevo = new Nodo(paciente);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Sigiente = frente;
                final = nuevo;
            }
        }
        public Paciente Desencolar()
        {
            if (frente == null)
                return null;
            Paciente paciente = frente.Datos;
            if (frente == null)
                final = null;
            return paciente;
        }

        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay paciente registrado.");
                return;
            }
            Nodo aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Sigiente;
            }
        }
    }
}