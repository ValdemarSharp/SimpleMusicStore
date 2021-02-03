using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Services
{
    public static class DbInitializeService
    {
        public static void Initialize(MusicStoreContext context)
        {
            if (!context.Firms.Any())
            {
                context.Firms.AddRange(
                    new Firm
                    {
                        Title = "Ibanez",
                        Description = "Description of Ibanez"
                    },
                    new Firm
                    {
                        Title = "Fender",
                        Description = "Description of Fender"
                    },
                    new Firm
                    {
                        Title = "Yamaha",
                        Description = "Description of Yamaha"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
