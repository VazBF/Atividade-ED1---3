using Microsoft.VisualBasic;
namespace Atividade_481
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                int[] vet = new int[5];
                for (int i = 0; i<5; i++)
                    vet[i] = Int32.Parse(Interaction.InputBox("Digite o elemento " + i + " :"));
                if (ordem(vet, 5) == true)
                {
                    if(ver(vet) == 1)
                    {
                        MessageBox.Show("O vetor está ordenado em ordem decrescente.");
                    }else if(ver(vet) == 2)
                    {
                        MessageBox.Show("O vetor está ordenado em ordem crescente.");
                    }
                }else if (ordem(vet, 5) == false)
                {
                    MessageBox.Show("O vetor não está ordenado");
                }

            }
            catch { }
        }
        public static int ver(int[] vet)
        {
            int r = 0;
            if (vet[0] > vet[1])
            {
                r = 1;
            }
            else
            {
                r = 2;
            }
            return r;
        }

        public static bool ordem(int[] vet, int size)
        {
            int r = ver(vet);
            bool ordem = true;
            if(r == 1)
            {
                for (int i = 0; i < (size -1); i++)
                {
                    if (vet[i] > vet[(i + 1)])
                    {
                        ordem = true;
                    }
                    else
                    {
                        ordem = false;
                    }
                }
            }else if (r == 2)
            {
                for (int i = 0; i < (size - 1); i++)
                {
                    if (vet[i] < vet[(i + 1)])
                    {
                        ordem = true;
                    }
                    else
                    {
                        ordem = false;
                    }
                }
            }
            return ordem;
        }
    }
}