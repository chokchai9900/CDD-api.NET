using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD_api.Tests
{
    public class IntegrationTestAppFactory<TStartup>
        : WebApplicationFactory<TStartup>  where TStartup : class
    {
    }

    //https://www.youtube.com/watch?v=YU3ohofu6UU
}
