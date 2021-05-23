using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Yaona
{
    class Globals
    {
        private List<DeskQuote> _deskquotes;

        public Globals()
        {
            _deskquotes = new List<DeskQuote>();
        }

        public List<DeskQuote> Quote
        {
            get => _deskquotes;
            set => _deskquotes = value;
        }
    }
}
