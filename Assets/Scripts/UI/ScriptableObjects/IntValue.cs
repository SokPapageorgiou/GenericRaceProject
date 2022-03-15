using UnityEngine;

namespace UI.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Values/Int", fileName = "NewIntValue")]
    public class IntValue : ScriptableObject
    {
        [SerializeField] private int value;

        public int Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
