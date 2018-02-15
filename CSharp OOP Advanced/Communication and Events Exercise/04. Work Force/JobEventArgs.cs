﻿using System;
using System.Collections.Generic;
using System.Text;

public class JobEventArgs : EventArgs
{
    public JobEventArgs(Job job)
    {
        this.job = job;
    }

    public Job job { get; private set; }
}
