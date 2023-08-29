using Microsoft.AspNetCore.Mvc;
using PassGenerator.Models;
using System.Text;

namespace PassGenerator.Controllers
{
    public class GeneratorController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Generate (PassModel model, Random random)
        {
            
            var AlphToCharArray = model.chars.ToCharArray();

           

            for (int i = 0; i < model.size; i++)
            {
                int num = random.Next(0, AlphToCharArray.Length);

                model.ResultCharsList.Add(AlphToCharArray[num]);

            }
            
            return View(model);


            
            
        }
    }
}
