using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7Encapsulation.Entities
{
    internal class Student
    {
        private string Id { get; set; }  //private thì là _id
        private string Name { get; set; }
        private int Yob { get; set; }
        private double Gpa { get; set; }

        //không làm contructor, dùng default contructor; mọi field (lúc này là public) sẽ default là số 0 boole là false, string là null

        //vì để public cho nên ta sẽ chạm được 4 biến ngay và luôn sau khi new chạm trực tiếp mà không cần get set
        //vì chạm đucợ biến chính là get set rồi

        //xài get set thì không có boiler plate - không chán ngắn gọn


    }
}
