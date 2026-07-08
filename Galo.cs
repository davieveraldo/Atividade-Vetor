class Galo
{
    static void Main()
    {
        int[] vetor = new int[30]; 

        
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Insira o número para a posição {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Estatísticas dos Números ---");
      
        for (int y = 0; y < vetor.Length; y++)
        {
            int n = vetor[y];
            int contador = 0;

            
            bool jaContado = false;
            for (int antigo = 0; antigo < y; antigo++)
            {
                if (vetor[antigo] == n)
                {
                    jaContado = true;
                    break;
                }
            }
            if (jaContado) continue; 

          
            for (int x = 0; x < vetor.Length; x++)
            {
                if (vetor[x] == n)
                {
                    contador++;
                }
            }
            double resultado = (contador * 100.0) / vetor.Length;
            Console.WriteLine($"O número {n} aparece {contador} vez(es) ({resultado:F2}% das vezes).");
        }
    }
}