public class Garrafa
{
    private string _modelo;
    private string _cor;
    private string _material;
    private string _capacidade;

    public Garrafa(string modelo, string cor, string material, string capacidade)
    {
        _modelo = modelo;
        _cor = cor;
        _material = material;
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

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getMaterial()
    {
        return _material;
    }

    public void setMaterial(string material)
    {
        this._material = material;
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