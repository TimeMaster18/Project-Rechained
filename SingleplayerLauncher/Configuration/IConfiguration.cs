using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleplayerLauncher.Configuration
{
    public interface IConfiguration
    {
        void Load();
        void Save();
    }

}
