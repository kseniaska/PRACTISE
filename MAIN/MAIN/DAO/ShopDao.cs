using System;

namespace MAIN
{
    public class ShopDao
    {
        int id;
        string name;
        int code;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
