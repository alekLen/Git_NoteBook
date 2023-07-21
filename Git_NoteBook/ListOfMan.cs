using System;
using System.Collections.Generic;
using System.Text;

namespace Git_NoteBook
{
    [Serializable]
    internal class ListOfMan
    {
        private readonly IForm1 form;

        private readonly SavingList save;
        public void SaveList(object sender, EventArgs e)
        {
            save.Save("ListofMan");
        }
    }
}
