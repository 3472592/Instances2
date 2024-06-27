namespace Ch3WinFormsApp2Instances
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Silvia_Click(object sender, EventArgs e)
        {
            Car Silvia = new Car();
            Silvia.Name = "Silvia";
            Silvia.Speed = 120;
            Silvia.Hp = 150;
            Silvia.PrintCarCridentials();
        }

        private void Supra_Click(object sender, EventArgs e)
        {
            Car Supra = new Car();
            Supra.Name = "Supra";
            Supra.Speed = 250;
            Supra.Hp = 320;
            Supra.PrintCarCridentials();
        }

        private void Cefiro_Click(object sender, EventArgs e)
        {
            Car Cefiro = new Car();
            Cefiro.Name = "Cefiro";
            Cefiro.Speed = 200;
            Cefiro.Hp = 300;
            Cefiro.PrintCarCridentials();
        }

        private void Forester_Click(object sender, EventArgs e)
        {
            Car Forester = new Car();
            Forester.Name = "Forester";
            Forester.Speed = 400;
            Forester.Hp = 955;
            Forester.PrintCarCridentials();
        }

        private void CSilvia_Click(object sender, EventArgs e)
        {
            Car CSilvia = new Car();
            CSilvia.Name = Silvia.Name;
            CSilvia.Speed += Silvia.Speed *2;
            CSilvia.PrintCarCridentials();
        }

        private void CSupra_Click(object sender, EventArgs e)
        {

        }

        private void CCefiro_Click(object sender, EventArgs e)
        {

        }

        private void CFozzy_Click(object sender, EventArgs e)
        {

        }
    }
}