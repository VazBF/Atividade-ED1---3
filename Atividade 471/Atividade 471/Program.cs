using Microsoft.VisualBasic;
namespace Atividade_471
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            try
            {
                int a, b;
                a = Int32.Parse(Interaction.InputBox("Digite o primeiro numero: "));
                b = Int32.Parse(Interaction.InputBox("Digite o segundo numero: "));

                MessageBox.Show("O numero " + a + " eh divisivel por " + b + ":  " + div(a, b));
            }
            catch { }
        }
        public static int div(int a, int b)
        {
            float resto = a;
            int r = 0;
            bool cod = true;
            while (cod == true)
            {
                if (resto % b == 0)
                {
                    resto = resto / b;
                    r++;
                    cod = true;
                }
                else
                {
                    cod = false;
                }
            }
            return r;
        }
    }
}