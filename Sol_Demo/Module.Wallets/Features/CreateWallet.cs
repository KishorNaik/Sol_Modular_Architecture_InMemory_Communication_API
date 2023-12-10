using MediatR;
using Shared.Contracts.Modules.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Wallets.Features;

public class CreateWalletCommandHandler : IRequestHandler<CreateWalletCommand, bool>
{
    async Task<bool> IRequestHandler<CreateWalletCommand, bool>.Handle(CreateWalletCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Create Wallet Request: {request.UserId}");

        return true;
    }
}