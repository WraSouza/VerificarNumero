// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe Um Número");
int numeroMaximo = Int32.Parse(Console.ReadLine());

int resultado = 0;
int count = 0;

//string valor = numeroInformado[2].ToString();

for(int i=1000; i < 9999; i++)
{
    string algarismo = i.ToString();

    for (int j=0; j < 4; j++)
    {
        
        if (Int32.Parse(algarismo[j].ToString()) <= numeroMaximo)
        {
            count++;
            resultado += Int32.Parse(algarismo[j].ToString());
        }      

    }

    if ((count == 4) && (resultado == 21))
    {
        Console.WriteLine(i.ToString());
    }

    count = 0;
    resultado = 0;
}

Console.WriteLine("Fim....");

Console.ReadKey();


