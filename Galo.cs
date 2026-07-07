class Galo
{
    static void Main()
    {
        // Reduzi para 5 posições apenas para testar mais rápido, 
        // mas você pode mudar de volta para 30!
        int[] vetor = new int[5]; 

        // 1. Entrada de dados
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Insira o número para a posição {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Estatísticas dos Números ---");

        // 2. Processamento e Saída
        for (int y = 0; y < vetor.Length; y++)
        {
            int n = vetor[y];
            int contador = 0;

            // [OPCIONAL] Truque para não repetir números que já foram contados antes
            bool jaContado = false;
            for (int antigo = 0; antigo < y; antigo++)
            {
                if (vetor[antigo] == n)
                {
                    jaContado = true;
                    break;
                }
            }
            if (jaContado) continue; // Pula para o próximo número se este já foi exibido

            // Conta quantas vezes o número 'n' aparece no vetor inteiro
            for (int x = 0; x < vetor.Length; x++)
            {
                if (vetor[x] == n)
                {
                    contador++;
                }
            }

            // O cálculo e o Console.WriteLine DEVEM ficar aqui dentro do laço 'y'
            double resultado = (contador * 100.0) / vetor.Length;
            Console.WriteLine($"O número {n} aparece {contador} vez(es) ({resultado:F2}% das vezes).");
        }
    }
}