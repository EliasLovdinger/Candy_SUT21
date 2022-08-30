using Candy_SUT21.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Candy_SUT21.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
