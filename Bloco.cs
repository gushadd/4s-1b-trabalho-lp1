using System.Numerics;

public class Bloco {
    private string codigoDoBloco;   //de int para string
    private int numero;             //adicionado  
    private double medidaMetroCubico;
    private string descricao;
    private string tipoDoMaterial;
    private double valorDeCompra;
    private double valorDeVenda;
    private string pedreira;

    public Bloco(string codigoDoBloco, int numero, double medidaMetroCubico, string descricao, string tipoDoMaterial, double valoreDeCompra, double valorDeVenda, string pedreira)
    {
        this.codigoDoBloco = codigoDoBloco;
        this.numero = numero;
        this.medidaMetroCubico = medidaMetroCubico;
        this.descricao = descricao;
        this.tipoDoMaterial = tipoDoMaterial;
        this.valorDeCompra = valoreDeCompra;
        this.valorDeVenda = valorDeVenda;
        this.pedreira = pedreira;
    }

    public string getCodigoDoBloco()
    {
        return this.codigoDoBloco;
    }

    public int getNumero()
    {   //adicionado 
        return this.numero;
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
        return this.valorDeCompra;
    }

    public double getValorDeVenda()
    {
        return this.valorDeVenda;
    }

    public string getPedreira()
    {
        return this.pedreira;
    }

    public void setCodigoDoBloco(string codigoDoBloco)
    {
        this.codigoDoBloco = codigoDoBloco;
    }

    public void setNumero(int numero)
    { //adicionado 
        this.numero = numero;
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
        this.valorDeCompra = valoreDeCompra;
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
