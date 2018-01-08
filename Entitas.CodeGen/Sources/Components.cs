using Entitas;
using UnityEngine;

namespace CodeGen
{
    [Game]
    public class Position : IComponent
    {
        public Vector3 Location;
        public float Rotation;
    }

    [Game]
    public class Velocity : IComponent
    {
        public Vector3 Linear;
        public float Angular;
    }
}