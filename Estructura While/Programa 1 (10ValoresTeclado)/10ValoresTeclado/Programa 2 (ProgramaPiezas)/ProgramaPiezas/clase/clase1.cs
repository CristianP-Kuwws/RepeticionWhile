namespace ProgramaPiezas
{
    public class PiezasHierro
    {
        public void PiezasAptas()
        {
           try
           {
                int cantidadproc = 0;
                int indice = 0;
                double piezas = 0;
                double rangominimo = 1.20;
                double rangomaximo = 1.30;
                int piezasbuenas = 0;
                int piezasmalas = 0;

                Console.WriteLine($"Ingrese la cantidad de piezas a procesar: ");
                cantidadproc = int.Parse(Console.ReadLine());


                while (indice < cantidadproc)
                {
                    Console.Write($"Ingrese las longitudes de sus piezas: ");
                    piezas = double.Parse(Console.ReadLine());


                    if (piezas >= rangominimo && piezas <= rangomaximo)
                    {
                        piezasbuenas++;
                    }
                    else
                    {
                        piezasmalas++;
                    }

                    indice++;

                }

                Console.WriteLine($"Se ingresaron {piezasbuenas} piezas validas");
                Console.WriteLine($"Se ingresaron {piezasmalas} piezas invalidas");
           }

           catch (Exception ex)
           {
                Console.WriteLine("Ha ocurrido un error inesperado.");
           }
        }
    }
}