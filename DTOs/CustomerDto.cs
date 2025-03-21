﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MemberShipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}