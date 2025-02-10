
namespace EjercicioAbstraccion_Angel
{
    public class AreaTriangulo : Formulas
    {
        private double baseTriangulo;
        private double alturaTriangulo;

     public AreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override double Calcular()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Area del triangulo: " + Calcular());
        }

    }
