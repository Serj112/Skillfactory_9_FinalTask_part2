using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LastNames
{
    public string lastname;

    public LastNames(string lastname)
    {
        this.lastname = lastname;
    }

    public override string ToString()
    {
        return "[" + lastname + "]";
    }
}
