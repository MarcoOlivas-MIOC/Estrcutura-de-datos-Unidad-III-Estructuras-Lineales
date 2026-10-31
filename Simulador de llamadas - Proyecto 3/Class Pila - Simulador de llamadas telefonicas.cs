using System;

namespace Proyecto3_Llamadas
{
    public class Pila
    {
        private Nodo tope;

        private class Nodo
        {
            public string Datos;
            public Nodo Siguiente;

            public Nodo(string datos)
            {
                Datos = datos;
            }
        }

        public void Apilar(string llamada)
        {
            Nodo nuevo = new Nodo(llamada);
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        public string Desapilar()
        {
            if (tope == null)
            {
                return null;
            }

            string llamada = tope.Datos;
            tope = tope.Siguiente;
            return llamada;
        }

        public void Mostrar()
        {
            Nodo actual = tope;
            while (actual != null)
            {
                Console.WriteLine(actual.Datos);
                actual = actual.Siguiente;
            }
        }

       
        public string RecuperarUltimaLlamada()
        {
            if (tope == null)
            {
                return null;
            }
            return tope.Datos;
        }

       
        public bool BuscarLlamada(string llamada)
        {
            Nodo actual = tope;
            while (actual != null)
            {
                if (actual.Datos.Equals(llamada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

      
        public bool EliminarLlamada(string llamada)
        {
            if (tope == null) return false;

            if (tope.Datos.Equals(llamada, StringComparison.OrdinalIgnoreCase))
            {
                tope = tope.Siguiente;
                return true;
            }

            Nodo actual = tope;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Datos.Equals(llamada, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }

            return false;
        }

      
        public void RegistrarCliente(string cliente)
        {
            Apilar("Cliente: " + cliente);
        }
    }
}