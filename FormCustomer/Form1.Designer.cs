namespace FormCustomer
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInput = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEbutton = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.Press4 = new System.Windows.Forms.Button();
            this.Press5 = new System.Windows.Forms.Button();
            this.Press6 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Press1 = new System.Windows.Forms.Button();
            this.Press7 = new System.Windows.Forms.Button();
            this.Press2 = new System.Windows.Forms.Button();
            this.Press8 = new System.Windows.Forms.Button();
            this.Press9 = new System.Windows.Forms.Button();
            this.Press3 = new System.Windows.Forms.Button();
            this.Press0 = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(60, 26);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(280, 20);
            this.UserInput.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Location = new System.Drawing.Point(60, 49);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(280, 51);
            this.Result.TabIndex = 2;
            this.Result.Text = "Please enter an equation and press enter or select =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.CEbutton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.BackSpace, 2, 0);
            this.ButtonsPanel.Controls.Add(this.Press4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.Press5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Press6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.Dot, 2, 4);
            this.ButtonsPanel.Controls.Add(this.Press1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Press7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Press2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Press8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Press9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.Press3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.Press0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.Equals, 3, 4);
            this.ButtonsPanel.Controls.Add(this.Divide, 3, 0);
            this.ButtonsPanel.Controls.Add(this.Multiply, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Minus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Plus, 3, 3);
            this.ButtonsPanel.Location = new System.Drawing.Point(60, 103);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(280, 287);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // CEbutton
            // 
            this.CEbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(64, 51);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSpace.Location = new System.Drawing.Point(143, 3);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(64, 51);
            this.BackSpace.TabIndex = 2;
            this.BackSpace.Text = "Back";
            this.BackSpace.UseVisualStyleBackColor = true;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // Press4
            // 
            this.Press4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press4.Location = new System.Drawing.Point(3, 117);
            this.Press4.Name = "Press4";
            this.Press4.Size = new System.Drawing.Size(64, 51);
            this.Press4.TabIndex = 8;
            this.Press4.Text = "4";
            this.Press4.UseVisualStyleBackColor = true;
            this.Press4.Click += new System.EventHandler(this.Press4_Click);
            // 
            // Press5
            // 
            this.Press5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press5.Location = new System.Drawing.Point(73, 117);
            this.Press5.Name = "Press5";
            this.Press5.Size = new System.Drawing.Size(64, 51);
            this.Press5.TabIndex = 9;
            this.Press5.Text = "5";
            this.Press5.UseVisualStyleBackColor = true;
            this.Press5.Click += new System.EventHandler(this.Press5_Click);
            // 
            // Press6
            // 
            this.Press6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press6.Location = new System.Drawing.Point(143, 117);
            this.Press6.Name = "Press6";
            this.Press6.Size = new System.Drawing.Size(64, 51);
            this.Press6.TabIndex = 10;
            this.Press6.Text = "6";
            this.Press6.UseVisualStyleBackColor = true;
            this.Press6.Click += new System.EventHandler(this.Press6_Click);
            // 
            // Dot
            // 
            this.Dot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dot.Location = new System.Drawing.Point(143, 231);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(64, 53);
            this.Dot.TabIndex = 17;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Press1
            // 
            this.Press1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press1.Location = new System.Drawing.Point(3, 174);
            this.Press1.Name = "Press1";
            this.Press1.Size = new System.Drawing.Size(64, 51);
            this.Press1.TabIndex = 4;
            this.Press1.Text = "1";
            this.Press1.UseVisualStyleBackColor = true;
            this.Press1.Click += new System.EventHandler(this.Press1_Click);
            // 
            // Press7
            // 
            this.Press7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press7.Location = new System.Drawing.Point(3, 60);
            this.Press7.Name = "Press7";
            this.Press7.Size = new System.Drawing.Size(64, 51);
            this.Press7.TabIndex = 12;
            this.Press7.Text = "7";
            this.Press7.UseVisualStyleBackColor = true;
            this.Press7.Click += new System.EventHandler(this.Press7_Click);
            // 
            // Press2
            // 
            this.Press2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press2.Location = new System.Drawing.Point(73, 174);
            this.Press2.Name = "Press2";
            this.Press2.Size = new System.Drawing.Size(64, 51);
            this.Press2.TabIndex = 5;
            this.Press2.Text = "2";
            this.Press2.UseVisualStyleBackColor = true;
            this.Press2.Click += new System.EventHandler(this.Press2_Click);
            // 
            // Press8
            // 
            this.Press8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press8.Location = new System.Drawing.Point(73, 60);
            this.Press8.Name = "Press8";
            this.Press8.Size = new System.Drawing.Size(64, 51);
            this.Press8.TabIndex = 13;
            this.Press8.Text = "8";
            this.Press8.UseVisualStyleBackColor = true;
            this.Press8.Click += new System.EventHandler(this.Press8_Click);
            // 
            // Press9
            // 
            this.Press9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press9.Location = new System.Drawing.Point(143, 60);
            this.Press9.Name = "Press9";
            this.Press9.Size = new System.Drawing.Size(64, 51);
            this.Press9.TabIndex = 14;
            this.Press9.Text = "9";
            this.Press9.UseVisualStyleBackColor = true;
            this.Press9.Click += new System.EventHandler(this.Press9_Click);
            // 
            // Press3
            // 
            this.Press3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press3.Location = new System.Drawing.Point(143, 174);
            this.Press3.Name = "Press3";
            this.Press3.Size = new System.Drawing.Size(64, 51);
            this.Press3.TabIndex = 6;
            this.Press3.Text = "3";
            this.Press3.UseVisualStyleBackColor = true;
            this.Press3.Click += new System.EventHandler(this.Press3_Click);
            // 
            // Press0
            // 
            this.Press0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Press0.Location = new System.Drawing.Point(73, 231);
            this.Press0.Name = "Press0";
            this.Press0.Size = new System.Drawing.Size(64, 53);
            this.Press0.TabIndex = 16;
            this.Press0.Text = "0";
            this.Press0.UseVisualStyleBackColor = true;
            this.Press0.Click += new System.EventHandler(this.Press0_Click);
            // 
            // Equals
            // 
            this.Equals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Equals.Location = new System.Drawing.Point(213, 231);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(64, 53);
            this.Equals.TabIndex = 7;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Divide
            // 
            this.Divide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divide.Location = new System.Drawing.Point(213, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(64, 51);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Multiply.Location = new System.Drawing.Point(213, 60);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(64, 51);
            this.Multiply.TabIndex = 11;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Minus
            // 
            this.Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minus.Location = new System.Drawing.Point(213, 117);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(64, 51);
            this.Minus.TabIndex = 15;
            this.Minus.Text = "---";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(213, 174);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(64, 51);
            this.Plus.TabIndex = 18;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.Equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(402, 425);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.UserInput);
            this.MinimumSize = new System.Drawing.Size(418, 464);
            this.Name = "Calculator";
            this.Text = "Basic Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button Press4;
        private System.Windows.Forms.Button Press5;
        private System.Windows.Forms.Button Press6;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Press1;
        private System.Windows.Forms.Button Press7;
        private System.Windows.Forms.Button Press2;
        private System.Windows.Forms.Button Press8;
        private System.Windows.Forms.Button Press9;
        private System.Windows.Forms.Button Press3;
        private System.Windows.Forms.Button Press0;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
    }
}

