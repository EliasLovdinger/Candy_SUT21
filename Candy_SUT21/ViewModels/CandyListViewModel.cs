using Candy_SUT21.Models;
using System.Collections.Generic;

namespace Candy_SUT21.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
