using Microsoft.VisualBasic;
namespace Atividade_464
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                float ang;
                ang = float.Parse(Interaction.InputBox("Digite o angulo em radianos: "));
                MessageBox.Show("O angulo em graus: " + graus(ang));
            }
            catch { }
        }
        public static float graus(float ang)
        {
            return (ang * 180 / 3.1415f);
        }
    }
}