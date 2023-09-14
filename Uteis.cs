class Uteis
{
    //função utilizada para impedir entrada de quaisquer dados que não sejam do tipo int
    public static int ObterInt(string mensagem)
    {
        Console.Clear();
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
        Console.Clear();
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
        Console.Clear();
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
}