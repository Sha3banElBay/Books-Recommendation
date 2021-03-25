using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public interface Person
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}