using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Register(new Gamer
            {
                DateOfBirth = 1998,
                FirstName = "Javid",
                LastName = "Guseinov",
                IdentityNumber = 12345

            });
        }
    }
}
