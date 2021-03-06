﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class GlasMetric : IMetric
    {
        public static char[] alphabet = "аееиоуыэюя".ToCharArray();
        private string _info;
        public string Info { get => _info; set => _info=value; }

        public Task Analyse(IContent content)
        {
            int count = 0;
            foreach(var e in content.Content.ToString())
            {
                if (alphabet.Contains(char.ToLower(e))) count++;
            }
            Info = "Количество гласных букв: " + count + ";\n" ;
            return Task.CompletedTask;
        }
    }
}
