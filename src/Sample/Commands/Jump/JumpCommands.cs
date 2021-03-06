﻿using CommandRouting;
using CommandRouting.Config;

namespace Sample.Commands.Jump
{
    public class JumpCommands: IRouteSet
    {
        public void Configure(ICommandRouteBuilder builder)
        {
            builder
                .Get("")
                .As<JumpRequest>()
                .RoutesTo<Seargent, Private>();
        }
    }
}
