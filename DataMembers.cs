using System;

namespace Learning {
    class DataMembers {
        // constant variables
        // numeric data members
        const int i = 20;
        const float f = 2.54f;
        const double d = 38.7364;
        const decimal dec = 2.999m;
        const short sh = 34;
        const long l = 9430875;
        // boolean data member
        const bool b = true;
        // string/ character data members
        const string str = "some string";
        const char ch = 'A';

        public static void Main(String[] args) {
            DataMembers DMs = new DataMembers {};
            DMs.Conversions();
        }

        public void DataTypes() {

        }

        public void Conversions() {
            int di = (int) d;
            Console.WriteLine("Double to Integer: "+di);
        }
    }
}