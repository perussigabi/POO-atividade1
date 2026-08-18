public class Torneira
{
    private string _vazao;
    private string _cor;
    private string _formato;

    public Torneira(string vazao, string cor, string formato)
    {
        _vazao = vazao;
        _cor = cor;
        _formato = formato;
    }

    public string getVazao()
    {
        return _vazao;
    }

    public void setVazao(string vazao)
    {
        this._vazao = vazao;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getFormato()
    {
        return _formato;
    }

    public void setFormato(string formato)
    {
        this._formato = formato;
    }
}