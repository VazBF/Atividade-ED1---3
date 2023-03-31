using Microsoft.VisualBasic;
namespace Atividade_473
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            try
            {
                String a;
                a = Interaction.InputBox("Digite o char: ");
                MessageBox.Show("" + ver(a));
            }
            catch { }
        }
        public static int ver(String a)
        {
            if (a.Equals("a") || a.Equals("e") || a.Equals("i") || a.Equals("o") || a.Equals("u")
                || a.Equals("A") || a.Equals("E") || a.Equals("I") || a.Equals("O") || a.Equals("U"))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}