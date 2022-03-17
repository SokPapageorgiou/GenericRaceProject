using UnityEngine;

namespace UI.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Values/Bool", fileName = "NewBoolValue")]
    public class BoolValue : ScriptableObject
    {
        [SerializeField] private bool value;

        public bool Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
