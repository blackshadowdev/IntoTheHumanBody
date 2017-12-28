using System;
using System.Reflection;
using UnityEngine;

    public abstract class Target : MonoBehaviour
    {
        public abstract String GetTargetType();
        public abstract void OnLookStart();
        public abstract void OnLookUpdate();
        public abstract void OnLookEnd();
    }
