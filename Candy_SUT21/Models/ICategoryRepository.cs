using System.Collections.Generic;

namespace Candy_SUT21.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory { get; }
    }
}
