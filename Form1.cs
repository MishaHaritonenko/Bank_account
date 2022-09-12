namespace accounts
{
    public partial class Form1 : Form
    {
        private readonly List<Account> accounts = new List<Account>();
        private int lastId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudInitialAmount.Maximum = 1400000;
            nudAmount.Enabled = false;
            bTransfer.Enabled = false;

            cbAccountFrom.DisplayMember = "Name";
            cbAccountFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAccountTo.DisplayMember = "Name";
            cbAccountTo.DropDownStyle = ComboBoxStyle.DropDownList;

            lvAccounts.View = View.Details;
            lvAccounts.Columns.Add("name");
            lvAccounts.Columns.Add("amount");
            //lvAccounts.FullRowSelect = true;
            UpdateName();
        }

        private void bAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount(txtAccountName.Text, nudInitialAmount.Value);
        }

        private void AddAccount(string name, decimal amount)
        {
            var account = new Account { Name = name, Amount = amount };
            accounts.Add(account);

            AddAccountToLv(account);
            UpdateName();
        }

        private void UpdateName()
        {
            lastId++;
            txtAccountName.Text = $"account{lastId}";
        }

        private void AddAccountToLv(Account account)
        {
            var lvi = new ListViewItem();
            lvi.SubItems[0].Text = account.Name;
            lvi.SubItems.Add(account.Amount.ToString());

            lvAccounts.Items.Add(lvi);
            lvAccounts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cbAccountFrom.Items.Add(account);
        }

        private void cbAccountFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var accountFrom = cbAccountFrom.SelectedItem as Account;
            nudAmount.Maximum = accountFrom.Amount;
            nudAmount.Value = accountFrom.Amount;
            nudAmount.Enabled = true;
            RefillCbAccountTo(accountFrom);

        }

        private void RefillCbAccountTo(Account accountFrom)
        {
            cbAccountTo.Items.Clear();
            foreach (var account in accounts)
            {
                if (account != accountFrom)
                {
                    cbAccountTo.Items.Add(account);
                }
            }
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            var from = GetAccountFrom();
            var to = GetAccountTo();
            from.Amount -= nudAmount.Value;
            to.Amount += nudAmount.Value;
            RefillLvAccounts();
        }

        private void RefillLvAccounts()
        {
            lvAccounts.Items.Clear();
            foreach (var account in accounts)
            {
                AddAccountToLv(account);
            }
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {

        }



        private Account GetAccountFrom()
        {
            return cbAccountFrom.SelectedItem as Account;
        }
        private Account GetAccountTo()
        {
            return cbAccountTo.SelectedItem as Account;
        }

        private void cbAccountTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bTransfer.Enabled = true;
        }
    }
}