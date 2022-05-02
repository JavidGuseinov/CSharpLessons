using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerSevice
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Register(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer registered.");

            }
            else
            {
                Console.WriteLine("Gamer not registered. Check your details please");

            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");

        }
    }
}
