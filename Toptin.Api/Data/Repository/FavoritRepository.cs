﻿using Toptin.Api.Data.Interfaces;
using Toptin.Api.Models;
using Toptin.Api.Data.Repository.Base;

namespace Toptin.Api.Data.Repository
{
    public class FavoritRepository : RepositoryBase<Favorit> , IFavorit
    {
        public FavoritRepository(DataContext context) : base(context)
        {
        }
    }
}