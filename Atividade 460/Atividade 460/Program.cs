using Microsoft.VisualBasic;
namespace Atividade_460
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try{
                int f;
                for (int i = 0; i < 3; i++)
                {
                    f = Int32.Parse(Interaction.InputBox("Digite o numero a ser dobrado:"));
                    MessageBox.Show("O dobro eh: " + dobrar(f));
                }
            }
            catch { };
        }
        public static int dobrar(int x)
        {
            return (x * 2);
        }
    }
}