using MediatR;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
{
    public async Task<TicketDto> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
    {
        //pobieranie danych
        return new TicketDto { Id = request.Id, Name = "Def" };
    }
}

