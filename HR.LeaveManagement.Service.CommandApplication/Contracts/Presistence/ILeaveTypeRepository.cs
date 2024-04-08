using HR.LeaveManagement.Service.CommandDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Contracts.Presistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
