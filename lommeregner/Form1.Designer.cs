namespace lommeregner
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Display = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.RichTextBox();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.Num_8 = new System.Windows.Forms.Button();
            this.Num_7 = new System.Windows.Forms.Button();
            this.Num_9 = new System.Windows.Forms.Button();
            this.Num_4 = new System.Windows.Forms.Button();
            this.Num_5 = new System.Windows.Forms.Button();
            this.Num_6 = new System.Windows.Forms.Button();
            this.Num_1 = new System.Windows.Forms.Button();
            this.Num_2 = new System.Windows.Forms.Button();
            this.Num_3 = new System.Windows.Forms.Button();
            this.Num_0 = new System.Windows.Forms.Button();
            this.Num_Decimal = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(607, 31);
            this.Display.TabIndex = 0;
            this.Display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Display_KeyDown);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.History.Location = new System.Drawing.Point(12, 37);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(226, 289);
            this.History.TabIndex = 1;
            this.History.Text = "";
            this.History.KeyDown += new System.Windows.Forms.KeyEventHandler(this.History_KeyDown);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtractBtn.Location = new System.Drawing.Point(487, 214);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(112, 53);
            this.SubtractBtn.TabIndex = 2;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyBtn.Location = new System.Drawing.Point(487, 155);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(112, 53);
            this.MultiplyBtn.TabIndex = 3;
            this.MultiplyBtn.Text = "X";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideBtn.Location = new System.Drawing.Point(487, 96);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(112, 53);
            this.DivideBtn.TabIndex = 4;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(487, 273);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 53);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualBtn.Location = new System.Drawing.Point(244, 273);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(237, 53);
            this.EqualBtn.TabIndex = 6;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // Num_8
            // 
            this.Num_8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_8.Location = new System.Drawing.Point(325, 37);
            this.Num_8.Name = "Num_8";
            this.Num_8.Size = new System.Drawing.Size(75, 53);
            this.Num_8.TabIndex = 7;
            this.Num_8.Text = "8";
            this.Num_8.UseVisualStyleBackColor = true;
            this.Num_8.Click += new System.EventHandler(this.Num_8_Click);
            // 
            // Num_7
            // 
            this.Num_7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_7.Location = new System.Drawing.Point(244, 37);
            this.Num_7.Name = "Num_7";
            this.Num_7.Size = new System.Drawing.Size(75, 53);
            this.Num_7.TabIndex = 8;
            this.Num_7.Text = "7";
            this.Num_7.UseVisualStyleBackColor = true;
            this.Num_7.Click += new System.EventHandler(this.Num_7_Click);
            // 
            // Num_9
            // 
            this.Num_9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_9.Location = new System.Drawing.Point(406, 37);
            this.Num_9.Name = "Num_9";
            this.Num_9.Size = new System.Drawing.Size(75, 53);
            this.Num_9.TabIndex = 9;
            this.Num_9.Text = "9";
            this.Num_9.UseVisualStyleBackColor = true;
            this.Num_9.Click += new System.EventHandler(this.Num_9_Click);
            // 
            // Num_4
            // 
            this.Num_4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_4.Location = new System.Drawing.Point(244, 96);
            this.Num_4.Name = "Num_4";
            this.Num_4.Size = new System.Drawing.Size(75, 53);
            this.Num_4.TabIndex = 10;
            this.Num_4.Text = "4";
            this.Num_4.UseVisualStyleBackColor = true;
            this.Num_4.Click += new System.EventHandler(this.Num_4_Click);
            // 
            // Num_5
            // 
            this.Num_5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_5.Location = new System.Drawing.Point(325, 96);
            this.Num_5.Name = "Num_5";
            this.Num_5.Size = new System.Drawing.Size(75, 53);
            this.Num_5.TabIndex = 11;
            this.Num_5.Text = "5";
            this.Num_5.UseVisualStyleBackColor = true;
            this.Num_5.Click += new System.EventHandler(this.Num_5_Click);
            // 
            // Num_6
            // 
            this.Num_6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_6.Location = new System.Drawing.Point(406, 96);
            this.Num_6.Name = "Num_6";
            this.Num_6.Size = new System.Drawing.Size(75, 53);
            this.Num_6.TabIndex = 12;
            this.Num_6.Text = "6";
            this.Num_6.UseVisualStyleBackColor = true;
            this.Num_6.Click += new System.EventHandler(this.Num_6_Click);
            // 
            // Num_1
            // 
            this.Num_1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_1.Location = new System.Drawing.Point(244, 155);
            this.Num_1.Name = "Num_1";
            this.Num_1.Size = new System.Drawing.Size(75, 53);
            this.Num_1.TabIndex = 13;
            this.Num_1.Text = "1";
            this.Num_1.UseVisualStyleBackColor = true;
            this.Num_1.Click += new System.EventHandler(this.Num_1_Click);
            // 
            // Num_2
            // 
            this.Num_2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_2.Location = new System.Drawing.Point(325, 155);
            this.Num_2.Name = "Num_2";
            this.Num_2.Size = new System.Drawing.Size(75, 53);
            this.Num_2.TabIndex = 14;
            this.Num_2.Text = "2";
            this.Num_2.UseVisualStyleBackColor = true;
            this.Num_2.Click += new System.EventHandler(this.Num_2_Click);
            // 
            // Num_3
            // 
            this.Num_3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_3.Location = new System.Drawing.Point(406, 155);
            this.Num_3.Name = "Num_3";
            this.Num_3.Size = new System.Drawing.Size(75, 53);
            this.Num_3.TabIndex = 15;
            this.Num_3.Text = "3";
            this.Num_3.UseVisualStyleBackColor = true;
            this.Num_3.Click += new System.EventHandler(this.Num_3_Click);
            // 
            // Num_0
            // 
            this.Num_0.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_0.Location = new System.Drawing.Point(244, 214);
            this.Num_0.Name = "Num_0";
            this.Num_0.Size = new System.Drawing.Size(75, 53);
            this.Num_0.TabIndex = 17;
            this.Num_0.Text = "0";
            this.Num_0.UseVisualStyleBackColor = true;
            this.Num_0.Click += new System.EventHandler(this.Num_0_Click);
            // 
            // Num_Decimal
            // 
            this.Num_Decimal.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num_Decimal.Location = new System.Drawing.Point(406, 214);
            this.Num_Decimal.Name = "Num_Decimal";
            this.Num_Decimal.Size = new System.Drawing.Size(75, 53);
            this.Num_Decimal.TabIndex = 18;
            this.Num_Decimal.Text = ".";
            this.Num_Decimal.UseVisualStyleBackColor = true;
            this.Num_Decimal.Click += new System.EventHandler(this.Num_Decimal_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(487, 37);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 53);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "«";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PiBtn
            // 
            this.PiBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PiBtn.Image = global::lommeregner.Properties.Resources.Apps_preferences_kcalc_constants_icon;
            this.PiBtn.Location = new System.Drawing.Point(325, 214);
            this.PiBtn.Name = "PiBtn";
            this.PiBtn.Size = new System.Drawing.Size(75, 53);
            this.PiBtn.TabIndex = 20;
            this.PiBtn.UseVisualStyleBackColor = true;
            this.PiBtn.Click += new System.EventHandler(this.PiBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 332);
            this.Controls.Add(this.PiBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Num_Decimal);
            this.Controls.Add(this.Num_0);
            this.Controls.Add(this.Num_3);
            this.Controls.Add(this.Num_2);
            this.Controls.Add(this.Num_1);
            this.Controls.Add(this.Num_6);
            this.Controls.Add(this.Num_5);
            this.Controls.Add(this.Num_4);
            this.Controls.Add(this.Num_9);
            this.Controls.Add(this.Num_7);
            this.Controls.Add(this.Num_8);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Lommeregner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private RichTextBox History;
        private Button SubtractBtn;
        private Button MultiplyBtn;
        private Button DivideBtn;
        private Button AddBtn;
        private Button EqualBtn;
        private Button Num_8;
        private Button Num_7;
        private Button Num_9;
        private Button Num_4;
        private Button Num_5;
        private Button Num_6;
        private Button Num_1;
        private Button Num_2;
        private Button Num_3;
        private Button Num_0;
        private Button Num_Decimal;
        private Button DeleteBtn;
        private Button PiBtn;
    }
}