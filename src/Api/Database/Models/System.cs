using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class System
    {
        public int ID{ get; set; }
        public int EDDBID { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public int Population { get; set; }
        public int GovernmentID { get; set; }
        public int AllegianceID { get; set; }
        public int StateID { get; set; }
        public int SecurityID { get; set; }
        public int EconomyID { get; set; }
        public int ReserveID { get; set; }
        public int PowerStateID { get; set; }
        public int PowerID { get; set; }
        public bool IsPermitLocked { get; set; }
        public bool IsPopulated { get; set; }
        public long Updated { get; set; }
    }
}