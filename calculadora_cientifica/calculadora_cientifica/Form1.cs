namespace calculadora_cientifica
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text=(enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j* 4)).ToString();
                    break;

                default:
                    break;
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1*q);

        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);

            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";

            }
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300; //497
            txtResult.Width = 287; //34
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 700; //497
            txtResult.Width = 625; //34
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult salirCal;

            salirCal = MessageBox.Show("¿Estas seguro de salir?", "Calculadora cientifica",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salirCal == DialogResult.Yes)
            {
                Application.Exit();

            }                
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg =  Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnCuadr_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text=Convert.ToString(x);
        }

        private void btnCub_Click(object sender, EventArgs e)
        {
            double x,q,p,m;

            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x = (q * p * m);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            double se = Convert.ToDouble(txtResult.Text);
            se = Math.Sin(se);
            txtResult.Text = Convert.ToString(se);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cs = Convert.ToDouble(txtResult.Text);
            cs = Math.Cosh(cs);
            txtResult.Text = Convert.ToString(cs);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double co = Convert.ToDouble(txtResult.Text);
            co = Math.Cos(co);
            txtResult.Text = Convert.ToString(co);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double ta = Convert.ToDouble(txtResult.Text);
            ta = Math.Tan(ta);
            txtResult.Text = Convert.ToString(ta);
        }

        private void btnFracc_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble (txtResult.Text));
            txtResult.Text = Convert.ToString(a);

        }

        private void btnLogn_Click(object sender, EventArgs e)
        {
            double inx = Convert.ToDouble(txtResult.Text);
            inx = Math.Log(inx);
            txtResult.Text = Convert.ToString(inx);
        }

        private void bntPort_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 400; //497
            txtResult.Width = 287; //34
        }
    }
}