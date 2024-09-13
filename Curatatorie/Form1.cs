using Guna.UI2.WinForms;

namespace Curatatorie
{
    public partial class Form1 : Form
    {
        //componentele pentru resize
        private Rectangle panelOriginalRectangle;
        private Rectangle pictureBox1OriginalRectangle;
        private Rectangle guna2GroupBox1OriginalRectangle;

        private Rectangle lblAutentificareOriginalRectangle;
        private Rectangle gn2TextBoxNumeUtilizatOriginalRectangle;
        private Rectangle gn2TextBoxParolaOriginalRectangle;
        private Rectangle gn2BtnAutentifOriginalRectangle;
        private Rectangle lblParolaUitataOriginalRectangle;
        private Rectangle label2OriginalRectangle;
        private Rectangle lblContNouOriginalRectangle;

        private Rectangle originalFormSize;


        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(panelOriginalRectangle, panel1);
            resizeControl(pictureBox1OriginalRectangle, pictureBox1);
            resizeControl(guna2GroupBox1OriginalRectangle, guna2GroupBox1);

            resizeControl(lblAutentificareOriginalRectangle, lblAutentificare);
            resizeControl(gn2TextBoxNumeUtilizatOriginalRectangle, gn2TextBoxNumeUtilizat);
            resizeControl(gn2TextBoxParolaOriginalRectangle, gn2TextBoxParola);
            resizeControl(gn2BtnAutentifOriginalRectangle, gn2BtnAutentif);
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)this.Width / (float)originalFormSize.Width;
            float yRatio = (float)this.Height / (float)originalFormSize.Height;

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            panelOriginalRectangle = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            pictureBox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            guna2GroupBox1OriginalRectangle = new Rectangle(guna2GroupBox1.Location.X, guna2GroupBox1.Location.Y, guna2GroupBox1.Width, guna2GroupBox1.Height);

            lblAutentificareOriginalRectangle = new Rectangle(lblAutentificare.Location.X, lblAutentificare.Location.Y, lblAutentificare.Width, lblAutentificare.Height);
            gn2TextBoxNumeUtilizatOriginalRectangle = new Rectangle(gn2TextBoxNumeUtilizat.Location.X, gn2TextBoxNumeUtilizat.Location.Y, gn2TextBoxNumeUtilizat.Width, gn2TextBoxNumeUtilizat.Height);
            gn2TextBoxParolaOriginalRectangle = new Rectangle(gn2TextBoxParola.Location.X, gn2TextBoxParola.Location.Y, gn2TextBoxParola.Width, gn2TextBoxParola.Height);
            gn2BtnAutentifOriginalRectangle = new Rectangle(gn2BtnAutentif.Location.X, gn2BtnAutentif.Location.Y, gn2BtnAutentif.Width, gn2BtnAutentif.Height);


            //setarile implicite
            //group box - AUTENTIFICARE
            guna2GroupBox1.Visible = true;
            guna2GroupBox1.Enabled = true;

        }

        private void lblParolaUitata_Click(object sender, EventArgs e)
        { }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gn2BtnTrimiteCodEmail_Click(object sender, EventArgs e)
        {}

        private void gn2BtnTrimite2_Click(object sender, EventArgs e)
        {}
    }
}
