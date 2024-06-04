namespace Cursov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUserName = new TextBox();
            btnRegisterUser = new Button();
            txtStockSymbol = new TextBox();
            btnAddStock = new Button();
            txtOrderStockSymbol = new TextBox();
            btnPlaceOrder = new Button();
            btnShowHoldings = new Button();
            lstUserHoldings = new ListBox();
            cmbOrderType = new ComboBox();
            cmbUsers = new ComboBox();
            txtStockPrice = new TextBox();
            txtOrderQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(220, 72);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(180, 31);
            txtUserName.TabIndex = 0;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.Location = new Point(220, 112);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(180, 34);
            btnRegisterUser.TabIndex = 1;
            btnRegisterUser.Text = "регистрация";
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Click += btnRegisterUser_Click_1;
            // 
            // txtStockSymbol
            // 
            txtStockSymbol.Location = new Point(220, 256);
            txtStockSymbol.Name = "txtStockSymbol";
            txtStockSymbol.Size = new Size(180, 31);
            txtStockSymbol.TabIndex = 2;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(220, 332);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(180, 34);
            btnAddStock.TabIndex = 3;
            btnAddStock.Text = "добавить акцию";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click_1;
            // 
            // txtOrderStockSymbol
            // 
            txtOrderStockSymbol.Location = new Point(653, 109);
            txtOrderStockSymbol.Name = "txtOrderStockSymbol";
            txtOrderStockSymbol.Size = new Size(182, 31);
            txtOrderStockSymbol.TabIndex = 4;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(654, 193);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(183, 34);
            btnPlaceOrder.TabIndex = 5;
            btnPlaceOrder.Text = "разместить ордер";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click_1;
            // 
            // btnShowHoldings
            // 
            btnShowHoldings.Location = new Point(11, 503);
            btnShowHoldings.Name = "btnShowHoldings";
            btnShowHoldings.Size = new Size(182, 72);
            btnShowHoldings.TabIndex = 6;
            btnShowHoldings.Text = "показать портфель пользователя";
            btnShowHoldings.UseVisualStyleBackColor = true;
            btnShowHoldings.Click += btnShowHoldings_Click_1;
            // 
            // lstUserHoldings
            // 
            lstUserHoldings.FormattingEnabled = true;
            lstUserHoldings.ItemHeight = 25;
            lstUserHoldings.Location = new Point(220, 458);
            lstUserHoldings.Name = "lstUserHoldings";
            lstUserHoldings.Size = new Size(180, 204);
            lstUserHoldings.TabIndex = 7;
            // 
            // cmbOrderType
            // 
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Location = new Point(653, 67);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new Size(182, 33);
            cmbOrderType.TabIndex = 8;
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(12, 458);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(181, 33);
            cmbUsers.TabIndex = 9;
            // 
            // txtStockPrice
            // 
            txtStockPrice.Location = new Point(220, 290);
            txtStockPrice.Name = "txtStockPrice";
            txtStockPrice.Size = new Size(180, 31);
            txtStockPrice.TabIndex = 10;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new Point(654, 146);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.Size = new Size(182, 31);
            txtOrderQuantity.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 75);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 12;
            label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 0;
            label2.Text = "Добаление акций";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 256);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 13;
            label3.Text = "Название акции:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 290);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 14;
            label4.Text = "Цена одной акции:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 418);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 15;
            label5.Text = "Пользователи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label6.Location = new Point(653, 18);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 16;
            label6.Text = "Торговля";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 114);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 17;
            label7.Text = "Название акции:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(540, 149);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 18;
            label8.Text = "Количество:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(485, 72);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 19;
            label9.Text = "Покупка/продажа:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label10.Location = new Point(17, 18);
            label10.Name = "label10";
            label10.Size = new Size(248, 25);
            label10.TabIndex = 20;
            label10.Text = "Регистрация пользователя";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 692);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOrderQuantity);
            Controls.Add(txtStockPrice);
            Controls.Add(cmbUsers);
            Controls.Add(cmbOrderType);
            Controls.Add(lstUserHoldings);
            Controls.Add(btnShowHoldings);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtOrderStockSymbol);
            Controls.Add(btnAddStock);
            Controls.Add(txtStockSymbol);
            Controls.Add(btnRegisterUser);
            Controls.Add(txtUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Торговля на бирже";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Button btnRegisterUser;
        private TextBox txtStockSymbol;
        private Button btnAddStock;
        private TextBox txtOrderStockSymbol;
        private Button btnPlaceOrder;
        private Button btnShowHoldings;
        private ListBox lstUserHoldings;
        private ComboBox cmbOrderType;
        private ComboBox cmbUsers;
        private TextBox txtStockPrice;
        private TextBox txtOrderQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
