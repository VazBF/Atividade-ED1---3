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
                int[] vet1 = new int[5];
                String[] vet2 = new String[5];

                for (int  i = 0; i < 5; i ++)
                {
                    vet1[i] = Int32.Parse(Interaction.InputBox("Digite o elemento " + i + " do vetor 1:" ));
                }
                for (int i = 0; i < 5; i++)
                {
                    vet2[i] = Interaction.InputBox("Digite o elemento " + i + " do vetor 2:");
                }
                multi(vet1, vet2, 5);
            }
            catch { }
        }

        public static void multi(int[] vet1, String[] vet2, int size)
        {
            String result = ""; 
            for (int i = 0; i < size; i++)
            {
                for (int z = 0; z < vet1[i]; z++)
                {
                    result = result + vet2[i];
                }
                result = result + "\n";
                            }
            MessageBox.Show(result);
        }
    }
}