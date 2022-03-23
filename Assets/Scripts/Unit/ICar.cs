using UnityEngine;

namespace Unit
{
    public interface ICar
    {
        public float Magnitude { get;}
        public float MaxSpeed { get;}

        public float AngularSpeed { get;}
        
        public Rigidbody Rigidbody { get;}
        public Transform Transform { get;}
    }
}