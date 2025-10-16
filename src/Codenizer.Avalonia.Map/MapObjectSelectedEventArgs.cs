// Copyright (c) 2025 Codenizer BV
// Licensed under GNU General Public License v3.0
// See LICENSE or https://choosealicense.com/licenses/gpl-3.0/

using SkiaSharp;

namespace Codenizer.Avalonia.Map;

public class MapObjectSelectedEventArgs : EventArgs
{
    public MapObject MapObject { get; }

    public SKPoint MapPosition { get; }

    public MapObjectSelectedEventArgs(MapObject mapObject, SKPoint mapPosition)
    {
        MapObject = mapObject;
        MapPosition = mapPosition;
    }
}
