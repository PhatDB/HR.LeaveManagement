using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Commands.LeaveAllocationCommand
{
    public class DeleteLeaveAllocationRequest :IRequest
    {
        public int Id { get; set; }
    }
}
