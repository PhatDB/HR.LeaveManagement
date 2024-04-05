using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Commands.LeaveAllocationCommand
{
    public class CreateLeaveAllocationRequest : IRequest<int>
    {
        public CreateLeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
