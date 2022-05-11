using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP
{
    public partial class SupprAdherent : Form
    {
        List<Adherent.Adherent> lesAdherents = new List<Adherent.Adherent>();
        public SupprAdherent()
        {
            InitializeComponent();
        }
        private void ChargerAdherent()
        {
            Modele.Vmodele.Charger_adherent();
            DataTable dt = Modele.Vmodele.DT5;
            lesAdherents.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT5.Rows.Count; i++)
            {
                lesAdherents.Add(new Adherent.Adherent(dt.Rows[i]["id_adherent"].ToString(), dt.Rows[i]["nom_adherent"].ToString()));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            lbAdherent.Items.Clear();
            foreach (Adherent.Adherent E in lesAdherents)
            {
                lbAdherent.Items.Add(E.IdAdherent + "-" + E.NomAdherent);
            }
        }
        private void SupprAdherent_Load(object sender, EventArgs e)
        {
            ChargerAdherent();
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            int index = lbAdherent.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette Adherent ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    int idAdherent = Convert.ToInt32(Modele.Vmodele.DT5.Rows[index]["id_adherent"]);
                    bool rep = Modele.Vmodele.SupprAdherent(idAdherent);
                    if (rep)
                    {
                        lesAdherents.RemoveAt(index);
                        MessageBox.Show("Adherent supprimer de la BD");
                        ChargerAdherent();
                    }
                    else
                    {
                        MessageBox.Show("Problème lors de la suppression de l'Adherent");
                    }
                }
            }
        }
    }
}
