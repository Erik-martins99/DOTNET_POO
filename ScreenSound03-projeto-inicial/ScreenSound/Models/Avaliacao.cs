namespace ScreenSound.Models
{
    internal class Avaliacao
    {
        public int Nota { get; }

        public Avaliacao(int nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                Nota = nota;    
            } else
            {
                Console.WriteLine("A nota dever estar entre 0 e 10");
            }
        }

        public static Avaliacao Parse(string nota)
        {
            return new Avaliacao(int.Parse(nota));
        }
    }
}