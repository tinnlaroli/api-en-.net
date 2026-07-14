using Application.Common.Response;
using MediatR;

namespace Application.Features.User.Query.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<ApiResponse>
    {
    }
}
