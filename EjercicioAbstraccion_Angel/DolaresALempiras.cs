
namespace EjercicioAbstraccion_Angel
{
   
        public class DolaresALempiras : Formulas
        {
            private double dolares;
            private const double tasaDeCambio = 24.5; // Ejemplo de tasa de cambio

            public DolaresALempiras(double dolares)
            {
                this.dolares = dolares;
            }

            public override double Calcular()
            {
                return dolares * tasaDeCambio;
            }

            public override void Imprimir()
            {
                Console.WriteLine(dolares + " dólares son " + Calcular() + " lempiras");
            }
        }

    
}
