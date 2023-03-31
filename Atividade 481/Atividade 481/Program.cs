using Microsoft.VisualBasic;
namespace Atividade_481
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            int num = -1, nbase = 0;
            try
            {
                num = Int32.Parse(Interaction.InputBox("Digite um numero maior ou igual a zero: "));
                while(num < 0)
                {
                    num = Int32.Parse(Interaction.InputBox("Digite um numero maior ou igual a zero: "));
                }
                nbase = Int32.Parse(Interaction.InputBox("Digite um numero entre 2 - 10: "));
                while (nbase < 2 || nbase > 10)
                {
                    nbase = Int32.Parse(Interaction.InputBox("Digite um numero entre 2 - 10: "));
                }
                MessageBox.Show("Numero em decimal: " + num + "\nNumero na base " + nbase + " : " + converte(num, nbase));
            }
            catch { }
        }
        public static int converte(int num, int nbase)
        {
            int nb = 0, r, b = 0;
            while (num >= nbase)
            {
                r = num % nbase;
                nb = nb + (10 ^ b) * r;
                num = num / nbase;
                b++;
            }
            nb = nb + (10 ^ b) * num;
            
            return nb;
        }

    }
}