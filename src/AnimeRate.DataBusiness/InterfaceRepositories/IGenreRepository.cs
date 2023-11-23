using AnimeRate.DataAccess.Models;

namespace AnimeRate.DataBusiness;
public interface IGenreRepository
{
    public List<Genre> GetAllGenre();
    public GenreRepository GetGenreByID(int id);
}
