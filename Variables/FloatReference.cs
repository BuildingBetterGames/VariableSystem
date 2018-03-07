using System;

namespace BBG.Variables
{
    [System.Serializable]
    public class FloatReference
    {
        public bool UseConstant = true;
        public float Constant;
        public FloatVariable Variable;

        public FloatReference() { }
        public FloatReference(float _value)
        {
            UseConstant = true;
            Constant = _value;
        }

        public float Value
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

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        public string ToStringInt()
        {
            return ((int)Value).ToString();
        }
    }
}