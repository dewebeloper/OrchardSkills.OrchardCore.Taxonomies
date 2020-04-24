﻿using OrchardCore.ContentManagement.Handlers;
using OrchardCore.Disqus.Models;
using System.Threading.Tasks;

namespace OrchardCore.Disqus.Handlers
{
    public class DisqusPartHandler : ContentPartHandler<DisqusPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, DisqusPart part)
        {
            // By default Comments are shown.
            part.ShowComments = true;

            return Task.CompletedTask;
        }
    }
}