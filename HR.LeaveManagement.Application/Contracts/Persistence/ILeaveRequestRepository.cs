﻿using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveLeaveRequestWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? approvalStatus);
    }
}