﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingLibrary.UI
{
    public class UnreturnedBookViewModel
    {
        public Guid BookId { get; set; }

        public string BookName { get; set; }

        public string ISBN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime RentDate { get; set; }
    }
}