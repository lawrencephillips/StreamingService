﻿using System;

namespace StreamingService.Models
{
    public class UnlimittedUser : UserBase
    {
        public sealed override int FreeSongs { get; } = int.MaxValue;
        public UnlimittedUser(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {
            //FreeSongs = int.MaxValue;
        }

        //public override void ResetRemainingSongsThisMonth()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
