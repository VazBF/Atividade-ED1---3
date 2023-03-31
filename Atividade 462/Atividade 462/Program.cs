using Microsoft.VisualBasic;
namespace Atividade_462
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                float n1, n2, n3;
                n1 = float.Parse(Interaction.InputBox("Nota 1:"));
                n2 = float.Parse(Interaction.InputBox("Nota 2:"));
                n3 = float.Parse(Interaction.InputBox("Nota 3:"));
                MessageBox.Show("Media = " + media(n1, n2, n3));
            }
            catch { }
        }
        public static float media(float n1, float n2, float n3)
        {
            float m = ((n1 + n2 + n3) / 3);
            return m;
        }
    }
}