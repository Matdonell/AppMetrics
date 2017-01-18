﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using App.Metrics.Core.Interfaces;
using App.Metrics.Core.Options;

namespace App.Metrics.Interfaces
{
    public interface IMeasureCounterMetrics
    {
        /// <summary>
        ///     Decrements a <see cref="ICounterMetric" />
        /// </summary>
        /// <param name="options">The details of the counter that is being decremented</param>
        void Decrement(CounterOptions options);

        /// <summary>
        ///     Decrements a <see cref="ICounterMetric" /> by the specificed amount
        /// </summary>
        /// <param name="options">The details of the counter that is being decremented</param>
        /// <param name="amount">The amount to decrement the counter.</param>
        void Decrement(CounterOptions options, long amount);

        /// <summary>
        ///     Decrements the specified options.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="item">The item.</param>
        void Decrement(CounterOptions options, string item);

        /// <summary>
        ///     Decrements the specified options.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="item">The item.</param>
        void Decrement(CounterOptions options, long amount, string item);

        /// <summary>
        ///     Decrements a <see cref="ICounterMetric" /> as well as the specified item within the counter's set
        /// </summary>
        /// <remarks>
        ///     The counter value is decremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        /// <param name="options">The details of the counter that is being decremented</param>
        /// <param name="item">The item within the set to decrement.</param>
        void Decrement(CounterOptions options, Action<MetricItem> item);

        /// <summary>
        ///     Decrements a <see cref="ICounterMetric" /> by the specified amount as well as the specified item within the
        ///     counter's set
        /// </summary>
        /// <param name="options">The details of the counter that is being decremented</param>
        /// <param name="amount">The amount to decrement the counter.</param>
        /// <param name="item">The item within the set to decrement.</param>
        /// <remarks>
        ///     The counter value is decremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        void Decrement(CounterOptions options, long amount, Action<MetricItem> item);

        /// <summary>
        ///     Increments a <see cref="ICounterMetric" />
        /// </summary>
        /// <param name="options">The details of the counter that is being incremented</param>
        void Increment(CounterOptions options);

        /// <summary>
        ///     Increments a <see cref="ICounterMetric" />
        /// </summary>
        /// <param name="options">The details of the counter that is being incremented</param>
        /// <param name="amount">The amount to decrement the counter.</param>
        void Increment(CounterOptions options, long amount);

        /// <summary>
        ///     Increments a <see cref="ICounterMetric" /> as well as the specified item within the counter's set
        /// </summary>
        /// <remarks>
        ///     The counter value is incremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        /// <param name="options">The details of the counter that is being incremented</param>
        /// <param name="item">The item within the set to increment.</param>
        void Increment(CounterOptions options, string item);

        /// <summary>
        ///     Increments a <see cref="ICounterMetric" /> as well as the specified item within the counter's set
        /// </summary>
        /// <remarks>
        ///     The counter value is incremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        /// <param name="options">The details of the counter that is being incremented</param>
        /// <param name="amount">The amount to increment the counter.</param>
        /// <param name="item">The item within the set to increment.</param>
        void Increment(CounterOptions options, long amount, string item);

        /// <summary>
        ///     Increment a <see cref="ICounterMetric" /> as well as the specified item within the counter's set
        /// </summary>
        /// <remarks>
        ///     The counter value is incremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        /// <param name="options">The details of the counter that is being incremented</param>
        /// <param name="item">The item within the set to increment.</param>
        void Increment(CounterOptions options, Action<MetricItem> item);

        /// <summary>
        ///     Increment a <see cref="ICounterMetric" /> by the specified amount as well as the specified item within the
        ///     counter's set
        /// </summary>
        /// <param name="options">The details of the counter that is being decremented</param>
        /// <param name="amount">The amount to increment the counter.</param>
        /// <param name="item">The item within the set to increment.</param>
        /// <remarks>
        ///     The counter value is incremented as is the specified <see cref="MetricItem" />'s counter within the set.
        ///     The <see cref="MetricItem" /> within the set will also keep track of it's percentage from the total sets count.
        /// </remarks>
        void Increment(CounterOptions options, long amount, Action<MetricItem> item);
    }
}