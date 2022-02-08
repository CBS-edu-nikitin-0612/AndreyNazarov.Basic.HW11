namespace Task2
{
    internal class CarCollection<T> where T : Car
    {
        // Не совсем понял задание, нужно чтобы эта колекция сама создавала экземпляры Car?
        private T[] arr;
        public int Count { get; private set; }
        public CarCollection()
        {
            arr = new T[10];
        }

        public void Add(T item)
        {
            arr[Count] = item;
            Count++;
        }
        public T this[int index]
        {
            get => arr[index];
        }

        public void Erase()
        {
            arr = new T[10];
        }
    }
}
