namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:\\Users\\bpl_\\source\\repos\\AcademiaAtos\\exercicios\\Arquivos\\01\\01\\Dados.txt";


            Persistencia persistencia = new Persistencia();
            persistencia.lerArquivo(caminhoArquivo);
        }
    }
}