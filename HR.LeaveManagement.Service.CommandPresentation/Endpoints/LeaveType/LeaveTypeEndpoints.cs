using HR.LeaveManagement.Service.CommandApplication.Commands.LeaveTypeCommand;
using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveType;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandPresentation.Endpoints.LeaveType
{
    [Route("api/[controller]")]
    [ApiController]
    public  class LeaveTypeEndpoints : ControllerBase
    {
        [HttpPost]
        public static async Task<IResult> Post([FromBody] CreateLeaveTypeDto leaveType, IMediator mediator)
        {
            var command = new CreateLeaveTypeRequest { LeaveTypeDto = leaveType };
            return TypedResults.Ok(await mediator.Send(command));
        }

        [HttpPut]
        public static async Task<IResult> Put(int id, [FromBody] LeaveTypeDto leaveType, IMediator mediator)
        {
            var command = new UpdateLeaveTypeRequest { leaveTypeDto = leaveType };
            return TypedResults.Ok(await mediator.Send(command));
        }
        [HttpDelete]
        public static async Task<IResult> Delete(int id, IMediator mediator)
        {
            var command = new DeleteLeaveTypeRequest { Id = id };
            return TypedResults.Ok(await mediator.Send(command));
        }
    }
}
