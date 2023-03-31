using Microsoft.VisualBasic;

namespace Atividade_467
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            try
            {
                double n, b;

                for (int i = 0; i < 3; i++)
                {
                    n = Double.Parse(Interaction.InputBox("Digite o logaritmando: "));
                    b = Double.Parse(Interaction.InputBox("Digite a base: "));

                    MessageBox.Show("O logaritmo eh: " + loga(n, b));
                }
            }
            catch
            {
            }
        }
        public static double loga(double n, double b)
        {
            double i = (Math.Log(n, b));
            return i;
        }
    }
}