﻿using AutoMapper;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IKlijentService : IReadService<Model.Klijent, Model.SearchObjects.KlijentSearchObject>
    {
    }
}
