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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Display = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearHistoryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Subtract_Btn = new System.Windows.Forms.Button();
            this.Multiply_Btn = new System.Windows.Forms.Button();
            this.Divide_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
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
            this.Decimal_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.PiBtn = new System.Windows.Forms.Button();
            this.SquareRootBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
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
            this.Display.Enter += new System.EventHandler(this.Display_Enter);
            this.Display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Display_KeyDown);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.History.ContextMenuStrip = this.contextMenuStrip1;
            this.History.Location = new System.Drawing.Point(12, 37);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(226, 289);
            this.History.TabIndex = 1;
            this.History.TabStop = false;
            this.History.Text = "";
            this.History.KeyDown += new System.Windows.Forms.KeyEventHandler(this.History_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearHistoryBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            // 
            // ClearHistoryBtn
            // 
            this.ClearHistoryBtn.Name = "ClearHistoryBtn";
            this.ClearHistoryBtn.Size = new System.Drawing.Size(158, 22);
            this.ClearHistoryBtn.Text = "Clear History";
            this.ClearHistoryBtn.Click += new System.EventHandler(this.ClearHistoryBtn_Click);
            // 
            // Subtract_Btn
            // 
            this.Subtract_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtract_Btn.Location = new System.Drawing.Point(487, 214);
            this.Subtract_Btn.Name = "Subtract_Btn";
            this.Subtract_Btn.Size = new System.Drawing.Size(112, 53);
            this.Subtract_Btn.TabIndex = 2;
            this.Subtract_Btn.Text = "-";
            this.Subtract_Btn.UseVisualStyleBackColor = true;
            this.Subtract_Btn.Click += new System.EventHandler(this.ClickButton);
            // 
            // Multiply_Btn
            // 
            this.Multiply_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiply_Btn.Location = new System.Drawing.Point(487, 155);
            this.Multiply_Btn.Name = "Multiply_Btn";
            this.Multiply_Btn.Size = new System.Drawing.Size(112, 53);
            this.Multiply_Btn.TabIndex = 3;
            this.Multiply_Btn.Text = "X";
            this.Multiply_Btn.UseVisualStyleBackColor = true;
            this.Multiply_Btn.Click += new System.EventHandler(this.ClickButton);
            // 
            // Divide_Btn
            // 
            this.Divide_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide_Btn.Location = new System.Drawing.Point(487, 96);
            this.Divide_Btn.Name = "Divide_Btn";
            this.Divide_Btn.Size = new System.Drawing.Size(112, 53);
            this.Divide_Btn.TabIndex = 4;
            this.Divide_Btn.Text = "/";
            this.Divide_Btn.UseVisualStyleBackColor = true;
            this.Divide_Btn.Click += new System.EventHandler(this.ClickButton);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Btn.Location = new System.Drawing.Point(487, 273);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(112, 53);
            this.Add_Btn.TabIndex = 5;
            this.Add_Btn.Text = "+";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.ClickButton);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualBtn.Location = new System.Drawing.Point(244, 273);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(156, 53);
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
            this.Num_8.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_7.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_9.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_4.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_5.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_6.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_1.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_2.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_3.Click += new System.EventHandler(this.ClickButton);
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
            this.Num_0.Click += new System.EventHandler(this.ClickButton);
            // 
            // Decimal_Btn
            // 
            this.Decimal_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decimal_Btn.Location = new System.Drawing.Point(325, 214);
            this.Decimal_Btn.Name = "Decimal_Btn";
            this.Decimal_Btn.Size = new System.Drawing.Size(75, 53);
            this.Decimal_Btn.TabIndex = 18;
            this.Decimal_Btn.Text = ".";
            this.Decimal_Btn.UseVisualStyleBackColor = true;
            this.Decimal_Btn.Click += new System.EventHandler(this.ClickButton);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_Btn.Location = new System.Drawing.Point(487, 37);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(112, 53);
            this.Delete_Btn.TabIndex = 19;
            this.Delete_Btn.Text = "«";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PiBtn
            // 
            this.PiBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PiBtn.Image = global::lommeregner.Properties.Resources.Apps_preferences_kcalc_constants_icon;
            this.PiBtn.Location = new System.Drawing.Point(406, 273);
            this.PiBtn.Name = "PiBtn";
            this.PiBtn.Size = new System.Drawing.Size(75, 53);
            this.PiBtn.TabIndex = 20;
            this.PiBtn.UseVisualStyleBackColor = true;
            this.PiBtn.Click += new System.EventHandler(this.PiBtn_Click);
            // 
            // SquareRootBtn
            // 
            this.SquareRootBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SquareRootBtn.Image = ((System.Drawing.Image)(resources.GetObject("SquareRootBtn.Image")));
            this.SquareRootBtn.Location = new System.Drawing.Point(406, 214);
            this.SquareRootBtn.Name = "SquareRootBtn";
            this.SquareRootBtn.Size = new System.Drawing.Size(75, 53);
            this.SquareRootBtn.TabIndex = 21;
            this.SquareRootBtn.UseVisualStyleBackColor = true;
            this.SquareRootBtn.Click += new System.EventHandler(this.SquareRootBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 332);
            this.Controls.Add(this.SquareRootBtn);
            this.Controls.Add(this.PiBtn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Decimal_Btn);
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
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Divide_Btn);
            this.Controls.Add(this.Multiply_Btn);
            this.Controls.Add(this.Subtract_Btn);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Lommeregner";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private RichTextBox History;
        private Button Subtract_Btn;
        private Button Multiply_Btn;
        private Button Divide_Btn;
        private Button Add_Btn;
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
        private Button Decimal_Btn;
        private Button Delete_Btn;
        private Button PiBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ClearHistoryBtn;
        private Button SquareRootBtn;
    }
}