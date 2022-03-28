using Commons;
using Unit;
using UnityEngine;

namespace Drivers.Accelerations
{
    public class Acceleration : ISystemPhysical
    {
        public void FixedUpdate(ICar car, int touchNumbers, float inputSum, float inputThresholds)
        {
            AddForce(car, touchNumbers, inputSum, inputThresholds); 
            ConstrainSpeed(car, inputSum, inputThresholds);
        }

        private void AddForce(ICar car, int touchNumbers, float inputSum, float inputThresholds)
        {
            var magnitude = inputSum < inputThresholds ? car.AMagnitude : car.BMagnitude;
            
            if (touchNumbers == 2)
                car.Rigidbody.AddForce(car.Transform.forward * magnitude, ForceMode.Acceleration);
        }

        private void ConstrainSpeed(ICar car, float inputSum, float inputThresholds)
        {
            var maxSpeed = inputSum < inputThresholds ? car.AMaxSpeed : car.BMaxSpeed;
            
            if (car.Rigidbody.velocity.magnitude > maxSpeed)
                car.Rigidbody.velocity = car.Rigidbody.velocity.normalized * maxSpeed;
        }
    }
}