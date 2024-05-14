namespace DiezNotasAlumnos
{
    public class NotasAlumnos
    {
        public void EvaluadorNotasAlumnos()
        {
            try
            {
                double nota = 0;
                int indice = 0;
                int notasbuenas = 0;
                int notasmalas = 0;
                int cantidad = 10;

                while (indice < cantidad)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    nota = double.Parse(Console.ReadLine());

                    if (nota >= 7 && nota <= 10)
                    {
                        notasbuenas++;
                    }

                    else if (nota >= 0 && nota < 7)
                    {
                        notasmalas++;
                    }

                    else 
                    {
                        Console.WriteLine("Ingresa un valor de entre el 1 al 10.");
     
                    }

                    indice++;
                }

                Console.WriteLine($"Los alumnos con notas mayores o iguales a 7 fueron: {notasbuenas}.");
                Console.WriteLine($"Los alumnos con notas menores a 7 fueron: {notasmalas}.");



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Ha ocurrido un error. Asegúrese de ingresar números válidos.");
            }
        }
    }
}