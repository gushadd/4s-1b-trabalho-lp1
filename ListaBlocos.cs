namespace _4s_1b_trabalho_lp1;

public class ListaBlocos
{
    public static void ListarBlocos(List<Bloco> blocos)
    {
        Console.Clear();
        if (blocos.Count == 0)  //caso não haja blocos na lista, não mostra nada
        {
            Console.WriteLine("Não há blocos cadastrados!");
            return;
        }

        foreach (Bloco bloco in blocos) //imprime a lista de blocos formatada com PadRight()
        {
            Console.WriteLine($"{"Código:".PadRight(25)} {bloco.getCodigoDoBloco()}");
            Console.WriteLine($"{"Número:".PadRight(25)} {bloco.getNumero()}");
            Console.WriteLine($"{"Medida (M³):".PadRight(25)} {bloco.getMedidaMetroCubico()}");
            Console.WriteLine($"{"Descrição:".PadRight(25)} {bloco.getDescricao()}");
            Console.WriteLine($"{"Material:".PadRight(25)} {bloco.getTipoDoMaterial()}");
            Console.WriteLine($"{"Valor de compra:".PadRight(25)} {bloco.getValoreDeCompra().ToString("C")}");
            Console.WriteLine($"{"Valor de venda:".PadRight(25)} {bloco.getValorDeVenda().ToString("C")}");
            Console.WriteLine($"{"Pedreira de origem:".PadRight(25)} {bloco.getPedreira()}");
            Console.WriteLine("\n");
        }

        Console.Write("Fim da lista de blocos. Pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
    }
}
