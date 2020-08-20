class MyList<T>
{
    public MyList(int size) // a constructor that builds an instance
    {
        this.actual_list = new T[size]; // a reference to an array
    }
    private T[] actual_list;
    public int Count()
    {
        return this.actual_list.Length;
    }
    public void Add(T item)
    {
        int current_count = this.actual_list.Length;
        T[] new_array = new T[current_count + 1];
        for (int i = 0; i < current_count; i++)
        {
            new_array[i] = this.actual_list[i];
        }
        new_array[current_count] = item;
        this.actual_list = new_array;
    }
    public T GetAt(int index)
    {
        return this.actual_list[index];
    }
}