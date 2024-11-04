namespace MoshAdvance_Generics
{
    public class Nullable<T> where T : struct
    {
        //T : struct - applying to value type
        // NOTE that nullables can be found in the system namespace
        private object _value;
        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
