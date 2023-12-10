using MediatR;
using Shared.Contracts.Modules.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Modules.Users;

public class CreateUserRequestDTO
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public CreateWalletRequestDTO? Wallet { get; set; }
}

public class CreateUserCommand : CreateUserRequestDTO, IRequest<bool>
{
}