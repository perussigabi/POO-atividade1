public class Cadeira
{
    private string _modelo;
    private string _formato;
    private string _material;
    private string _cor;
    private string _capacidade;

    public Cadeira(string modelo, string formato, string material, string cor, string capacidade)
    {
        _modelo = modelo;
        _formato = formato;
        _material = material;
        _cor = cor;
        _capacidade = capacidade;
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

    public string getMaterial()
    {
        return _material;
    }

    public void setMaterial(string material)
    {
        this._material = material;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getCapacidade()
    {
        return _capacidade;
    }

    public void setCapacidade(string capacidade)
    {
        this._capacidade = capacidade;
    }
}