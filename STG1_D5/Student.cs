using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG1_D5
{
    internal class Student2
    {
        private string ssn;
        private string name;
        private int age;
        private string address;
        static int counter;
        public Student2()
        {
            read();
            counter++;
            if (counter%10 == 0) {
                Console.WriteLine("There is another 10 students have been submitted");
            }
        }
        #region setters
        //public void setSsn(string _ssn)
        //{
        //    ssn = _ssn;
        //}
        //public void setName(string _name)
        //{
        //    name = _name;
        //}
        //public void setAge(int _age)
        //{
        //    age = _age;
        //}
        //public void setAddress(string _address)
        //{
        //    address = _address;
        //}
        #endregion
        #region getters
        //public string getSsn()
        //{
        //    return ssn;
        //}
        //public string getName()
        //{
        //    return name;
        //}
        //public int getAge()
        //{
        //    return age;
        //}
        //public string getAddress()
        //{
        //    return address;
        //}

        #endregion
        #region property
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        #endregion
        public string PrintAsString()
        {
            return $"Employee ssn is {this.ssn},\n" +
                $"Employee  name is {this.name}\n" +
                $"Employee age is {this.age}\n" +
                $"Employee address is {this.address}\n";
        }
        public void read()
        {
            Console.WriteLine("Enter Student national id");
            Ssn = (Console.ReadLine());
            Console.WriteLine("Enter Student name");
            Name = (Console.ReadLine());
            Console.WriteLine("Enter Student age");
            Age = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Student address");
            Address = (Console.ReadLine());
        }
    }
}
