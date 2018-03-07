using System;

namespace BBG.Variables
{
    [Serializable]
    public class IntReference
    {
        public bool UseConstant = true;
        public int Constant;
        public IntVariable Variable;

        public IntReference() { }
        public IntReference(int _value)
        {
            UseConstant = true;
            Constant = _value;
        }

        public int Value
        {
            get { return UseConstant ? Constant : Variable.Value; }
            set
            {
                if (UseConstant)
                {
                    Constant = value;
                }
                else
                {
                    Variable.Value = value;
                }
            }
        }

        public static implicit operator int(IntReference reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}