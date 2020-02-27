using System;

namespace ObligatoriskOpgave1
{
    public class Bog
    {
        private string _title;
        private string _forfatter;
        private int _sidetal;
        private int _isbn;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }
        public int Sidetal
        {
            get { return _sidetal; }
            set { _sidetal = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public Bog(string title, string forfatter, int sidetal, int isbn)
        {
            _title = title;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn = isbn;
        }

    }
}
