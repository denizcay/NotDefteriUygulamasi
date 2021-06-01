using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi
{
    public class Not:IComparable
    {
        public Not()
        {

        }
        public Not(string icerik)
        {
            AktiviteMetin = icerik;
        }
        public string AktiviteMetin { get; set; }
        public DateTime Zaman { get; set; }
        public string Isaret { get; set; } = "";

        public int CompareTo(object diger)
        {
            Not digerNot = (Not)diger;

            return -Zaman.CompareTo(digerNot.Zaman);
        }

        public override string ToString()
        {
            string tarih = Zaman.Date == DateTime.Now.Date
                ? Zaman.ToString("HH:mm")
                : Zaman.ToString("dd.MM.yyyy  HH:mm");
            return $"{tarih} {AktiviteMetin} {Isaret} ";
        }
    }
}
