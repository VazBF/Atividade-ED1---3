using Microsoft.VisualBasic;
namespace Atividade_470
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            int n;
            try
            {
                n = Int32.Parse(Interaction.InputBox("Digite o numero: "));
                if (primo(n) == true)
                {
                    MessageBox.Show("O numero não eh primo");
                }
                else
                {
                    MessageBox.Show("O numero eh primo");
                }
            }
            catch
            {
            }

        }
        public static bool primo(int n)
        {
            bool result = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}