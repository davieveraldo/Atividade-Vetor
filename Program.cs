class Program
{
    static void Main()
    {
        int[]vetor = new int[10];
       int i=0;
       int numPar = 0;

        for(i=0; i < 10; i++)
        {
            Console.Write("Isira as posições do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine()); 

            if(vetor[i] % 2 == 0)
            {
                numPar++;
            }
            
        }
        Console.WriteLine($"Números na posição {numPar} que são pares. ");

        
    }

   
}