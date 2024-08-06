namespace rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
            string[,] matriz = ConverterCsvParaMatriz(csv);

            // Exibindo a matriz resultante
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string[,] ConverterCsvParaMatriz(string csv)
        {
            // Divide a string em linhas
            string[] linhas = csv.Split('\n');

            // Assume que todas as linhas têm o mesmo número de colunas, então pega o número de colunas da primeira linha
            int numeroDeColunas = linhas[0].Split(',').Length;

            // Cria a matriz de acordo com o número de linhas e colunas
            string[,] matriz = new string[linhas.Length, numeroDeColunas];

            // Preenche a matriz com os dados do CSV
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] valores = linhas[i].Split(',');

                for (int j = 0; j < valores.Length; j++)
                {
                    matriz[i, j] = valores[j];
                }
            }

            return matriz;
        }
    }
}
