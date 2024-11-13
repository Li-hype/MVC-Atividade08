using Atividade08_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade08_MVC.Controllers
{
    public class EletroDomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> dispositivos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Eletrolux", Modelo = "Top Freezer 382L Frost Free 2 Portas Branco TF42", ConsumoEnergetico = 350, TemFreezer = true, CapacidadeLitros = 382 },
                new Televisor {Marca = "LG", Modelo = "Smart TV TV LED 43\" LG Full HD Netflix 43LJ5550 2 HDMI", ConsumoEnergetico = 12, EhSmart = true, TamanhoTela = 43},
                new Televisor {Marca = "Sansung", Modelo = "Smart TV 65” UHD 4K LED Samsung 65CU7700 - Wi-Fi Bluetooth Alexa 3 HDMI", ConsumoEnergetico = 27, EhSmart = true, TamanhoTela = 65 }
            };
            return View(dispositivos);
        }
    }
}
