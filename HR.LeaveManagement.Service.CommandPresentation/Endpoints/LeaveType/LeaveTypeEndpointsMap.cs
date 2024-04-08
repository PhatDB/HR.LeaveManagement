using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandPresentation.Endpoints.LeaveType
{
    public static class LeaveTypeEndpointsMap
    {
        public static IEndpointRouteBuilder MapLeaveTypeEndpoints(this IEndpointRouteBuilder app)
        {
            var leavetype = app.MapGroup("api/leavetype");
            leavetype.MapPost("/", LeaveTypeEndpoints.Post).WithName("CreateLeaveType");
            leavetype.MapPut("/{id}", LeaveTypeEndpoints.Put).WithName("UpdateLeaveType");
            leavetype.MapDelete("/{id}", LeaveTypeEndpoints.Delete).WithName("DeleteLeaveType");
            return app;
        }
    }
}
