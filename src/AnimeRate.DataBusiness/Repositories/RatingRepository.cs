using AnimeRate.DataAccess.Models;
using System.Linq; 

namespace AnimeRate.DataBusiness;
public class RatingRepository
{
    private readonly AnimeRateContext _DBContext;
    public RatingRepository(AnimeRateContext animeRateContext){
        _DBContext = animeRateContext;
    }

    public List<Rating> GetAllRating(){
        var query = from rating in _DBContext.Ratings
                    select rating;
        return query.ToList();
    }
}
