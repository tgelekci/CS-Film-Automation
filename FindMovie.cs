using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections;


namespace FilmOtomasyonu
{
    public class FindMovie : IComparable<FindMovie>
    {
        private string ad;
        public string Ad
        {
            get { return ad; }

        }

        private string tur;
        public string Tur
        {
            get { return tur; }

        }

        private int cikisYili;

        public int CikisYili
        {
            get { return cikisYili; }


        }

        private Boolean kiralandimi;

        public Boolean Kiralandimi
        {
            get { return kiralandimi; }

        }

        public FindMovie(string name, string type, int year, Boolean isRented)
        {
            ad = name;
            tur = type;
            cikisYili = year;
            kiralandimi = isRented;
        }

        public int CompareTo(FindMovie other)
        {
            return ad.CompareTo(other.ad);
            
        }
    }
}
