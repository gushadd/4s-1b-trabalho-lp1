public class Bloco
{
    private int codigoDoBloco;
    private double medidaMetroCubico;
    private string descricao;
    private string tipoDoMaterial;
    private double valoreDeCompra;
    private double valorDeVenda;
    private string pedreira;

    public Bloco(int codigoDoBloco, double medidaMetroCubico, string descricao, string tipoDoMaterial, double valoreDeCompra, double valorDeVenda, string pedreira)
    {
        this.codigoDoBloco = codigoDoBloco;
        this.medidaMetroCubico = medidaMetroCubico;
        this.descricao = descricao;
        this.tipoDoMaterial = tipoDoMaterial;
        this.valoreDeCompra = valoreDeCompra;
        this.valorDeVenda = valorDeVenda;
        this.pedreira = pedreira;
    }

    public int getCodigoDoBloco()
    {
        return this.codigoDoBloco;
    }

    public double getMedidaMetroCubico()
    {
        return this.medidaMetroCubico;
    }

    public string getDescricao()
    {
        return this.descricao;
    }

    public string getTipoDoMaterial()
    {
        return this.tipoDoMaterial;
    }

    public double getValoreDeCompra()
    {
        return this.valoreDeCompra;
    }

    public double getValorDeVenda()
    {
        return this.valorDeVenda;
    }

    public string getPedreira()
    {
        return this.pedreira;
    }

    public void setCodigoDoBloco(int codigoDoBloco)
    {
        this.codigoDoBloco = codigoDoBloco;
    }

    public void setMedidaMetroCubico(double medidaMetroCubico)
    {
        this.medidaMetroCubico = medidaMetroCubico;
    }

    public void setDescricao(string descricao)
    {
        this.descricao = descricao;
    }

    public void setTipoDoMaterial(string tipoDoMaterial)
    {
        this.tipoDoMaterial = tipoDoMaterial;
    }

    public void setValoreDeCompra(double valoreDeCompra)
    {
        this.valoreDeCompra = valoreDeCompra;
    }

    public void setValorDeVenda(double valorDeVenda)
    {
        this.valorDeVenda = valorDeVenda;
    }

    public void setPedreira(string pedreira)
    {
        this.pedreira = pedreira;
    }
}