namespace FUerManager.Services
{
    public class Cabinet<T> //type sẽ lưu trữ và xử lí 1 list hay mảng 
    {
        //private T[] _arr; // = new T[100]; //size nếu qua constructor
        //private int _size = 0;
        private List<T> _list = new();//hok cần constructor để truyền size
        //k cần biến count co giãn số phần tử
        public void PrintItems()
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            Console.WriteLine($"Total items: {_list.Count}");
            foreach (T x in _list)
                Console.WriteLine(x);
        }
        public void Add(T x)
        { //validation here trùng
            _list.Add(x);
        }

    }
}
