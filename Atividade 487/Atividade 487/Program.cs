using Microsoft.VisualBasic;
namespace Atividade_481
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                int[] vet = new int[6];
                String imprimir = "Vetor: \n";
                for (int i = 0; i < 6; i++)
                    vet[i] = Int32.Parse(Interaction.InputBox("Digite o elemtno " + i + " do vetor: "));
                
                vet = reverse(vet, 6);
                
                for (int i = 0; i < 6; i++)
                    imprimir = imprimir + vet[i] + "\n";

                MessageBox.Show(imprimir);
            }
            catch { }
        }
        public static int[] reverse(int[] vet, int size)
        {
            int[] vetr = new int[size];
            int aux = size - 1;
            for (int i = 0; i < size; i++)
            {
                vetr[i] = vet[aux];
                aux--;
            }
            return vetr;
        }
    }
}