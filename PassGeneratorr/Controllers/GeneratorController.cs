using Microsoft.AspNetCore.Mvc;
using PassGenerator.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PassGenerator.Controllers
{
    public class GeneratorController : Controller
    {

        public async Task Generate ()
        {

            string form = @"<form method='post'>
                
               
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(form);
        }


        [HttpPost]
        public string Generate(PassModel model, Random random,List<char> values)
        {
            var AlphToCharArray = model.chars.ToCharArray();

            string result = " ";

            for (int i = 0; i <= model.size; i++)
            {
                int num = random.Next(0, AlphToCharArray.Length);

                values.Add(AlphToCharArray[num]);

                result += values[i];
            }
            
            return result;

        }


    }
    
}





