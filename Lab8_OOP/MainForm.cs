using System.Numerics;

namespace Lab8_OOP
{
    public partial class MainForm : Form
    {
        private List<int> list;
        Random random;
        public MainForm()
        {
            InitializeComponent();
            list = new List<int>();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await SystemTimeAsync();
        }

        private async Task SystemTimeAsync()
        {
            while (true)
            {
                label2.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelaxForm relaxForm = new RelaxForm();
            relaxForm.Show();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await FillList((int)numericUpDown1.Value);
            MessageBox.Show("Вектор заполнен!");
        }

        private Task FillList(int size)
        {
            list.Clear();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(0, size));
            }

            return Task.CompletedTask;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = await FindMinInList(list);
            MessageBox.Show("Число найдено!");
        }

        private Task<int> FindMinInList(List<int> list)
        {
            int min = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }

            return Task.FromResult(min);
        }
    }
}