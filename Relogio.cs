public class Relogio
{
    private string _modelo;
    private string _estilo;
    private string _alimentacao;

    public Relogio(string modelo, string estilo, string alimentacao)
    {
        _modelo = modelo;
        _estilo = estilo;
        _alimentacao = alimentacao;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }

    public string getEstilo()
    {
        return _estilo;
    }

    public void setEstilo(string estilo)
    {
        this._estilo = estilo;
    }

    public string getAlimentacao()
    {
        return _alimentacao;
    }

    public void setAlimentacao(string alimentacao)
    {
        this._alimentacao = alimentacao;
    }
}