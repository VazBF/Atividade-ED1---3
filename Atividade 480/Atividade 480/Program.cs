using Microsoft.VisualBasic;
namespace Atividade_480
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            try
            {
                int a;
                a = Int32.Parse(Interaction.InputBox("Digite o numero a ser verificado: "));
                if (a == capicua(a))
                {
                    MessageBox.Show("O numero eh uma capicua");
                }
                else
                {
                    MessageBox.Show("O numero nao eh uma capicua");
                }
            }
            catch { }
        }
        public static int capicua(int a)
        {
            int r = 0, soma = 0;
            while (a != 0)
            {
                r = a % 10;
                soma = soma * 10 + r;
                a = a / 10;
            }
            return soma;
        }
    }
}