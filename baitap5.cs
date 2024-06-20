using System;
using System.Collections.Generic;

class MyStack<T>
{
    private List<T> stackList;

    public MyStack()
    {
        stackList = new List<T>();
    }

    public void Push(T item)
    {
        stackList.Add(item);
    }

    public T Pop()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp rỗng");
        }

        int lastIndex = stackList.Count - 1;
        T poppedItem = stackList[lastIndex];
        stackList.RemoveAt(lastIndex);
        return poppedItem;
    }
}

class Program
{
    static void Main()
    {
        // Kiểm tra lớp MyStack với các kiểu dữ liệu khác nhau

        // Kiểu dữ liệu integer
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(5);
        intStack.Push(10);
        Console.WriteLine($"Phần tử pop từ ngăn xếp integer: {intStack.Pop()}");

        // Kiểu dữ liệu string
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("apple");
        stringStack.Push("banana");
        Console.WriteLine($"Phần tử pop từ ngăn xếp string: {stringStack.Pop()}");

        // Thử pop từ ngăn xếp rỗng (sẽ ném InvalidOperationException)
        // MyStack<int> emptyStack = new MyStack<int>();
        // Console.WriteLine(emptyStack.Pop()); // Bỏ comment để thử ném exception

        // Kiểm tra thêm các kiểu dữ liệu khác nếu muốn

        // Ví dụ với kiểu double
        MyStack<double> doubleStack = new MyStack<double>();
        doubleStack.Push(3.14);
        doubleStack.Push(2.718);
        Console.WriteLine($"Phần tử pop từ ngăn xếp double: {doubleStack.Pop()}");

        // Ví dụ với kiểu DateTime
        MyStack<DateTime> dateTimeStack = new MyStack<DateTime>();
        dateTimeStack.Push(DateTime.Now);
        dateTimeStack.Push(DateTime.Now.AddDays(1));
        Console.WriteLine($"Phần tử pop từ ngăn xếp DateTime: {dateTimeStack.Pop()}");
    }
}
