using FluentValidation;
using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Validators.LeaveTypeValidator
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator() 
        { 
            Include(new ILeaveTypeDtoValidator());
        }
    }
}
