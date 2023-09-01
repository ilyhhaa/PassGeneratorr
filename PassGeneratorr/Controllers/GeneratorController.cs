using Microsoft.AspNetCore.Mvc;
using PassGenerator.Models;
using System.Text;

namespace PassGenerator.Controllers
{
    public class GeneratorController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Generate (PassModel model, Random random)
        {
            
            var AlphToCharArray = model.chars.ToCharArray();

           List<char> chars = new List<char>();

            for (int i = 0; i < model.size; i++)
            {
                int num = random.Next(0, AlphToCharArray.Length);

                chars.Add(AlphToCharArray[num]);

            }

            var res = chars.ToString();
            model.GeneratingPass = res;

            
            return View(res);


            
            
        }
    }
}
