namespace _4s_1b_trabalho_lp1;

public class ListaBlocos
{
    //Recebe uma List<Blocos> e percorre essa lista, mostrando todos os objetos contidos nela.
    //Caso não haja nada, mostra uma mensagem de aviso.
    public static void ListarBlocos(List<Bloco> blocos)
    {
        if (Uteis.NaoHaBlocos(blocos))
        {
            return;
        }

        foreach (Bloco bloco in blocos) 
        {
            Uteis.ImprimeDadosDoBloco(bloco);
        }

        Console.Write("Fim da lista de blocos. Pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
    }
}
