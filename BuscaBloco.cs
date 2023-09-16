namespace _4s_1b_trabalho_lp1;

public class BuscaBloco 
{
    //Percorre a lista de blocos, imprimindo o bloco com o código informado. Mostra mensagem de erro caso a lista esteja vazia
    //ou o código informado não exista na lista
    public static void BuscarBlocoPorCodigo(List<Bloco> blocos)
    {
        if (Uteis.NaoHaBlocos(blocos))
        {
            return;
        }

        string codigo = Uteis.ObterString("Digite o código do bloco a ser buscado: ");
        Console.Clear();

        bool codigoExiste = false;

        foreach(Bloco bloco in blocos)
        {
            if (codigo == bloco.GetCodigoDoBloco())
            {
                Uteis.ImprimeDadosDoBloco(bloco);
                Console.Write("Pressione qualquer tecla...");
                Console.ReadKey();
                codigoExiste = true;
                break;
            }
        }

        if(!codigoExiste)
        {
            Console.WriteLine("O código informado não existe!");
            Thread.Sleep(1500);
        }
        Console.Clear();
    }
}
