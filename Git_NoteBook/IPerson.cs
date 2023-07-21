using System;
using System.Collections.Generic;
using System.Text;

namespace Git_NoteBook
{
    internal interface IPerson
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Adress { get; set; }
        string PersonToString();
    }
}
