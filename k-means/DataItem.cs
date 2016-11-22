namespace k_means
{
    public class DataItem<T>
    {
        private T[] _input = null;
        public DataItem(T[] input)
        {
            _input = input;
        }
        public T[] Input
        {
            get { return _input; }
        }
    }
}
