﻿using HR.LeaveManagement.Service.CommandApplication.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto , ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
