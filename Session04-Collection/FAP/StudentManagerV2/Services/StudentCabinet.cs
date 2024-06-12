using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    public class StudentCabinet
    {
        private Student[] _arr;// = new Student[30];
        //đằng nào cũng new từ từ new theo nhu cầu
        private int _count = 0;//tủ ban đầu chưa có value cho các phần tử ở đây chính là [i] = new Student(); sẽ là 1 value mới theo biến thứ i của mảng 

        //tủ độ đóng theo yêu cầu gia chủ

        //public StudentCabinet(int size)
        //{
        //    _arr = new Student[size];
        //}

        public StudentCabinet(int size) => _arr = new Student[size];

        //các hàm crud cho từng món trong tủ từng biến thứ i 
        //xử lí các object từ entity strudent

        public void PrintStudents()
        {
            if (_count <= 0)
            {
                Console.Write("Tủ chưa có sinh viên nào");
                return;//thoát hàm luôn
            }
            //không in hết mảng sẽ bị null refence exception
            //chỉ for đến count hoặc for hết check null
            Console.WriteLine($"There is/are {_count} sinh viên in cabin");
            for (int i = 0; i < _count; i++)
            {
                _arr[i].ShowProfile();
            }
        }

        public void AddAStudent(Student student)
        {
            if (_count == _arr.Length)
            {
                Console.WriteLine("Tủ đã đầy");
                return;
            }
            _arr[_count++] = student;
        }

    }
}
