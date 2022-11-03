using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProyectoPoo
{
    public partial class inputMatricula : Form
    {
        public void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }
        public inputMatricula()
        {
            InitializeComponent();
        }

        private void plantilla_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lugar1_MouseHover(object sender, EventArgs e)
        {
            lugar1.BackColor = Color.Red;

            setTimeout(() => {
                lugar1.BackColor = ColorTranslator.FromHtml("#66626C");
            }, 3000);

        }
  
        private void lugar2_MouseHover(object sender, EventArgs e)
        {

            if (auto.Visible == false)
            {

           
            lugar2.BackColor = Color.Green;

            setTimeout(() => {
                lugar2.BackColor = ColorTranslator.FromHtml("#66626C");

            }, 3000);
            }

        }

        private void lugar2_Click(object sender, EventArgs e)
        {
            auto.Visible = true;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            this.inputEntrada.Text = time;
        }

        private void auto_Click(object sender, EventArgs e)
        {
            auto.Visible = false;
            this.inputEntrada.Text = "";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}