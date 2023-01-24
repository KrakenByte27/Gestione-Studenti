namespace Gestione_Studenti
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void esciButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Sei sciuro di voler uscire?",
                                                 "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)) 
                Application.Exit();
        }
    }
}