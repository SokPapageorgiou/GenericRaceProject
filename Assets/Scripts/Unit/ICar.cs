using UnityEngine;

namespace Unit
{
    public interface ICar
    {
        public float AMagnitude { get;}
        public float AMaxSpeed { get;}
        public float AMinInputSum { get;}
        
        public float BMagnitude { get;}
        public float BMaxSpeed { get;}
        public float BMaxInputSum { get;}

        public float AngularSpeed { get;}
        
        public Rigidbody Rigidbody { get;}
        public Transform Transform { get;}
    }
}