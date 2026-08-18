public class Camera
{
    private string _modelo;
    private string _material;
    private string _resolucao;

    public Camera(string modelo, string material, string resolucao)
    {
        _modelo = modelo;
        _material = material;
        _resolucao = resolucao;
    }

    public string getModelo()
    {
        return _modelo;
    }

    public void setModelo(string modelo)
    {
        this._modelo = modelo;
    }

    public string getMaterial()
    {
        return _material;
    }

    public void setMaterial(string material)
    {
        this._material = material;
    }

    public string getResolucao()
    {
        return _resolucao;
    }

    public void setResolucao(string resolucao)
    {
        this._resolucao = resolucao;
    }
}