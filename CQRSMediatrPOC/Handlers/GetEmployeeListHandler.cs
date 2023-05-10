using CQRSMediatrPOC.Data;
using CQRSMediatrPOC.Models;
using CQRSMediatrPOC.Queries;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatrPOC.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess dataAccess;

        public GetEmployeeListHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetEmployees());
        }
    }


}
