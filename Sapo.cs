public class Sapo
{
    private string _cor;
    private string _especie;
    private string _tamanho;

    public Sapo(string cor, string especie, string tamanho)
    {
        _modelo = modelo;
        _cor = cor;
        _especie = especie;
        _tamanho = tamanho;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getEspecie()
    {
        return _especie;
    }

    public void setEspecie(string especie)
    {
        this._especie = especie;
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