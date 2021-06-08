using System;
class x
{
    static void Main()
    {

        Console.WriteLine("Bem vindo ao tradutor de código tp\n\nAperte o enter para começar:\n");
        Console.ReadKey();
        Console.Clear();

        inicio:

        Console.WriteLine("Digite o texto: ");
        string entra=Console.ReadLine();
        Console.Clear();

        string p1=entra.Replace("é", "7'").Replace("í", "9'").Replace("ó", "2'").Replace("á", "4'");
        string p2=p1.Replace("ê", "7}").Replace("î", "9}").Replace("ô", "2}").Replace("â", "4}");
        string p3=p2.Replace("é", "7'").Replace("í", "9'").Replace("ó", "2'").Replace("á", "4'");
        string p4=p3.Replace("ê", "7}").Replace("î", "9}").Replace("ô", "2}").Replace("â", "4}");
        
        string p5=p4.Replace("É", "7|'").Replace("Í", "9|'").Replace("Ó", "2|'").Replace("Á", "4|'");
        string p6=p5.Replace("Ê", "7|}").Replace("Î", "9|}").Replace("Ô", "2|}").Replace("Â", "4|}");

        string p7=p6.Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "").Replace("", "");



        Console.WriteLine("{0}\n\n\n\n\n\nDeseja tentar de novo? [s] ou [n]",p6);
        string decisao=Console.ReadLine();

        des:

        if(decisao == "s" || decisao == "S")
        {
            Console.Clear();
            goto inicio;
        }
        else if(decisao == "n" || decisao == "N")
        {
            Console.WriteLine("\n\nAperte o enter para sair!");
        }
        else
        {
            Console.Clear();
            goto des;
        }

        Console.ReadKey();
    }
}