﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CMS.DAL.Models;

namespace CMS.BL.ViewModels
{
    public class ViewEmployments
    {
        public ViewEmployments()
        {
            ViewSchedules = new HashSet<ViewSchedules>();
        }
        public Guid GuId { get; set; }
        public string EmploymentName { get; set; }
        public string Price { get; set; }
        public double? MakingTime { get; set; }
        public int CustomerId { get; set; }

        public Customers Customer { get; set; }
        public ICollection<ViewSchedules> ViewSchedules { get; set; }
    }
}
