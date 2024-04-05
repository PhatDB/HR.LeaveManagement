using AutoMapper;
using HR.LeaveManagement.Service.CommandApplication.Commands.LeaveTypeCommand;
using HR.LeaveManagement.Service.CommandApplication.Contracts.Presistence;
using HR.LeaveManagement.Service.CommandApplication.Exceptions;
using HR.LeaveManagement.Service.CommandApplication.Responses;
using HR.LeaveManagement.Service.CommandApplication.Validators.LeaveTypeValidator;
using HR.LeaveManagement.Service.CommandDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Handlers.LeaveTypeHandler
{
    public class CreateLeaveTypeRequestHandler : IRequestHandler<CreateLeaveTypeRequest, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveType.Id;

            return response;
        }
    }
}
