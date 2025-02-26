﻿// The MIT License(MIT)
//
// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using LiveChartsCore.Drawing;

namespace LiveChartsCore.Geo;

/// <summary>
/// Defines a map factory.
/// </summary>
public interface IMapFactory<TDrawingContext> : IDisposable
    where TDrawingContext : DrawingContext
{
    /// <summary>
    /// Updates the lands.
    /// </summary>
    /// <param name="context"></param>
    void GenerateLands(MapContext<TDrawingContext> context);

    /// <summary>
    /// Fetches the map elements.
    /// </summary>
    /// <param name="context">The map context.</param>
    [Obsolete]
    IEnumerable<IMapElement> FetchMapElements(MapContext<TDrawingContext> context);

    /// <summary>
    /// Move the map to the specified view.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="command">The command.</param>
    void ViewTo(GeoMap<TDrawingContext> sender, object? command);

    /// <summary>
    /// Pans the map.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="delta">The delta.</param>
    void Pan(GeoMap<TDrawingContext> sender, LvcPoint delta);
}
