namespace ESPFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            string finalHTML="";
            openHTML.ShowDialog();
            lbTarget.Text = openHTML.FileName;

            string[] lines = File.ReadAllLines(lbTarget.Text);

            foreach (string line in lines)
            {
                finalHTML += line + " ";

            }
            
            Clipboard.SetText(finalHTML);
            lbLen.Text = "Tamanho=" + finalHTML.Length;
        }
    }
}