public class Caneta
{
    private string _marca;
    private string _cor;
    private string _material;
    private string _tipo;

    public Caneta(string marca, string cor, string material, string tipo)
    {
        _marca = marca;
        _cor = cor;
        _material = material;
        _tipo = tipo;
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

    public string getMaterial()
    {
        return _material;
    }

    public void setMaterial(string material)
    {
        this._material = material;
    }

    public string getTipo()
    {
        return _tipo;
    }

    public void setTipo(string tipo)
    {
        this._tipo = tipo;
    }
}