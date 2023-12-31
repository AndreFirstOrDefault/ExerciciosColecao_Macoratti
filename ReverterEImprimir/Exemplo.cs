namespace ReverterEImprimir;

internal class Exemplo
{
    public void  ReverterEImprimir<T>(T[] array ) 
    {
        var arrayInverso = array.Reverse();
        Queue<T> queue = new Queue<T>(arrayInverso);

        do
        {
            Console.WriteLine($"Imprimindo {queue.Dequeue()}\n");
            Thread.Sleep(1500);
        }
        while( queue.Count() > 0 );
        
    }
}
