using Application.common.interfaces;
using Application.Common.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.User.Query.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, ApiResponse>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetAllUsersQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _dbContext.Users.ToListAsync(cancellationToken);
            return ApiResponse.Success(users, "Lista de users");
        }
    }
}
