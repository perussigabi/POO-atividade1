public class Notebook
{
    private string _modelo;
    private string _marca;
    private string _cor;
    private string _processador;

    public Notebook(string modelo, string marca, string cor, string processador)
    {
        _modelo = modelo;
        _marca = marca;
        _cor = cor;
        _processador = processador;
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

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getProcessador()
    {
        return _processador;
    }

    public void setProcessador(string processador)
    {
        this._processador = processador;
    }
}