namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void calcularDistancia()
        {
            //Faz alguma coisa...
        }

        private void calcularDistancia2()
        {
            //Faz alguma coisa...
        }

        public virtual void calcularDistancia3()
        {
            //Faz alguma coisa...
        }

    }
}