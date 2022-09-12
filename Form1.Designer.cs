namespace accounts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.bAddAccount = new System.Windows.Forms.Button();
            this.cbAccountFrom = new System.Windows.Forms.ComboBox();
            this.cbAccountTo = new System.Windows.Forms.ComboBox();
            this.bTransfer = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudInitialAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAccounts
            // 
            this.lvAccounts.Location = new System.Drawing.Point(57, 83);
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(283, 146);
            this.lvAccounts.TabIndex = 0;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            // 
            // bAddAccount
            // 
            this.bAddAccount.Location = new System.Drawing.Point(123, 138);
            this.bAddAccount.Name = "bAddAccount";
            this.bAddAccount.Size = new System.Drawing.Size(38, 34);
            this.bAddAccount.TabIndex = 1;
            this.bAddAccount.Text = "+";
            this.bAddAccount.UseVisualStyleBackColor = true;
            this.bAddAccount.Click += new System.EventHandler(this.bAddAccount_Click);
            // 
            // cbAccountFrom
            // 
            this.cbAccountFrom.FormattingEnabled = true;
            this.cbAccountFrom.Location = new System.Drawing.Point(57, 274);
            this.cbAccountFrom.Name = "cbAccountFrom";
            this.cbAccountFrom.Size = new System.Drawing.Size(182, 33);
            this.cbAccountFrom.TabIndex = 2;
            this.cbAccountFrom.SelectedIndexChanged += new System.EventHandler(this.cbAccountFrom_SelectedIndexChanged);
            // 
            // cbAccountTo
            // 
            this.cbAccountTo.FormattingEnabled = true;
            this.cbAccountTo.Location = new System.Drawing.Point(314, 274);
            this.cbAccountTo.Name = "cbAccountTo";
            this.cbAccountTo.Size = new System.Drawing.Size(182, 33);
            this.cbAccountTo.TabIndex = 3;
            this.cbAccountTo.SelectedIndexChanged += new System.EventHandler(this.cbAccountTo_SelectedIndexChanged);
            // 
            // bTransfer
            // 
            this.bTransfer.Location = new System.Drawing.Point(384, 336);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(112, 34);
            this.bTransfer.TabIndex = 4;
            this.bTransfer.Text = "transfer";
            this.bTransfer.UseVisualStyleBackColor = true;
            this.bTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(57, 336);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(98, 31);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudInitialAmount);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bAddAccount);
            this.groupBox1.Location = new System.Drawing.Point(517, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "new account";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(20, 64);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(141, 31);
            this.txtAccountName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "amount";
            // 
            // nudInitialAmount
            // 
            this.nudInitialAmount.Location = new System.Drawing.Point(20, 138);
            this.nudInitialAmount.Name = "nudInitialAmount";
            this.nudInitialAmount.Size = new System.Drawing.Size(97, 31);
            this.nudInitialAmount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.bTransfer);
            this.Controls.Add(this.cbAccountTo);
            this.Controls.Add(this.cbAccountFrom);
            this.Controls.Add(this.lvAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvAccounts;
        private Button bAddAccount;
        private ComboBox cbAccountFrom;
        private ComboBox cbAccountTo;
        private Button bTransfer;
        private NumericUpDown nudAmount;
        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown nudInitialAmount;
        private TextBox txtAccountName;
        private Label label2;
    }
}