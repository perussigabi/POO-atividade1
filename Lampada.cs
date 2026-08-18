public class Lampada
{
    private string _potencia;
    private string _cor;
    private string _modelo;
    private string _formato;

    public Lampada(string potencia, string cor, string modelo, string formato)
    {
        _potencia = potencia;
        _cor = cor;
        _modelo = modelo;
        _formato = formato;
    }

    public string getPotencia()
    {
        return _potencia;
    }

    public void setPotencia(string potencia)
    {
        this._potencia = potencia;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
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