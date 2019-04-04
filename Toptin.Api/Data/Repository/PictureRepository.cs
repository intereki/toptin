﻿using Toptin.Api.Data.Interfaces;
using Toptin.Api.Models;
using Toptin.Api.Data.Repository.Base;

namespace Toptin.Api.Data.Repository
{
    public class PictureRepository : RepositoryBase<Picture> , IPicture
    {
        public PictureRepository(DataContext context) : base(context)
        {
        }
    }
}