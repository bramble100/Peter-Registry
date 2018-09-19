using Peter_Registry.Services;
using System;

namespace Peter_Registry.Controllers
{
    internal class Controller
    {
        internal string ShowAll()
        {
            return new RegistryService().Registry.ToString();
        }
    }
}
