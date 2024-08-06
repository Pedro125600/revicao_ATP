namespace att7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário atual do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de aumento: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            AumentarSalario(ref salario, percentual);

            Console.WriteLine("O salário atualizado é: " + salario);
        }

        static void AumentarSalario(ref double salario, double percentual)
        {
            double aumento = salario * (percentual / 100);

            salario += aumento;
        }
    }
}

