using MediatR;

namespace GymManager.Application.Tickets.Commands.AddTicket;

public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
{
    public async Task<Unit> Handle(AddTicketCommand request, CancellationToken cancellationToken)
    {
        //var ticket = new Ticket();
        //ticket.Name = request.Name;

        return Unit.Value;
    }
}

