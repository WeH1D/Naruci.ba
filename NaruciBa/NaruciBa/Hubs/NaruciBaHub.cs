using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using NaruciBa.Database;
using NaruciBa.Mapping;

namespace NaruciBa.Hubs
{
    public class NaruciBaHub : Hub
    {
        private readonly IMapper _mapper;
        private readonly NaruciBaContext _context;
        public NaruciBaHub(IMapper mapper, NaruciBaContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Task> UpdateNarudzba(int narudzbaId, int statusId)
        {
            Services.NarudzbaService service = new Services.NarudzbaService(_context, _mapper);
            await service.Update(
                narudzbaId, 
                new Model.Requests.NarudzbaUpsertRequest { 
                    NarudzbaStatusID = statusId 
                }
            );
            return Clients.All.SendAsync("UpdateNarudzba", true);
        }

        public Task NarudzbaUpdateovana()
        {
            return Clients.All.SendAsync("NarudzbaUpdateovana");
        }
    }
}
