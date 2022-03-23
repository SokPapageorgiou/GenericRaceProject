using Commons;
using Unit;
using UnityEngine;

namespace Drivers.Accelerations
{
    public class Acceleration : ISystemPhysical
    {
        public void FixedUpdate(ICar car, int touchNumbers)
        {
            AddForce(car, touchNumbers);
            ConstrainSpeed(car);
        }

        private void AddForce(ICar car, int touchNumbers)
        {
            if (touchNumbers == 2)
                car.Rigidbody.AddForce(car.Transform.forward * car.Magnitude, ForceMode.Acceleration);
        }

        private void ConstrainSpeed(ICar car)
        {
            if (car.Rigidbody.velocity.magnitude > car.MaxSpeed)
                car.Rigidbody.velocity = car.Rigidbody.velocity.normalized * car.MaxSpeed;
        }
    }
}