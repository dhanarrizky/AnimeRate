using AnimeRate.DataAccess.Models;

namespace AnimeRate.DataBusiness;
public interface IRatingRepository
{
    public List<Rating> GetAllRating();
}
