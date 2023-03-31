using Microsoft.VisualBasic;
namespace Atividade_463
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                float ang;

                ang = float.Parse(Interaction.InputBox("Digite o angulo: "));
                MessageBox.Show("O angulo em radiano eh: " + radiano(ang));
            }
            catch { }
        }
        public static float radiano(float ang)
        {
            return (ang * 3.1415f / 180);
        }
    }
}   