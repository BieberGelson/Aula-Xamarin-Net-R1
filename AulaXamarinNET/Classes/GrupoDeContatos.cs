using System;
using System.Collections.Generic;
using System.Text;

namespace AulaXamarinNET
{
    public class GrupoDeContatos : List<Contato>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public GrupoDeContatos(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
