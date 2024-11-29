
public class Exercicios
{
    public static void Exercicios5(int[] array)
    {
        Random random = new Random();

        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    public static string Exercicio6(int[] A, int k)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int z = 1; z < A.Length; z++)
            {
                if (A[i] != A[z])
                {
                    if (A[i] + A[z] == k)
                    {
                        return "" + A[i] + "e" + A[z];
                    }
                }
            }
        }
        return "n tem numeros somados dao esse valor";
    }

    public static string[] Exercicio7(string[] A)
    {
        int posicao = 0;
        foreach (string elem in A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (elem == A[i])
                {
                    posicao = i;
                }
            }
        }
        string[] novaLista = new string[A.Length - 1];
        int posic = 0;
        for (int z = 0; z < A.Length; z++)
        {
            if (z != posicao)
            {
                novaLista[z] = A[posic];
                posic++;
            }
            if(z == posicao)
            {
                posic++;
            }
        }
        return novaLista;

    }
                // [ 1, -2, 3, -4, 5, -6] //
    public static int[] Exercicio8(int[] A)
    {
        int posicao = 0;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] < 0)
            {
                int chave = A[i];
                A[i] = A[posicao];
                A[posicao] = chave;
                posicao++;
            }
        }
        return A;
    }

    public static int Exercicio9(int[] A)
    {

        int cont = 0;
        int tamanho = A.Length/2 + 1;
        for (int i = 0; i < A.Length; i++)
        {
            cont = 0;
            for (int z = 1; z < A.Length; z++)
            {
                if (A[i] == A[z])
                {
                    cont++;
                    if(cont >= tamanho)
                    {
                        return A[i];
                    }
                    
                }
            }
        }
        return -1;
    }

    public static string Exercicio10(int[] A, int k)
    {
        Array.Sort(A); 
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == k)
            {
                return A[i] + " esta na posicao " + i;
            }
        }
        return "nao tem esse numero";
    }
    public static void Main(string[] args)
    {
        int[] numbers = [2,2,2,3,3,3];
        System.Console.WriteLine(String.Join(",", Exercicio9(numbers)));
    }

}

        


