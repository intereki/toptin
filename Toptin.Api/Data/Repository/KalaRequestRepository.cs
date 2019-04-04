﻿using Toptin.Api.Data.Interfaces;
using Toptin.Api.Models;
using Toptin.Api.Data.Repository.Base;

namespace Toptin.Api.Data.Repository
{
    public class KalaRequestRepository : RepositoryBase<KalaRequest> , IKalaRequest
    {
        public KalaRequestRepository(DataContext context) : base(context)
        {
        }
    }
}