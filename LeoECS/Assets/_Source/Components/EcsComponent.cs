using System;
using UnityEngine;

namespace Client 
{
    [Serializable]
    public struct EcsComponent
    {
        public float Counter;
        public Transform Anchor;
        public float Anplituda;
        public float Speed;
    }
}