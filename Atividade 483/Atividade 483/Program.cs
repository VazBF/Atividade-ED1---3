using Microsoft.VisualBasic;
namespace Atividade_481
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            int[] vet1 = new int[4];
            int[] vet2 = new int[4];

            for (int i = 0; i < 4; i++)
            {
                vet1[i] = Int32.Parse(Interaction.InputBox("Digite o elemento " + i + " do vetor 1: "));
            }
            for (int i = 0; i < 4; i++)
            {
                vet2[i] = Int32.Parse(Interaction.InputBox("Digite o elemento " + i + " do vetor 2: "));
            }

            MessageBox.Show("O produto interno dos dois vetores eh: " + produto(vet1, vet2, 4));
            try
            {

            }
            catch { }
        }
        public static int produto(int[] vet1, int[] vet2, int size)
        {
            int prod = 0;
            for(int i =  0; i < size; i++)
            {
                prod = prod + (vet1[i] * vet2[i]);
            }
            return prod;
        }
    }
}