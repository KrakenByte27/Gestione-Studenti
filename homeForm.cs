using Gestione_Studenti.Classi;

namespace Gestione_Studenti
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        #region Bottoni

        private void checkButton_Click(object sender, EventArgs e)
        {
            int gg = 0, mm = 0, aa = 0, anno = 0;

            bool checkNome,
                checkCognome,
                checkGg,
                checkMm,
                checkAa,
                checkCorso,
                checkAnno;

            #region Nome e Cognome

            if (nomeTextBox.Texts == "")
            {
                nomeTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkNome = false;
            }
            else checkNome = true;

            if (cognomeTextBox.Texts == "")
            {
                cognomeTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkCognome = false;
            }
            else checkCognome = true;

            #endregion

            #region Giorni

            if (!int.TryParse(ggTextBox.Texts, out _) || ggTextBox.Texts == "")
            {
                ggTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkGg = false;
            }
            else
            {
                gg = Convert.ToInt32(ggTextBox.Texts);
                if (gg > 31||gg<1)
                {
                    ggTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    checkGg = false;
                }
                else checkGg = true;
            }

            #endregion

            #region Mesi

            if (!int.TryParse(mmTextBox.Texts, out _) || mmTextBox.Texts == "")
            {
                mmTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkMm = false;
            }
            else
            {
                mm = Convert.ToInt32(mmTextBox.Texts);
                if (mm > 12||mm<1)
                {
                    mmTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    checkMm = false;
                }
                else checkMm = true;
            }

            #endregion

            #region Anni

            if (!int.TryParse(aaTextBox.Texts, out _) || aaTextBox.Texts == "")
            {
                aaTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkAa = false;
            }
            else
            {
                aa = Convert.ToInt32(aaTextBox.Texts);
                if (aa > DateTime.Now.Year)
                {
                    aaTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    checkAa = false;
                }
                else checkAa = true;
            }

            #endregion

            #region Corso e Anno

            if (corsoTextBox.Texts == "")
            {
                corsoTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkCorso = false;
            }
            else checkCorso = true;

            if (!int.TryParse(annoTextBox.Texts, out _) || annoTextBox.Texts == "")
            {
                annoTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkAnno = false;
            }
            else
            {
                anno = Convert.ToInt32(annoTextBox.Texts);
                if (anno > 5)
                {
                    annoTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    checkAnno = false;
                }
                else checkAnno = true;
            }

            #endregion

            if (checkNome && checkCognome && checkGg && checkMm && checkAa && checkCorso && checkAnno)
            {
                Studente stud1 = new(nomeTextBox.Texts,
                                     cognomeTextBox.Texts,
                                     gg,
                                     mm,
                                     aa,
                                     corsoTextBox.Texts,
                                     Convert.ToInt32(annoTextBox.Texts));
                string check = stud1.Controllo();
                MessageBox.Show(check,
                                "Risultato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void azzeraButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sei sciuro di voler pulire tutti i campi?",
                                                 "Avviso",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning))
            {
                nomeTextBox.Texts = "";
                cognomeTextBox.Texts = "";
                ggTextBox.Texts = "";
                mmTextBox.Texts = "";
                aaTextBox.Texts = "";
                corsoTextBox.Texts = "";
                annoTextBox.Texts = "";
            }
        }

        private void esciButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sei sciuro di voler uscire?",
                                                 "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question))
                Application.Exit();
        }

        #endregion

        #region TextBox

        private void nomeTextBox__TextChanged(object sender, EventArgs e)
        {
            nomeTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void cognomeTextBox__TextChanged(object sender, EventArgs e)
        {
            cognomeTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void ggTextBox__TextChanged(object sender, EventArgs e)
        {
            ggTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void mmTextBox__TextChanged(object sender, EventArgs e)
        {
            mmTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void aaTextBox__TextChanged(object sender, EventArgs e)
        {
            aaTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void corsoTextBox__TextChanged(object sender, EventArgs e)
        {
            corsoTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        private void annoTextBox__TextChanged(object sender, EventArgs e)
        {
            annoTextBox.BackColor = Color.FromArgb(26, 150, 84);
        }

        #endregion
    }
}