using System;
using System.Collections.Generic;
using System.Text;

namespace Git_NoteBook
{
    internal interface ISave
    {
        void Save(string filename);
        void Load(string filename);
    }
}
