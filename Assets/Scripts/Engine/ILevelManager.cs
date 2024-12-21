﻿using System;

namespace Engine
{
    public interface ILevelManager
    {
        event Action Loading;
        event Action<ILevel> Loaded;
        
        ILevel ActiveLevel { get; }
    }
}