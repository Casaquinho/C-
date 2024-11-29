(int, int, int) vertices = (12,1,5);

// int vertice1 = 12
// int vertice2 = 1
//int vertice 3 = 5


//retorna bool caso seja igual ou diferente, e se for maior retorna o numero maior, ou entao retorna o num2
Console.WriteLine(vertices);
(bool, int) GetSameOrBigger (int num1, int num2)
{
    return(num1 == num2, num1>num2 ? num1:num2);
}

Console.WriteLine(GetSameOrBigger(10,10));

//recebe uma tupla, NAO DOIS INT
int Add((int, int) operands)
{
    return operands.Item1 + operands.Item2;
}

(int,int) a = (5,4);
Console.WriteLine(Add(a));

(bool sucess, string message) result = (true, "well");
bool mySucess = result.sucess;
string myMessage = result.message;
