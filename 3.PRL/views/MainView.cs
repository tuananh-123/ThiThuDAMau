namespace _3.PRL.views
{
    public partial class MainView : Form, IMainView
    {
        public string SearchValue { get => textBox_Search.Text; set => textBox_Search.Text = value; }

        public MainView()
        {
            InitializeComponent();
            //dataGridViewNV.Visible = false;
            AssociateEvent();
        }

        private void AssociateEvent()
        {
            button_Show.Click += delegate { ShowData?.Invoke(this, EventArgs.Empty); };
            button_Search.Click += delegate { SearchData?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowData;
        public event EventHandler SearchData;

        public void SetBindingSource(BindingSource petLists)
        {
            dataGridViewNV.DataSource = petLists;
        }
    }
}
