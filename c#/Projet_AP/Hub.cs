using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_AP
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
            Projet_AP.Control.MainMenuStrip menuStrip = new Projet_AP.Control.MainMenuStrip();
            Controls.Add(menuStrip);
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            Modele.init();
            Modele.Vmodele.Seconnecter();
        }
    }
}
