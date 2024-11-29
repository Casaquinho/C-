int a  = 1800000000;
int b = 600000000;
long c = (long)a + (long)b; //converter para long, se n da overflow (numero mt grande pra INT)
Console.WriteLine(c);

long d = checked (a + b); //vai validar se a operação pode ser feita|


int counter = 0;

while (counter < 5)
{
    Console.WriteLine(counter);
    counter++;
}

counter = 0;

do
{
    Console.WriteLine(counter);
    counter++;
}while (counter < 5);


for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine(i);
}


int [] array = new int[5];

int [] array2 = [1,2,3,4,5];

int[,] array3 = new int [2,3];


foreach (int valor in array2)
{
    Console.WriteLine(valor);
}


var names = new List<string> {
    "marcelo", 
    "rafa",
    "Vitor",
    "cusujo"
};

foreach (var item in names)
{
    System.Console.WriteLine($"{item.ToUpper()}");
}




