using Microsoft.VisualBasic;
namespace Atividade_465
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            try
            {
                int n1, n2;
                n1 = Int32.Parse(Interaction.InputBox("Digite o primeiro numero:"));
                n2 = Int32.Parse(Interaction.InputBox("Digite o segundo numero:"));

                maior(n1, n2);
            }
            catch { }
        }

        public static void maior(int n1, int n2)
        {
            if (n1 < n2)
            {
                MessageBox.Show("O segundo numero eh maior: " + n2 + " > " + n1);
            }
            else
            {
                MessageBox.Show("O primeiro numero eh maior: " + n1 + " < " + n2);
            }
        }
    }
}