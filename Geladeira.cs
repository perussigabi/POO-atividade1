public class Geladeira
{
    private string _modelo;
    private string _marca;
    private string _potencia;

    public Geladeira(string modelo, string marca, string potencia)
    {
        _modelo = modelo;
        _marca = marca;
        _potencia = potencia;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }

    public string getMarca()
    {
        return _marca;
    }

    public void setMarca(string marca)
    {
        this._marca = marca;
    }

    public string getPotencia()
    {
        return _potencia;
    }

    public void setPotencia(string potencia)
    {
        this._potencia = potencia;
    }
}