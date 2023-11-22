using AnimeRate.DataAccess.Models;

namespace AnimeRate.DataBusiness;
public interface IAnimeRepository
{
    public List<Anime> GetAllAnime();
}
