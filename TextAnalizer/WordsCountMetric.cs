using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class WordsCountMetric : IMetric
    {
        private string _info;
        public string Info { get => _info; set => _info=value; }

        public Task Analyse(IContent content)
        {
            Info = "Количество слов: " + content.Content.ToString().Split(' ').Length+";\n";
            return Task.CompletedTask;
        }
    }
}
