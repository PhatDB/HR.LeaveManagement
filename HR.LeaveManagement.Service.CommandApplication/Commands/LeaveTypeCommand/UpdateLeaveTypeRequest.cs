using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Commands.LeaveTypeCommand
{
    public class UpdateLeaveTypeRequest : IRequest<Unit>
    {
        public LeaveTypeDto leaveTypeDto {  get; set; }
    }
}
