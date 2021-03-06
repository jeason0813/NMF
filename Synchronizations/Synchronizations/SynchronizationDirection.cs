﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMF.Synchronizations
{
    public enum SynchronizationDirection
    {
        LeftToRight,
        RightToLeft,
        LeftToRightForced,
        RightToLeftForced,
        LeftWins,
        RightWins
    }

    public static class SynchronizationDirectionExtensions
    {
        public static bool IsLeftToRight(this SynchronizationDirection direction)
        {
            return direction == SynchronizationDirection.LeftToRight || direction == SynchronizationDirection.LeftToRightForced || direction == SynchronizationDirection.LeftWins;
        }

        public static bool IsRightToLeft(this SynchronizationDirection direction)
        {
            return direction == SynchronizationDirection.RightToLeft || direction == SynchronizationDirection.RightToLeftForced || direction == SynchronizationDirection.RightWins;
        }
    }
}
