using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveType;
using HR.LeaveManagement.Service.CommandApplication.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Commands.LeaveTypeCommand
{
    public class CreateLeaveTypeRequest : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
