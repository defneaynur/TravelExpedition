using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Config.Config;

public interface IConfigProject
{
    public ApiInformations ApiInformations { get; set; }
}

