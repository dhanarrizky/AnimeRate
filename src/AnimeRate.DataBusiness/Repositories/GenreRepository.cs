using AnimeRate.DataAccess.Models;
using System.Linq;

namespace AnimeRate.DataBusiness;
public class GenreRepository
{
    private readonly AnimeRateContext _DBContext;
    public GenreRepository(AnimeRateContext animeRateContext){
        _DBContext = animeRateContext;
    }

    public List<Genre> GetAllGenre(){
        var query = from genre in _DBContext.Genres
                    select genre;
        return query.ToList();
    }

    public Genre GetGenreByID(int id){
        return _DBContext.Genres.FirstOrDefault(g => g.Id == id)??
            throw new KeyNotFoundException("Genre id not found");
    }

}
