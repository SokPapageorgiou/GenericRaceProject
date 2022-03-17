using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Values/Float", fileName = "NewFloatValue")]
    public class FloatValue : ScriptableObject
    {
        [SerializeField] private float value;

        public float Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
