using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilmManagement
{
    class CFilm
    {
        private String sName;
        private Double dLength;
        private String sProducter;
        private Double dPrice;
        private Double dNumber;
        private Double dTotal;

        public CFilm()
        {
            this.sProducter = "FaFilm";
            this.dPrice = 8000;
            this.dNumber = 10;
        }

        public CFilm(string sName, double dLength, string sProducter, double dPrice, double dNumber)
        {
            this.sName = sName;
            this.dLength = dLength;
            this.sProducter = sProducter;
            this.dPrice = dPrice;
            this.dNumber = dNumber;
            this.dTotal = dPrice * dNumber;
        }

        public string SName
        {
            get => sName;
            set => sName = value;
        }

        public double DLength
        {
            get => dLength;
            set => dLength = value;
        }

        public string SProducter
        {
            get => sProducter;
            set => sProducter = value;
        }

        public double DPrice
        {
            get => dPrice;
            set => dPrice = value;
        }

        public double DNumber
        {
            get => dNumber;
            set => dNumber = value;
        }

        public double DTotal
        {
            get => dTotal;
            set => dTotal = value;
        }

        public override string ToString()
        {
            return $"{nameof(SName)}: {SName}, {nameof(DLength)}: {DLength}, {nameof(SProducter)}: {SProducter}, {nameof(DPrice)}: {DPrice}, {nameof(DNumber)}: {DNumber}, {nameof(DTotal)}: {DTotal}";
        }
    }
}
