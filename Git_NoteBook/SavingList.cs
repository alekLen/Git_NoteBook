using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Git_NoteBook
{
    internal class SavingList
    {

        FileStream stream = null;
        BinaryFormatter formatter = null;
        public List<IPerson> list = new List<IPerson>();
        public void Save(string filename)
        {
            stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, list);
            stream.Close();
        }
    }
}
