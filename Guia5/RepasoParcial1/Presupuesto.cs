using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial1
{
    public class Presupuesto
    {

        public double Precio { get; set; }

        ArrayList listaProductos = new ArrayList();

        private Cliente solicitante;

        public Presupuesto(string nombre, string direccion)
        {

            solicitante = new Cliente(nombre, direccion);

        }

        public void AgregarProducto(Producto unProducto)
        {

            listaProductos.Add(unProducto);

        }

        private Producto BuscarProducto(int codigo)
        {

            listaProductos.Sort();

            // algoritmo busqueda binaria

            int inf = 0, sup = listaProductos.Count - 1;
            int centro = (inf + sup) / 2;

            while (inf <= sup)
            {

                Producto prueba = listaProductos[centro] as Producto;

                if (prueba == null) return null;
                {

                    if (prueba.Codigo == codigo) return prueba;
                    else if (codigo < prueba.Codigo) sup = centro - 1;
                    else inf = centro + 1;

                    centro = (inf + sup) / 2;



                }
            }
            return null;
            //alternativa 2: usando .binarysearch() 
        }

        public bool QuitarProducto(int codigo) 
        {

            Producto buscado = BuscarProducto(codigo);

            if (buscado != null) 
            {
            
                listaProductos.Remove(buscado);
                return true;

            }

            return false;
        
        }

        public string[] Resumen() 
        {

            string[] resultado = new string[listaProductos.Count + 2];

            int n = 0;
            resultado[n++] = solicitante.ToString();
            foreach (Producto p in listaProductos) 
            {

                resultado[n++] = $"{p.Codigo} -Peso: {p.Peso()} - Precio: ${p.Precio()}";

            }

            resultado[n++] = $"{Precio}";
            return resultado;
        
        }


    }
}
