using System;
using Sirenix.OdinInspector;

namespace MVP
{
    public sealed class CharacterStat
    {
        public event Action<int> OnValueChanged; 

        [ShowInInspector, ReadOnly]
        public string Name { get; private set; }

        [ShowInInspector, ReadOnly]
        public int Value { get; private set; }

        public CharacterStat(string name, int value)
        {
            Name = name;
            Value = value;
        }
        
        [Button]
        public void ChangeValue(int value)
        {
            Value = value;
            OnValueChanged?.Invoke(value);
        }
    }
}