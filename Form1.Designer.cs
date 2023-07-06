namespace TravelRecommendationProject
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            inputBox = new GroupBox();
            startCity = new Label();
            beginning = new ComboBox();
            connect = new Button();
            user = new NumericUpDown();
            begin = new Button();
            cities = new NumericUpDown();
            dollarlabel = new Label();
            budget = new NumericUpDown();
            citiesL = new Label();
            budgetL = new Label();
            userL = new Label();
            output = new TextBox();
            infor = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            nme = new Label();
            i3 = new Label();
            i2 = new Label();
            i1 = new Label();
            inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)budget).BeginInit();
            infor.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // inputBox
            // 
            inputBox.Controls.Add(startCity);
            inputBox.Controls.Add(beginning);
            inputBox.Controls.Add(connect);
            inputBox.Controls.Add(user);
            inputBox.Controls.Add(begin);
            inputBox.Controls.Add(cities);
            inputBox.Controls.Add(dollarlabel);
            inputBox.Controls.Add(budget);
            inputBox.Controls.Add(citiesL);
            inputBox.Controls.Add(budgetL);
            inputBox.Controls.Add(userL);
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(378, 208);
            inputBox.TabIndex = 1;
            inputBox.TabStop = false;
            inputBox.Text = "Your Input";
            // 
            // startCity
            // 
            startCity.AutoSize = true;
            startCity.Location = new Point(12, 127);
            startCity.Name = "startCity";
            startCity.Size = new Size(90, 20);
            startCity.TabIndex = 12;
            startCity.Text = "Starting City";
            // 
            // beginning
            // 
            beginning.DropDownStyle = ComboBoxStyle.DropDownList;
            beginning.FormattingEnabled = true;
            beginning.Location = new Point(221, 124);
            beginning.MaxDropDownItems = 99;
            beginning.Name = "beginning";
            beginning.Size = new Size(151, 28);
            beginning.TabIndex = 11;
            // 
            // connect
            // 
            connect.Location = new Point(183, 162);
            connect.Name = "connect";
            connect.Size = new Size(189, 29);
            connect.TabIndex = 10;
            connect.Text = "Connect to Database";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
            // 
            // user
            // 
            user.Location = new Point(222, 17);
            user.Maximum = new decimal(new int[] { 1339, 0, 0, 0 });
            user.Name = "user";
            user.Size = new Size(150, 27);
            user.TabIndex = 9;
            // 
            // begin
            // 
            begin.Enabled = false;
            begin.Location = new Point(12, 162);
            begin.Name = "begin";
            begin.Size = new Size(165, 29);
            begin.TabIndex = 8;
            begin.Text = "Begin";
            begin.UseVisualStyleBackColor = true;
            begin.Click += begin_Click;
            // 
            // cities
            // 
            cities.Location = new Point(222, 91);
            cities.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            cities.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cities.Name = "cities";
            cities.Size = new Size(150, 27);
            cities.TabIndex = 7;
            cities.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dollarlabel
            // 
            dollarlabel.AutoSize = true;
            dollarlabel.Location = new Point(202, 60);
            dollarlabel.Name = "dollarlabel";
            dollarlabel.Size = new Size(17, 20);
            dollarlabel.TabIndex = 6;
            dollarlabel.Text = "$";
            // 
            // budget
            // 
            budget.DecimalPlaces = 2;
            budget.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            budget.Location = new Point(222, 58);
            budget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            budget.Name = "budget";
            budget.Size = new Size(150, 27);
            budget.TabIndex = 5;
            // 
            // citiesL
            // 
            citiesL.AutoSize = true;
            citiesL.Location = new Point(12, 92);
            citiesL.Name = "citiesL";
            citiesL.Size = new Size(207, 20);
            citiesL.TabIndex = 2;
            citiesL.Text = "Number of Cities to be visited";
            // 
            // budgetL
            // 
            budgetL.AutoSize = true;
            budgetL.Location = new Point(12, 58);
            budgetL.Name = "budgetL";
            budgetL.Size = new Size(57, 20);
            budgetL.TabIndex = 1;
            budgetL.Text = "Budget";
            // 
            // userL
            // 
            userL.AutoSize = true;
            userL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userL.Location = new Point(12, 19);
            userL.Name = "userL";
            userL.Size = new Size(38, 20);
            userL.TabIndex = 0;
            userL.Text = "User";
            // 
            // output
            // 
            output.Location = new Point(407, 12);
            output.Multiline = true;
            output.Name = "output";
            output.PlaceholderText = "List of recommended visits and remaining budget.";
            output.ReadOnly = true;
            output.Size = new Size(381, 368);
            output.TabIndex = 2;
            // 
            // infor
            // 
            infor.Controls.Add(label2);
            infor.Controls.Add(label1);
            infor.Controls.Add(nme);
            infor.Controls.Add(i3);
            infor.Controls.Add(i2);
            infor.Controls.Add(i1);
            infor.Location = new Point(12, 226);
            infor.Name = "infor";
            infor.Size = new Size(378, 154);
            infor.TabIndex = 3;
            infor.TabStop = false;
            infor.Text = "Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 108);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 5;
            label2.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 73);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "320210045";
            // 
            // nme
            // 
            nme.AutoSize = true;
            nme.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nme.Location = new Point(124, 35);
            nme.Name = "nme";
            nme.Size = new Size(163, 25);
            nme.TabIndex = 3;
            nme.Text = "Ali Ehab Mohamed";
            // 
            // i3
            // 
            i3.AutoSize = true;
            i3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            i3.Location = new Point(12, 108);
            i3.Name = "i3";
            i3.Size = new Size(65, 25);
            i3.TabIndex = 2;
            i3.Text = "Group";
            // 
            // i2
            // 
            i2.AutoSize = true;
            i2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            i2.Location = new Point(29, 73);
            i2.Name = "i2";
            i2.Size = new Size(31, 25);
            i2.TabIndex = 1;
            i2.Text = "ID";
            // 
            // i1
            // 
            i1.AutoSize = true;
            i1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            i1.Location = new Point(12, 35);
            i1.Name = "i1";
            i1.Size = new Size(62, 25);
            i1.TabIndex = 0;
            i1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(799, 400);
            Controls.Add(infor);
            Controls.Add(output);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "Travel Recommendation Program";
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user).EndInit();
            ((System.ComponentModel.ISupportInitialize)cities).EndInit();
            ((System.ComponentModel.ISupportInitialize)budget).EndInit();
            infor.ResumeLayout(false);
            infor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox inputBox;
        private Label citiesL;
        private Label budgetL;
        private Label userL;
        private NumericUpDown budget;
        private Button begin;
        private NumericUpDown cities;
        private Label dollarlabel;
        private NumericUpDown user;
        private Button connect;
        private TextBox output;
        private ComboBox beginning;
        private Label startCity;
        private GroupBox infor;
        private Label label2;
        private Label label1;
        private Label nme;
        private Label i3;
        private Label i2;
        private Label i1;
    }
}