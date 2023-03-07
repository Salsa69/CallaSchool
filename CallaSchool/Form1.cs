namespace CallaSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "MMdd"
        Dictionary<string, Tuple<string, bool>[]> Agendas = new Dictionary<string, Tuple<string, bool>[]>
        {
            { "0305", new Tuple<string, bool>[]{ new("English 2", false), new("Math 2", false) } },
        };


        DateTime today = DateTime.Now;
        DateTime date;
        private void updateDate()
        {
            label_date.Text = date.ToString("dddd, MMMM d" + (date.Equals(today) ? " (TODAY)" : ""));
            button_dateInc.Location = new Point(label_date.Location.X + label_date.Size.Width, 60);
        }

        private void loadDefault()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date = today;
            updateDate();


        }


        bool dragging = false;
        Point winStart;
        Point mouseStart;
        private void form_MouseDown(object sender, EventArgs e)
        {
            dragging = true;
            winStart = Location;
            mouseStart = Cursor.Position;
        }

        private void form_MouseUp(object sender, EventArgs e) => dragging = false;

        private void form_MouseMove(object sender, EventArgs e)
        {
            if (!dragging) return;
            Location = Point.Add(winStart, new Size(Point.Subtract(Cursor.Position, new Size(mouseStart))));
        }

        private void exit_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void min_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void button_dateDec_Click(object sender, EventArgs e)
        {
            date = date.Subtract(new System.TimeSpan(1, 0, 0, 0));
            updateDate();
        }

        private void button_dateInc_Click(object sender, EventArgs e)
        {
            date = date.Add(new System.TimeSpan(1, 0, 0, 0));
            updateDate();
        }
    }
}