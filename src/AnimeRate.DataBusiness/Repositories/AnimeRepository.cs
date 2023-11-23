using AnimeRate.DataAccess.Models;
using System.Linq;

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

    public Anime GetAnimeByID(int id){
        return _DBContext.Animes.FirstOrDefault(a => a.AnimeId == id) ??
            throw new KeyNotFoundException("AnimeId not Found");
    }
}
