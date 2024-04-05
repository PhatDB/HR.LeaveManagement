using AutoMapper;
using HR.LeaveManagement.Service.CommandApplication.Commands.LeaveAllocationCommand;
using HR.LeaveManagement.Service.CommandApplication.Contracts.Presistence;
using HR.LeaveManagement.Service.CommandApplication.Exceptions;
using HR.LeaveManagement.Service.CommandApplication.Responses;
using HR.LeaveManagement.Service.CommandApplication.Validators.LeaveAllocationValidator;
using HR.LeaveManagement.Service.CommandApplication.Validators.LeaveRequestValidator;
using HR.LeaveManagement.Service.CommandDomain.Entities;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Handlers.LeaveAllocationHandler
{
    public class CreateLeaveAllocationRequestHandler : IRequestHandler<CreateLeaveAllocationRequest, BaseCommandResponse>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveAllocationRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveAllocationDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveAllocationDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);

            leaveAllocation =  await _leaveAllocationRepository.Add(leaveAllocation);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveAllocation.Id;

            return response;
        }
    }
}
