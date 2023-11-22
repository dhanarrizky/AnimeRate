using AnimeRate.DataAccess.Models;

namespace AnimeRate.DataBusiness;
public class AnimeRepository:IAnimeRepository
{
    private readonly AnimeRateContext _DBContext;
    public AnimeRepository(AnimeRateContext animeRateContext){
        _DBContext = animeRateContext;
    }

    public List<Anime> GetAllAnime(){
        var query = from anime in _DBContext.Animes
                    select anime;
        return query.ToList();
    }
}
