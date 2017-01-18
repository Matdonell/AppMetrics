﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using App.Metrics.Data.Interfaces;

namespace App.Metrics.Interfaces
{
    public interface IBuildGaugeMetrics
    {
        IMetricValueProvider<double> Instance(Func<double> valueProvider);
    }
}