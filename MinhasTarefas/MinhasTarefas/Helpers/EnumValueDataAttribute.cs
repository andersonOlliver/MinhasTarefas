using System;

namespace EnumSample.Helpers
{
    public class EnumValueDataAttribute : Attribute
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _keyValue;
        public string KeyValue
        {
            get { return _keyValue; }
            set { _keyValue = value; }
        }
    }
}
