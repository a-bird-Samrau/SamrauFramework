﻿using System;
using Core;
using Input;
using UnityEngine;
using Behaviour = Core.Behaviour;

namespace Player
{

    public abstract class PlayerCharacter : Behaviour,
        IControllable
    {
        public event Action<InputMode> InputModeChanged;
        public event Action<bool> InputModeEnableChanged;

        public void Construct()
        {
            OnConstruct();
        }

        public void BeginPlay()
        {
            OnBeginPlay();
        }

        protected virtual void OnConstruct()
        {
            
        }

        protected virtual void OnBeginPlay()
        {
            
        }
        
        protected void SetInputMode(InputMode mode)
        {
            CurrentInputMode = mode;
            InputModeChanged?.Invoke(mode);
        }

        protected void SetInputModeEnable(bool value)
        {
            InputModeEnableChanged?.Invoke(value);
        }

        public abstract void SetupInputComponent(IInputComponent inputComponent);
        
        public InputMode CurrentInputMode { get; private set; }
    }
}