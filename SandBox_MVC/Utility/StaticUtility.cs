using Microsoft.AspNetCore.Mvc.Rendering;

namespace SandBox_MVC.Utility
{
    public static class StaticUtility
    {

        public static IEnumerable<SelectListItem> GetConference()
        {
            List<SelectListItem> conference = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "SWAC", Value = "SWAC" },
                new SelectListItem() { Text = "ACC", Value = "ACC" },
                new SelectListItem() { Text = "PAC-12", Value = "PAC-12" },
                new SelectListItem() { Text = "SEC", Value = "SEC" },
                new SelectListItem() { Text = "C-USA", Value = "C-USA" },


            };
            return conference;


        }


      
       
    }
}
