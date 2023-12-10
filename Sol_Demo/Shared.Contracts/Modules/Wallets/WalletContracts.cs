using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Modules.Wallets
{
    public class CreateWalletRequestDTO
    {
        public int UserId { get; set; }

        public string Name { get; set; }
    }

    public class CreateWalletCommand : CreateWalletRequestDTO, IRequest<bool>
    {
    }
}