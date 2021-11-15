using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication.Models
{
    public class AppSettings
    {
        public string Secret { get; }

        public TimeSpan Expiration { get; }

    }
}
