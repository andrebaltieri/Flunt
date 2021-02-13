using System;
using System.Collections.Generic;
using System.Text;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsNull<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotNull<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsEmpty<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotEmpty<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            return this;
        }
    }
}
