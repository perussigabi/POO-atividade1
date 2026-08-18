public class PlacaSolar
{
    private string _modelo;
    private string _tamanho;
    private string _eficiencia;

    public PlacaSolar(string modelo, string tamanho, string eficiencia)
    {
        _modelo = modelo;
        _tamanho = tamanho;
        _eficiencia = eficiencia;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }

    public string getTamanho()
    {
        return _tamanho;
    }

    public void setTamanho(string tamanho)
    {
        this._tamanho = tamanho;
    }

    public string getEficiencia()
    {
        return _eficiencia;
    }

    public void setEficiencia(string eficiencia)
    {
        this._eficiencia = eficiencia;
    }
}