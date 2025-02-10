
namespace EjercicioAbstraccion_Angel
{
   
        public class MetrosAKilometros : Formulas
        {
            private double metros;

            public MetrosAKilometros(double metros)
            {
                this.metros = metros;
            }

            public override double Calcular()
            {
                return metros / 1000;
            }

            public override void Imprimir()
            {
                Console.WriteLine(metros + " metros son " + Calcular() + " kilómetros");
            }
        }

    
}
