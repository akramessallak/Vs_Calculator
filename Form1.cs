using System.Diagnostics;
using System.Linq.Expressions;

namespace VS_Calculator
{
    public partial class Form1 : Form
    {
        double stnumb, ndnumb;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {

            if (Display.Text == "0")
                Display.Clear();

            Button b = (Button)sender;
            Display.Text = Display.Text + b.Text;
        }

       
        private void BtnD_Click(object sender, EventArgs e)
        {
            stnumb = double.Parse(Display.Text);
            operation = "/";
            Display.Text = "";
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            stnumb = double.Parse(Display.Text);
            operation = "*";
            Display.Text = "";
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            stnumb = double.Parse(Display.Text);
            operation = "-";
            Display.Text = "";
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            stnumb = double.Parse(Display.Text);
            operation = "+";
            Display.Text = "";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void BtnAS_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(-1*s);
        }
        
        private void BtnCE_Click(object sender, EventArgs e)
        {
            Display.Text = "0";

            String f, s;

            f = Convert.ToString(stnumb);
            s = Convert.ToString(ndnumb);

            f = "";
            s = "";
        }
       
        private void BtnR_Click(object sender, EventArgs e)
        {
            ndnumb = double.Parse(Display.Text);

            switch (operation)
            {
                case "+":
                    Display.Text = (stnumb + ndnumb).ToString();
                    break;
                case "-":
                    Display.Text = (stnumb - ndnumb).ToString();
                    break;
                case "*":
                    Display.Text = (stnumb * ndnumb).ToString();
                    break;
                case "/":
                    Display.Text = (stnumb / ndnumb).ToString();
                    break;

                default:
                    break;
            }
        }
        private void BtnErase_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
            }
        }

    }
}