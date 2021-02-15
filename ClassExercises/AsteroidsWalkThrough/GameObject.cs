using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AsteroidsWalkThrough
{
    class GameObject
    {

        public Vector2 pos = new Vector2();
        public Vector2 dir = new Vector2();

        // A Getter function to calculate our rotation
        float GetRotation()
        {
            return MathF.Atan2(dir.Y, dir.X);
        }

        void SetRotation(float rot)
        {
            dir = new Vector2(
                MathF.Cos(rot * (MathF.PI / 180 / .0f)),
                MathF.Sin(rot * (MathF.PI / 180 / .0f))
            );
        }

        void Rotate(float amount)
        {
            float rot = GetRotation() + amount;
            SetRotation(rot);
        }
    }
}
