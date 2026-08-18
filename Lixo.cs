public class Lixo
{
    private string _volume;
    private string _cor;
    private string _material;
    private string _modelo;

    public Lixo(string volume, string cor, string material, string modelo)
    {
        _volume = volume;
        _cor = cor;
        _material = material;
        _modelo = modelo;
    }

    public string getVolume()
    {
        return _volume;
    }

    public void setVolume(string volume)
    {
        this._volume = volume;
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

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }
}