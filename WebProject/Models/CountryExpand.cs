using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public partial class Country
    {
        public int No { get; set; }
        public int GoldNumber => Athletes.Sum(a=>a.MedalLists.Count(x=>x.MedalType == 1));
        public int SilverNumber => Athletes.Sum(a=>a.MedalLists.Count(x=>x.MedalType == 2));
        public int BronzeNumber => Athletes.Sum(a=>a.MedalLists.Count(x=>x.MedalType == 3));
        public int TotalNumber => Athletes.Sum(a => a.MedalLists.Count());
    }
}