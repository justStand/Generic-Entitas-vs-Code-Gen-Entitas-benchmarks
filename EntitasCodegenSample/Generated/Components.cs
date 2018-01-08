using Entitas;
using Entitas.Generic.CommonTestData;

namespace CodeGen
{
    public class Position : IComponent
    {
        public Vector3 Location;
        public float Rotation;
    }

    public class Velocity : IComponent
    {
        public Vector3 Linear;
        public float Angular;
    }
}