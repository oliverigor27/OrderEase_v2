using FluentValidation.Results;
using MediatR;

namespace OrderEase.ClientService.Application;

public interface IBaseCommand : IRequest<ValidationResult>
{

}
