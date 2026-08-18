public class Bola
{
    private string _modelo;
    private string _cor;
    private string _material;
    private string _tamanho;

    public Bola(string modelo, string cor, string material, string tamanho)
    {
        _modelo = modelo;
        _cor = cor;
        _material = material;
        _tamanho = tamanho;
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

    public string getTamanho()
    {
        return _tamanho;
    }

    public void setTamanho(string tamanho)
    {
        this._tamanho = tamanho;
    }
}