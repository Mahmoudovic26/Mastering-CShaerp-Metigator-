namespace CSEnumeratorEnumerable
{
    class Tempreture : IComparable
    {
        private int _value;

        public Tempreture(int value)
        {
            this._value = value;
        }
        public int Value => _value;

        public int CompareTo(object? obj)
        {
            if (obj is null) //1 = 2<3 | -1= 4>3 | 0 =3=3
                return 1;
            var temp = obj as Tempreture;
            if (temp is null)
                throw new ArgumentException("Object is not a temperature object");
            return this._value.CompareTo(temp._value);
        }

    }

}

