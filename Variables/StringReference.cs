namespace BBG.Variables
{
    [System.Serializable]
    public class StringReference
    {
        public bool UseConstant = true;
        public string Constant;
        public StringVariable Variable;

        public StringReference() { }
        public StringReference(string _value)
        {
            UseConstant = true;
            Constant = _value;
        }

        public string Value
        {
            get { return UseConstant ? Constant : Variable.Value; }
        }
    }
}