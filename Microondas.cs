public class Microondas
{
    private string _cor;
    private string _potencia;
    private string _modelo;

    public Microondas(string cor, string potencia, string modelo)
    {
        _cor = cor;
        _potencia = potencia;
        _modelo = modelo;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getPotencia()
    {
        return _potencia;
    }

    public void setPotencia(string potencia)
    {
        this._potencia = potencia;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }
}