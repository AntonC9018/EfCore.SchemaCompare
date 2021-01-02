﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Chapter09ViewUsage
{
    public class UserPart2
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }
        public string City { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }
    }
}