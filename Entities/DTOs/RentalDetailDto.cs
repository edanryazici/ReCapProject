﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool CarState { get; set; }
    }
}
