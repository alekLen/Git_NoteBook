using System;
using System.Collections.Generic;
using System.Text;

namespace Git_NoteBook
{
    [Serializable]
    internal class Person :IPerson
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string PersonToString()
        {
            return Name + " тел: " + Phone + " адрес: " + Adress;
        }
    }
}
