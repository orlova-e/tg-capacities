﻿using System;

namespace Content.Domain.Core.Interfaces
{
    public interface IHistorical
    {
        DateTime Created { get; set; }
        DateTime? Updated { get; set; }
        DateTime? Deleted { get; set; }
    }
}
