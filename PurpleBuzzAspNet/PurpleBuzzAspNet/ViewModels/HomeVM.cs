using Microsoft.EntityFrameworkCore;
using PurpleBuzzAspNet.Models;

namespace PurpleBuzzAspNet.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
