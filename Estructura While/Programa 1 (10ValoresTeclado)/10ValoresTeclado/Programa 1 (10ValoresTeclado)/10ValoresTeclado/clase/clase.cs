namespace ValoresTeclado
{
    public class ValoresTeclado10
    {
        public void Suma10Valores()
        {
            try
            {
                double input = 0;
                double resultado = 0;
                double suma = 0;
                double promedio = 0;
                int cantidadevalores = 10;

                while (input < cantidadevalores)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    suma = (valor + suma);
                    promedio = (suma / cantidadevalores);
                    input++;
                }

                Console.WriteLine($"La suma de todos sus valores fueron: {suma}");
                Console.WriteLine($"El promedio de sus valores fueron: {promedio}");



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Ha ocurrido un error. Asegúrese de ingresar números válidos.");
            }
        }
    }
}
