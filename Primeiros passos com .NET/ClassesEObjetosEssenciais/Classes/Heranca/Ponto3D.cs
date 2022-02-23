namespace Classes.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            calcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa
        }

        public override void calcularDistancia3()
        {
            base.calcularDistancia3();
            //faz outra coisa ...
        }
    }
}