namespace Task6
{
    internal class MyClass<T> where T : new()
    {
        // Тип Т должен иметь доступный конструктор по умолчанию
        public T FactoryMethod()
        {
            return new T();
        }
    }
}
