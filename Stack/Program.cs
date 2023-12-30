/*
    Enunciado do exercício:
- implemente um programa que verifica se uma expressão matemática contém parênteses 
    balanceados seguindo os seguintes passos:
        1. Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos.
        2. Percorra cada caractere da expressão matemática.
        3. Se o caractere for um parêntese aberto ( '(', '{', '['), adicione-o à pilha.
        4. Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia e se o último 
        parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o 
        último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses 
        balanceados.
        5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver 
        vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é 
        balanceada. 
 
*/

Console.Title = "Exercicios";

char[] abertos = new char[] {'(','{','[' };
char[] fechados = new char[] { ')', '}',']' };

Stack<char> stackParentesesAberto = new Stack<char>() { };

Console.WriteLine("\n### Escreva abaixo uma expressão matemática ###\n");
string expressaoMatematica = Console.ReadLine();
char[] caracter = expressaoMatematica.ToCharArray();


foreach (var ch in caracter)
{
    for (int j = 0; j < abertos.Length; j++)
    {
        if (abertos[j] == ch)
        {
            stackParentesesAberto.Push(ch);
        }
        else if (fechados[j] == ch)
        {
            if(stackParentesesAberto.Count > 0)
            {
                if(stackParentesesAberto.Peek() == abertos[j])
                {
                    stackParentesesAberto.Pop();
                }
                else
                {
                    Console.WriteLine("A expressão matemática não contém parênteses balanceados...");
                }
            }
        }
    }

}

if (stackParentesesAberto.Count > 0)
{
    Console.WriteLine("\nA expressão matemática não contém parênteses balanceados\n");
}
else
{
    Console.WriteLine("\nA expressão matemática é balanceada...\n");
}

Console.ReadKey();
