namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetBmi();
            Console.WriteLine();
        }

        //CHANLLENGE #1 Viết hàm tính và in ra chỉ số BMI - chỉ số khối cơ thể - BODY MASK INDEX
        //Nói về tình trạng mập ốm của ai đó dựa trên chiều cao và cân nặng
        //BMI = Cân nặng (KG)/ bình phương chiều cao(M)
        //Nếu bmi từ 18.5 đén 24.9 chuẩn form
        //static chơi với static
        static void GetBmi()
        {
            double weight = 70;//kg
            double height = 1.7;//m
            double bmi = weight /(height * height);
            Console.WriteLine($"BMI (w: {weight} | h: {height}): {bmi}");
            Console.WriteLine($"BMI (w: {0} | h: {1}): {2}", weight, height, bmi);

            Console.WriteLine("Weight:");


        }

    }
}
