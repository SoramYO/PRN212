using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Services
{
    public class CabinetFantasy<T> //t là data type 
                                   //sẽ là bất kì student hay lecturer và các datatype khác
                                   //class data type đưa vào như 1 param: generic tui làm việc tổng quát chung chung với các datatype

    //neww CabinetFantasy<Student>(); new CabinetFantasy<Lecturer>();
    {
        private T[] _arr;
    }
}
