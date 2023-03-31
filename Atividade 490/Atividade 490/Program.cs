using Microsoft.VisualBasic;
namespace Atividade_481
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            String[] vet = new String[3];
            String x;
            try
            {
                for(int i = 0; i < 3; i++)
                {
                    vet[i] = Interaction.InputBox("Digite a palavra " + i + " : ");                             
                }
                x = Interaction.InputBox("Digite o character a ser eliminado: ");
                MessageBox.Show("" + cont(vet, x, 3));
            }
            catch { }
        }

        public static int cont(String[] vet, String x, int size)
        {
            int cont = 0;
            for (int i = 0; i < size; i++)
            {
                if (vet[i].Contains(x))
                {

                    cont++;
                }
            }
            return cont;
        }

    }
}