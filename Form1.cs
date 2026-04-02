namespace FirstExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBx_ChooseAI.Items.Add("Dalle2");
            comboBx_ChooseAI.Items.Add("Dalle3");
            comboBx_ChooseAI.Items.Add("Stable Diffusion XL");
            comboBx_ChooseAI.Items.Add("Grok");
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            try { 
                string promptName = txtbx_Name.Text;
                string prompt = txtbx_prompt.Text;
                string aiModel = comboBx_ChooseAI.SelectedItem?.ToString() ?? "No AI model selected";
                string reason = rbtn_Intern.Checked ? "Intern" : rbtn_Mockup.Checked ? "Mockup" : rbtn_Final.Checked ? "Final" : null;
                DateTime date = dateTimePicker.Value;
                bool changedAI = checkBx_ChangedAI.Checked;
                UserInput userInput = new UserInput(promptName, prompt, aiModel, reason, date, changedAI);
                MessageBox.Show("User input ist akzeptabel");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }
    }
}
