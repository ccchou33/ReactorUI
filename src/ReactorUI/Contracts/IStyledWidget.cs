﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReactorUI.Contracts
{
    public interface IStyledWidget<TS>
    {
        void SetStyle(TS styleToApply);
    }
}
