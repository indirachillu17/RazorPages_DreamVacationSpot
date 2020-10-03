﻿using Microsoft.VisualBasic;
using NJsonSchema.Validation.FormatValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class BåtHusetBokning
    {

        public int BåtHusetBokningID { get; set; }

        public int DiscoverBoatHouse { get; set; }
        public decimal BoatTripPrice { get; set; }
        public DateTime BoatTripDate { get; set; }
        public string BoatStartTime { get; set; }
        public string BoatEndTime { get; set; }
       
        public string OtherActivities { get; set; }
        public string ActivitiesTiming { get; set; }
        public string Restaurant { get; set; }
        public decimal PriceOfTicket { get; set; }

        public string Beverages { get; set; }

    }
}
