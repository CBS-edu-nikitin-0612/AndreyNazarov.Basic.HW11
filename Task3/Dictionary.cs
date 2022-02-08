namespace Task3
{
    internal class Dictionary<K, V>
    {
        private KeyValuePair<K, V>[] array;
        private int lastIndex = 0;
        public int Count { get => lastIndex; }

        public void Add(K key, V value)
        {
            if (array.Length - 1 == Count)
            {
                EnlargeArray();
            }
            array[lastIndex] = new KeyValuePair<K, V>(key, value);
            lastIndex++;
        }

        public KeyValuePair<K, V> this[int i]
        {
            get => array[i];
        }

        public Dictionary()
        {
            array = new KeyValuePair<K, V>[2];
        }

        private void EnlargeArray()
        {
            KeyValuePair<K, V>[] temp = new KeyValuePair<K, V>[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            array = temp;
        }

    }
}
