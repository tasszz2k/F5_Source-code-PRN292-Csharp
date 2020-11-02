using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DVDLibrary
    {
        private int code;
        private string title;
        private string language;
        private bool subtitles;
        private float price;

        public DVDLibrary()
        {
        }

        public DVDLibrary(int code, string title, string language, bool subtitles, float price)
        {
            this.code = code;
            this.title = title;
            this.language = language;
            this.subtitles = subtitles;
            this.price = price;
        }

        public DVDLibrary(string title, string language, bool subtitles, float price)
        {
            this.title = title;
            this.language = language;
            this.subtitles = subtitles;
            this.price = price;
        }

        public int Code
        {
            get => code;
            set => code = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Language
        {
            get => language;
            set => language = value;
        }

        public bool Subtitles
        {
            get => subtitles;
            set => subtitles = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }
    }
}
