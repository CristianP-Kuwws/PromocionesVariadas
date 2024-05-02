namespace PromedioDNotaVar
{
    public class PromedioDeNotaVar
    {
        public void PromedioMayorMenorVar()
        {
            // Declarar variables para las notas como decimal
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Ingrese la primera nota: ");
                nota1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota: ");
                nota2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota: ");
                nota3 = decimal.Parse(Console.ReadLine());

                
                promedio = (nota1 + nota2 + nota3) / 3;

               
                if (promedio >=  7)
                {
                    Console.WriteLine("Promocionado.");
                }

                else if (promedio >= 4 && promedio < 7)
                {
                    Console.WriteLine("Regular.");
                }

                else 
                {
                    Console.WriteLine("Reprobado.");
                }
            }
            
            
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }
}