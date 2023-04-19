namespace SerieAPI;
public class Serie : ISerie
{
    private List<SerieDTO> DB;
    public Serie()
    {

        DB = new List<SerieDTO>();

    }

    public void Add(SerieDTO serie)
    {
        DB.Add(serie);
    }

    public void Delete(int id)
    {
        DB.RemoveAll(serie => serie.Id == id);
    }

    public void Update(int id, SerieDTO serie)
    {
        SerieDTO SerieDTOUpdate = DB.Single(serie => serie.Id == id);
        SerieDTOUpdate.Titulo = serie.Titulo;
        SerieDTOUpdate.Genero = serie.Genero;
        SerieDTOUpdate.Temporadas = serie.Temporadas;
    }

    public List<SerieDTO> All()
    {
        return DB;
    }

}