using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    interface IMetric
    {
        string Info { get; set; }
        Task Analyse(IContent content);
    }
}
