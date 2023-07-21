using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Git_NoteBook
{
    public partial class Form1 : Form
    {
        public string NamePerson { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

        public event EventHandler<EventArgs> AddPersonEvent;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
