using AutoMapper;
using HR.LeaveManagement.Service.CommandApplication.Commands.LeaveTypeCommand;
using HR.LeaveManagement.Service.CommandApplication.Contracts.Presistence;
using HR.LeaveManagement.Service.CommandApplication.Exceptions;
using HR.LeaveManagement.Service.CommandApplication.Validators.LeaveTypeValidator;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandApplication.Handlers.LeaveTypeHandler
{
    public class UpdateLeaveTypeRequestHandler : IRequestHandler<UpdateLeaveTypeRequest, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.leaveTypeDto);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult);

            var leaveType = await _leaveTypeRepository.Get(request.leaveTypeDto.Id);

            _mapper.Map(request.leaveTypeDto, leaveType);

            await _leaveTypeRepository.Update(leaveType);

            return Unit.Value;
        }
    }
}
