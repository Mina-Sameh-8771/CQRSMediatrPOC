using CQRSMediatrPOC.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRSMediatrPOC.Queries
{
    public record GetEmployeeListQuery():IRequest<List<EmployeeModel>>;
}
