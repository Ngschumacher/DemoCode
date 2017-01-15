﻿// Copyright 2016 Jon Skeet. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;

public class MemoryModelInsanity2
{
    public event EventHandler Click;

    protected void OnClick1()
    {
        if (Click != null)
        {
            Click(this, EventArgs.Empty);
        }
    }

    protected void OnClick2()
    {
        var handler = Click;
        if (handler != null)
        {
            handler(this, EventArgs.Empty);
        }
    }

    protected void OnClick3()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}