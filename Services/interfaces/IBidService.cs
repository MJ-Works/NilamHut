﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NilamHutAPI.Models;
using NilamHutAPI.ViewModels.PostRelated;
using NilamHutAPI.ViewModels.FrontEnd;

namespace NilamHutAPI.Services.interfaces
{
    public interface IBidService
    {
        Task<IEnumerable<Bid>> Get();
        Task<Bid> Get(Guid id);
        Task<string> Post(BidViewModel bidFromView);
        Task<string> Put(Guid id, BidViewModel bidFromView);
        Task<string> PutToSoldHistory(BidViewModel bidFromView);
        Task<bool> Delete(Guid id);
        Task<BidFrontEnd> BidForProductView(Guid id);
    }
}
