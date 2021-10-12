using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.PresentationLayer;
using PRG282Project.ApplicationLayer;
using PRG282Project.DataAccessLayer;
using PRG282Project.DataLayer;

namespace PRG282Project
{
    public partial class Form1 : Form
    {
        public static Form1 current;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current = this;
            new PL();
            new AL();
            new DL();
            new DataHandler();
            new FileHandler();
        }
    }
}
