﻿using System;

namespace Mi899.Data
{
    public interface IBios
    {
        string Id { get; }
        string Name { get; }
        string[] MotherboardIds { get; }
        string Description { get; }
        string[] Tags { get; }
        string TagsString { get; }
        string FileName { get; }
        string TurboUnlockDriver { get; }
        bool IsTurboUnlocked { get; }
        string[] Chipsets { get; }
    }
}