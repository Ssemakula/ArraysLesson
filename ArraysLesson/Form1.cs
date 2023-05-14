namespace ArraysLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddInfinite_Click(object sender, EventArgs e) // Simple Infinite
        {
            string[] namelist = { "Peter", "Paid", "Pink", "Panther", "Poorly" };
            this.lb_ArrayList.Items.Clear();
            this.lb_ArrayList.Items.AddRange(namelist);
        }

        private void btn_AddInfinite_RClick(object sender, EventArgs e) // Simple Infinite
        {
            string[] namelist;
            namelist = new string[] { "Jane", "Just", "Jests", "Justly" };
            this.lb_ArrayList.Items.Clear();
            this.lb_ArrayList.Items.AddRange(namelist);

        }

        private void btn_AddInfinite_RClickLeave(object sender, EventArgs e) // Simple Infinite
        {
            this.lb_ArrayList.Items.Clear();
        }
        private void btn_AddManual_Click(object sender, EventArgs e)
        {
            this.lb_ArrayList.Items.Clear();
            this.lb_ArrayList.Items.Add("Maissan");
            this.lb_ArrayList.Items.Add("Rubanza");
            this.lb_ArrayList.Items.Add("Lukanga");
            this.lb_ArrayList.Items.Add("Mukiibi");
        }

        private void btn_ForLoop_Click(object sender, EventArgs e)
        {
            string[] namelist;
            namelist = new string[] { "Peris", "Flo", "Euvine", "Gentrix", "New" };

            this.lb_ArrayList.Items.Clear();
            for (int i = 0; i < namelist.Length; i++)
            {
                this.lb_ArrayList.Items.Add(namelist[i]);
            }
        }

        private void btn_ForEach_Click(object sender, EventArgs e)
        {
            string[] namelist;
            namelist = new string[] { "Peris", "Flo", "Euvine", "Gentrix", "Vivian" };

            this.lb_ArrayList.Items.Clear();
            foreach (string item in namelist) //Useful for reading, not modifying
            {
                this.lb_ArrayList.Items.Add(item);
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            string[] namelist;
            namelist = new string[] { "Peris", "Flo", "Euvine", "Gentrix", "Vivian" };
            Int32[] numlist =  new int[8] { 15, 564, 45, 879, 54, 654, 84, 45 };

            Array.Sort(namelist);
            this.lb_ArrayList.Items.Clear();
            this.lb_ArrayList.Items.AddRange(namelist); // doesn't work for int[]???
            /*
            foreach (string item in namelist) //Useful for reading, not modifying
            {
                this.lb_ArrayList.Items.Add(item);
            }
            */
            MessageBox.Show("Now for numbers reverse sort...");
            Array.Sort(numlist);
            Array.Reverse(numlist);
            Array.Resize(ref numlist, 15); //Resize the array
            
            foreach (Int32 item in numlist) //Useful for reading, not modifying
            {
                this.lb_ArrayList.Items.Add(item); //Can us item.ToString() but it is not necessary
            }
            
            //this.lb_ArrayList.Items.AddRange(numlist);
        }
    }
}