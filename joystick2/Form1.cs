using System.Reflection;

namespace joystick2
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastMousePos = Point.Empty;
        Image greenImage, redImage, redImage2, greenImage2;
        private int currentImageIndex = 0;
        private int startPanelX = 0;
        private int startPanelY = 0;



        public Form1()
        {
            InitializeComponent();
            panelJoystick.MouseDown += PanelJoystickMouseDown;
            panelJoystick.MouseMove += PanelJoystickMouseMove;
            panelJoystick.MouseUp += PanelJoystickMouseUp;
            greenImage = Image.FromFile("lime_dot.png");
            redImage = Image.FromFile("redot.png");
            redImage2 = Image.FromFile("red_circle.png");
            greenImage2 = Image.FromFile("lime_circle.png");
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Load olay iþleyicisinde yapýlmasý gereken iþlemleri burada gerçekleþtirin
            panelJoystick.BackgroundImage = greenImage;
            panelJoystick.BackgroundImage = greenImage2; startPanelX = panelJoystick.Location.X;
            startPanelY = panelJoystick.Location.Y;
            //aaaaa


        }

        private void PanelJoystickMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                panelJoystick.BackgroundImage = redImage;
                this.BackgroundImage = redImage2;

                moveTimer.Start(); // Timer'ý baþlat

            }


            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                panelJoystick.Capture = true; // Paneli yakala
            }
        }

        private void PanelJoystickMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.X - lastMousePos.X;
                int dy = e.Y - lastMousePos.Y;
                int newX = panelJoystick.Location.X + dx;
                int newY = panelJoystick.Location.Y + dy;

                // Panelin form sýnýrlarý içinde kalmasýný saðlayalým
                newX = Math.Max(0, Math.Min(newX, this.ClientSize.Width - panelJoystick.Width));
                newY = Math.Max(0, Math.Min(newY, this.ClientSize.Height - panelJoystick.Height));

                panelJoystick.Location = new Point(newX, newY);

                lastMousePos = e.Location;
                int currentX = panelJoystick.Location.X - startPanelX;
                int currentY = panelJoystick.Location.Y - startPanelY;
                label2.Text = "X: " + currentX + " | Y: " + currentY;
            }
        }

        private void PanelJoystickMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                moveTimer.Stop(); // Timer'ý durdur
            }
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                panelJoystick.Capture = false; // Yakalamayý býrak
            }
        }


        private void panelJoystick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            isDragging = false;
            panelJoystick.BackgroundImage = greenImage;
            this.BackgroundImage = greenImage2;

            panelJoystick.Location = new Point(startPanelX, startPanelY);
            label2.Text = "X: 0 | Y: 0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

