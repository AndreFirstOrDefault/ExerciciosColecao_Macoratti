Queue<string> filaImpressão = new Queue<string> ();
filaImpressão.Enqueue("Arquivo 01");
filaImpressão.Enqueue("Arquivo 02");
filaImpressão.Enqueue("Arquivo 03");
filaImpressão.Enqueue("Arquivo 04");
filaImpressão.Enqueue("Arquivo 05");
filaImpressão.Enqueue("Arquivo 06");

if(filaImpressão.Count > 0)
{
    do
    {
        Console.WriteLine($"Imprimindo {filaImpressão.Peek()}....\n");
        Thread.Sleep(2500);
        Console.WriteLine($"O arquivo {filaImpressão.Dequeue()} foi impresso com sucesso!\n");
        Thread.Sleep(1250);
    }
    while(filaImpressão.Count > 0);
}


Console.WriteLine("Não há mais arquivos para imprimir!");
Console.ReadKey();