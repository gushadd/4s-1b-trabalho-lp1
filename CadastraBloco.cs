namespace _4s_1b_trabalho_lp1;

public class CadastraBloco
{
    public static Bloco CadastrarBloco()
    {
        string codigoDoBloco = Uteis.ObterString("Digite o codigo do bloco: ");
        int numero = Uteis.ObterInt("Digite o numero do bloco: ");
        double medidaMetroCubico = Uteis.ObterDouble("Digite a medida do bloco (m^3): ");
        string descricao = Uteis.ObterString("Digite a descrição do bloco: ");
        string tipoDoMaterial = Uteis.ObterString("Digite o material do bloco: ");
        double valorDeCompra = Uteis.ObterDouble("Digite o valor de compra: ");
        double valorDeVenda = Uteis.ObterDouble("Digite o valor de venda: ");
        string pedreira = Uteis.ObterString("Digite a pedreira de origem do bloco: ");

        Bloco bloco = new Bloco(codigoDoBloco, numero, medidaMetroCubico, descricao, tipoDoMaterial, valorDeCompra, valorDeVenda, pedreira);

        return bloco;
    }
}
