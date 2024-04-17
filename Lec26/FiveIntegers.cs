using System.Collections;
namespace CSEnumeratorEnumerable
{
    class FiveIntegers : IEnumerable
    {
        int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            this._values = new[]
            {
                n1,n2,n3,n4,n4,n5
            };
        }


        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }
        /**
        public IEnumerator GetEnumerator() => new Enumerator(this);
        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException($"Enumeration Not Started yet");
                    if (currentIndex == _integers._values.Length)
                        throw new InvalidOperationException($"Enumeration Ended");
                    return _integers._values[currentIndex];

                }
            }

            public bool MoveNext()
            {
                if (currentIndex >= _integers._values.Length - 1)
                {
                    return false;
                }
                else
                {
                    return ++currentIndex < _integers._values.Length;
                }

            }

            public void Reset()
            {
                currentIndex = -1;
            }

        }

        */
    }


}

