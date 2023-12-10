using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Modules.Users;
using Shared.Contracts.Modules.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Users.Features;

[ApiController]
[Produces("application/json")]
[Route("api/user")]
public class CreateUserController : ControllerBase
{
    private readonly IMediator mediator;

    public CreateUserController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateUserCommand createUser)
    {
        await this.mediator.Send(createUser);

        return Ok("Ok");
    }
}

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IMediator mediator;

    public CreateUserCommandHandler(IMediator mediator)
    {
        this.mediator = mediator;
    }

    async Task<bool> IRequestHandler<CreateUserCommand, bool>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Create User Command : {request.Id}");

        await this.mediator.Send(new CreateWalletCommand()
        {
            UserId = request.Id,
            Name = "Wallet_Name"
        });

        return true;
    }
}