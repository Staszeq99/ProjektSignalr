using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Rysowanko.Startup))]

namespace Rysowanko
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Aby uzyskać więcej informacji o sposobie konfigurowania aplikacji, odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
