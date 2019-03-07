using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model.Update
{
    public class UpdateFile
    {
        public enum Status
        {
            Current,
            Outdated,
            Missing
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
        public Status FileStatus { get; set; }

        public override string ToString()
        {
            return $"{Name} - [{Path}] ...{FileStatus}";
        }
    }

}
