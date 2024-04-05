using FluentValidation;
using HR.LeaveManagement.Service.CommandApplication.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Validators.LeaveTypeValidator
{
    public class UpdateLeaveTypeDtoValidator : AbstractValidator <LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} must be present.");
        }
    }
}
