using ScriptableObjects;
using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        [Header("Inputs")] 
        [SerializeField] private BoolValue isTouchingLeft;
        [SerializeField] private BoolValue isTouchingRight;
        [SerializeField] private FloatValue joystickLeftOutput;
        [SerializeField] private FloatValue joystickRightOutput;

        [Header("Dependencies")] 
        [SerializeField] private Rigidbody rigidBody;
    }
}
