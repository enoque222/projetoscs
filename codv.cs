using System;
class dev{
    static void Main(){
        comeco:
        Console.WriteLine("Digite tudo minusculo e sem acentos!\n\nDigite [v] caso você queira transformar uma palavra em código vermelho");
        Console.WriteLine("Digite [t] caso você queira traduzir uma palavra do código vermelho");
        char decisao=Convert.ToChar(Console.ReadLine());

        if(decisao == 'v' || decisao == 'V')
        {
            Console.Clear();
            Console.WriteLine("Digite o texto: ");
            string ori=Console.ReadLine();
            string res=ori.Replace("i", "iris").Replace("a", "ais").Replace("e", "enter").Replace("o", "omber").Replace("u", "ufter");
            Console.WriteLine(res);
            Console.ReadLine();
        }
        else if(decisao == 't' || decisao == 'T')
        {
            Console.Clear();
            Console.WriteLine("Digite o texto: ");
            string ori=Console.ReadLine();
            string res=ori.Replace("ais", "a").Replace("iris", "i").Replace("enter", "e").Replace("omber", "o").Replace("ufter", "u");
            Console.WriteLine(res);
            Console.ReadLine();
        }
        else
        {
            goto comeco;
        }
        es:
        Console.WriteLine("Você quer de novo: [s] [n]");
        char des=Convert.ToChar(Console.ReadLine());
        if(des == 's' || des == 'S')
        {
            goto comeco;
        }
        else if(des == 'n' || des == 'N')
        {
            Console.WriteLine("Aperte o enter para sair!");
            Console.ReadKey();
        }
        else
        {
            goto es;
        }
    }
}