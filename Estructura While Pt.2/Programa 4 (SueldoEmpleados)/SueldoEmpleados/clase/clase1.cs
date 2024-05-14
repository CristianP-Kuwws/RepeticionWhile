namespace SueldosEmpleados
{
    public class EmpleadoSueldos
    {
        public void GestorSueldos()
        {
            try
            {
                int empleados = 0;
                int indice = 0;
                double sueldos = 0;
                double sueldominimo = 100;
                double sueldomaximo = 500;
                int sueldoalto = 0;
                int sueldobajo = 0;
                double salario = 0;

                Console.WriteLine($"Ingrese la cantidad de empleados: ");
                empleados = int.Parse(Console.ReadLine());


                while (indice < empleados)
                {
                    Console.Write($"Ingrese los sueldos de sus empleados: ");
                    sueldos = double.Parse(Console.ReadLine());


                    if (sueldos >= sueldominimo && sueldos <= sueldomaximo)
                    {
                        if (sueldos >= sueldominimo && sueldos <= 300)
                        {
                            sueldobajo++;
                        }

                        else if (sueldos > 300 && sueldos <= 500)
                        {
                            sueldoalto++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ingrese un sueldo válido entre $100 y $500.");
                    }

                    salario += sueldos;
                    indice++;
                }

                Console.WriteLine($"El numero de empleados que cobran entre $100 y $300 fueron {sueldobajo} empleados.");
                Console.WriteLine($"El numero de empleados que cobran mas de $300 fueron {sueldoalto} empleados.");
                Console.WriteLine($"Gasto total en sueldos de la empresa: ${salario}");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado.");
            }

        }
    }
}