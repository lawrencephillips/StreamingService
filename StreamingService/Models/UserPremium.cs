﻿using System;

namespace StreamingService.Models
{
    public class UserPremium : UserBase
    {
        public override int FreeSongs { get; } = 3*5;
        public UserPremium(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {
            //FreeSongs = 3*5;
        }

        //public override void ResetRemainingSongsThisMonth()
        //{
        //    throw new NotImplementedException();
        //}
    }
}