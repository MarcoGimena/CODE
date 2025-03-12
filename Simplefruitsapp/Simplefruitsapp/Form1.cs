namespace Simplefruitsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] fruits = { "Banana", "Mango", "Tangerine" };
            fruitlist.Items.AddRange(fruits);

            fruitlist.CheckOnClick = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var fruit in fruitlist.Items)
            {
                bool isSelected = fruitlist.GetItemChecked(fruitlist.Items.IndexOf(fruit));
                if (isSelected && !listbox.Items.Contains(fruit))
                {
                    listbox.Items.Add(fruit);
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count >= 1)
            {
                listbox.Items.Remove(listbox.SelectedItems);
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
        }
    }
}
