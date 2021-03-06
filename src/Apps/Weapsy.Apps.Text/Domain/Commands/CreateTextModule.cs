﻿using System;
using Weapsy.Domain;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Apps.Text.Domain.Commands
{
    public class CreateTextModule : BaseSiteCommand
    {
        public Guid ModuleId { get; set; }
        public Guid Id { get; set; }
        public string Content { get; set; }
    }
}
