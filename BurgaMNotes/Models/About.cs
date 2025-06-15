using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgaMNotes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
    }
}
