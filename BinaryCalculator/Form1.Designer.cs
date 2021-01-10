
namespace BinaryCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonRightBracket = new System.Windows.Forms.Button();
            this.buttonLeftBracket = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 72);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(4, 74);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(113, 73);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "AC";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOr
            // 
            this.buttonOr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOr.BackColor = System.Drawing.Color.White;
            this.buttonOr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOr.FlatAppearance.BorderSize = 0;
            this.buttonOr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonOr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOr.Location = new System.Drawing.Point(119, 74);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(113, 73);
            this.buttonOr.TabIndex = 3;
            this.buttonOr.Text = "|";
            this.buttonOr.UseVisualStyleBackColor = false;
            this.buttonOr.Click += new System.EventHandler(this.buttonOr_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBackspace.BackColor = System.Drawing.Color.White;
            this.buttonBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBackspace.FlatAppearance.BorderSize = 0;
            this.buttonBackspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackspace.Image")));
            this.buttonBackspace.Location = new System.Drawing.Point(234, 74);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(113, 73);
            this.buttonBackspace.TabIndex = 4;
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnd.BackColor = System.Drawing.Color.White;
            this.buttonAnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAnd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAnd.FlatAppearance.BorderSize = 0;
            this.buttonAnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonAnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnd.Location = new System.Drawing.Point(234, 149);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(113, 73);
            this.buttonAnd.TabIndex = 7;
            this.buttonAnd.Text = "&";
            this.buttonAnd.UseMnemonic = false;
            this.buttonAnd.UseVisualStyleBackColor = false;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNum1.BackColor = System.Drawing.Color.White;
            this.buttonNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNum1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum1.FlatAppearance.BorderSize = 0;
            this.buttonNum1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNum1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNum1.Location = new System.Drawing.Point(119, 149);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(113, 73);
            this.buttonNum1.TabIndex = 6;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum1_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNum0.BackColor = System.Drawing.Color.White;
            this.buttonNum0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNum0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum0.FlatAppearance.BorderSize = 0;
            this.buttonNum0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNum0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNum0.Location = new System.Drawing.Point(4, 149);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(113, 73);
            this.buttonNum0.TabIndex = 5;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_Click);
            // 
            // buttonXor
            // 
            this.buttonXor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXor.BackColor = System.Drawing.Color.White;
            this.buttonXor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonXor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonXor.FlatAppearance.BorderSize = 0;
            this.buttonXor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonXor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonXor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXor.Location = new System.Drawing.Point(234, 224);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(113, 73);
            this.buttonXor.TabIndex = 10;
            this.buttonXor.Text = "^";
            this.buttonXor.UseVisualStyleBackColor = false;
            this.buttonXor.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // buttonRightBracket
            // 
            this.buttonRightBracket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRightBracket.BackColor = System.Drawing.Color.White;
            this.buttonRightBracket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRightBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRightBracket.FlatAppearance.BorderSize = 0;
            this.buttonRightBracket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRightBracket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonRightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRightBracket.Location = new System.Drawing.Point(119, 224);
            this.buttonRightBracket.Name = "buttonRightBracket";
            this.buttonRightBracket.Size = new System.Drawing.Size(113, 73);
            this.buttonRightBracket.TabIndex = 9;
            this.buttonRightBracket.Text = ")";
            this.buttonRightBracket.UseVisualStyleBackColor = false;
            this.buttonRightBracket.Click += new System.EventHandler(this.buttonRightBracket_Click);
            // 
            // buttonLeftBracket
            // 
            this.buttonLeftBracket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLeftBracket.BackColor = System.Drawing.Color.White;
            this.buttonLeftBracket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLeftBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLeftBracket.FlatAppearance.BorderSize = 0;
            this.buttonLeftBracket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonLeftBracket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonLeftBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeftBracket.Location = new System.Drawing.Point(4, 224);
            this.buttonLeftBracket.Name = "buttonLeftBracket";
            this.buttonLeftBracket.Size = new System.Drawing.Size(113, 73);
            this.buttonLeftBracket.TabIndex = 8;
            this.buttonLeftBracket.Text = "(";
            this.buttonLeftBracket.UseVisualStyleBackColor = false;
            this.buttonLeftBracket.Click += new System.EventHandler(this.buttonLeftBracket_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculate.BackColor = System.Drawing.Color.White;
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(4, 299);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(343, 73);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Результат:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(4, 420);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(343, 33);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 473);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonXor);
            this.Controls.Add(this.buttonRightBracket);
            this.Controls.Add(this.buttonLeftBracket);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonOr);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Binary Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonXor;
        private System.Windows.Forms.Button buttonRightBracket;
        private System.Windows.Forms.Button buttonLeftBracket;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

