﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Models.AppointmentModels
{
    public class AppointmentEdit
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Time { get; set; }
        public string ServiceRequest { get; set; }

    }
}
