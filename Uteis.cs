class Uteis
{
    //função utilizada para impedir entrada de quaisquer dados que não sejam do tipo int
    public static int ObterInt(string mensagem)
    {
        string resposta;
        int resultado;

        while (true)
        {
            Console.Write(mensagem);
            resposta = Console.ReadLine()!;

            if (int.TryParse(resposta, out resultado) && resultado > 0)
            {
                break;
            }

            Console.Write("Entrada inválida de dados!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        return resultado;
    }

    //função utilizada para impedir entrada de quaisquer dados que não sejam do tipo double
    public static double ObterDouble(string mensagem)
    {
        string resposta;
        double resultado;

        while (true)
        {
            Console.Write(mensagem);
            resposta = Console.ReadLine()!;

            if (double.TryParse(resposta, out resultado) && resultado > 0)
            {
                break;
            }

            Console.Write("Entrada inválida de dados!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        return resultado;
    }

    //função utilizada para impedir entrada de strings vazias
    public static string ObterString(string mensagem)
    {
        string resultado;

        while (true)
        {
            Console.Write(mensagem);
            resultado = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(resultado))
            {
                break;
            }

            Console.Write("Entrada inválida de dados!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        return resultado;
    }

    //imprime os dados do bloco de forma organizada e formatada
    public static void ImprimeDadosDoBloco (Bloco bloco)
    {
        Console.WriteLine($"{"Código:".PadRight(25)} {bloco.GetCodigoDoBloco()}");
        Console.WriteLine($"{"Número:".PadRight(25)} {bloco.GetNumero()}");
        Console.WriteLine($"{"Medida (M³):".PadRight(25)} {bloco.GetMedidaMetroCubico()}");
        Console.WriteLine($"{"Descrição:".PadRight(25)} {bloco.GetDescricao()}");
        Console.WriteLine($"{"Material:".PadRight(25)} {bloco.GetTipoDoMaterial()}");
        Console.WriteLine($"{"Valor de compra:".PadRight(25)} {bloco.GetValorDeCompra().ToString("C")}");
        Console.WriteLine($"{"Valor de venda:".PadRight(25)} {bloco.GetValorDeVenda().ToString("C")}");
        Console.WriteLine($"{"Pedreira de origem:".PadRight(25)} {bloco.GetPedreira()}");
        Console.WriteLine("\n");
    }

    //retorna true se não houver blocos na lista, e false se houver
    public static bool NaoHaBlocos (List <Bloco> blocos)
    {
        if (blocos.Count == 0)
        {
            Console.WriteLine("Não há blocos cadastrados!");
            Thread.Sleep(1500);
            return true;
        }
        return false;
    }
}