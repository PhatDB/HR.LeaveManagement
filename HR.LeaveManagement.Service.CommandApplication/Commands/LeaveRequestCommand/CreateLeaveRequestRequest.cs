using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveRequest;
using HR.LeaveManagement.Service.CommandApplication.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Commands.LeaveRequestCommand
{
    public class CreateLeaveRequestRequest : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
