namespace Task4
{
    internal class ArrayList
    {
        private object[] array;
        public int Count { get; private set; }

        public void Add(object obj)
        {
            array[Count] = obj;
            Count++;
        }
        public ArrayList()
        {
            array = new object[10];
        }

        public object this[int index]
        {
            get => array[index];
        }
    }
}
