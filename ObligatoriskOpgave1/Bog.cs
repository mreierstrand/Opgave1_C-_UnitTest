using System;

namespace ObligatoriskOpgave1
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string Forfatter
        {
            get { return _forfatter; }
            set
            {
                if (_forfatter.Length <2 )
                {
                    throw new IndexOutOfRangeException("Forfatternavn er for kort");
                }

                if (_forfatter.Length >= 2)
                    _forfatter = value;
            }
        }
        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                if (_sidetal >= 4 && _sidetal <= 1000)
                {
                    _sidetal = value;
                }
                if (_sidetal < 4)
                    throw new Exception("Sideantallet er for småt");
                
                if (_sidetal > 1000)
                    throw new Exception("Sideantallet er for stort");
            }
        }

        public string ISBN13
        {
            get { return _isbn13; }
            set
            {
                if (_isbn13.Length <13)
                    throw new Exception("ISBN-nummer er for kort");

                if (_isbn13.Length >13)
                    throw new Exception("ISBN-Nummer er for langt");
                else
                {
                    _isbn13 = value;
                }
            }
        }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public Bog()
        {

        }
    }
}
