namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userInput = new System.Windows.Forms.TextBox();
            this.calculationResult = new System.Windows.Forms.Label();
            this.btnPannel = new System.Windows.Forms.TableLayoutPanel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnEql = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.Location = new System.Drawing.Point(12, 12);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(325, 22);
            this.userInput.TabIndex = 0;
            // 
            // calculationResult
            // 
            this.calculationResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculationResult.Location = new System.Drawing.Point(13, 41);
            this.calculationResult.Name = "calculationResult";
            this.calculationResult.Size = new System.Drawing.Size(517, 27);
            this.calculationResult.TabIndex = 1;
            this.calculationResult.Text = "Please enter equation and press enter or =";
            // 
            // btnPannel
            // 
            this.btnPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPannel.ColumnCount = 4;
            this.btnPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPannel.Controls.Add(this.btnC, 0, 4);
            this.btnPannel.Controls.Add(this.btnEql, 3, 4);
            this.btnPannel.Controls.Add(this.BtnDot, 2, 4);
            this.btnPannel.Controls.Add(this.btn0, 1, 4);
            this.btnPannel.Controls.Add(this.btnPlus, 3, 3);
            this.btnPannel.Controls.Add(this.btn3, 2, 3);
            this.btnPannel.Controls.Add(this.btn2, 1, 3);
            this.btnPannel.Controls.Add(this.btn1, 0, 3);
            this.btnPannel.Controls.Add(this.btnMinus, 3, 2);
            this.btnPannel.Controls.Add(this.btn6, 2, 2);
            this.btnPannel.Controls.Add(this.btn5, 1, 2);
            this.btnPannel.Controls.Add(this.btn4, 0, 2);
            this.btnPannel.Controls.Add(this.btnMul, 3, 1);
            this.btnPannel.Controls.Add(this.btn9, 2, 1);
            this.btnPannel.Controls.Add(this.btn8, 1, 1);
            this.btnPannel.Controls.Add(this.btn7, 0, 1);
            this.btnPannel.Controls.Add(this.btnDivide, 3, 0);
            this.btnPannel.Controls.Add(this.btnDel, 2, 0);
            this.btnPannel.Controls.Add(this.btnCE, 0, 0);
            this.btnPannel.Location = new System.Drawing.Point(12, 71);
            this.btnPannel.Name = "btnPannel";
            this.btnPannel.RowCount = 5;
            this.btnPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnPannel.Size = new System.Drawing.Size(325, 377);
            this.btnPannel.TabIndex = 2;
            // 
            // btnC
            // 
            this.btnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Location = new System.Drawing.Point(3, 303);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 71);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnEql
            // 
            this.btnEql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEql.Location = new System.Drawing.Point(246, 303);
            this.btnEql.Name = "btnEql";
            this.btnEql.Size = new System.Drawing.Size(76, 71);
            this.btnEql.TabIndex = 19;
            this.btnEql.Text = "=";
            this.btnEql.UseVisualStyleBackColor = true;
            this.btnEql.Click += new System.EventHandler(this.btnEql_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDot.Location = new System.Drawing.Point(165, 303);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(75, 71);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(84, 303);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 71);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(246, 228);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 69);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(165, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 69);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(84, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 69);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 69);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(246, 153);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 69);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(165, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 69);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(84, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 69);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 69);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnMul
            // 
            this.btnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMul.Location = new System.Drawing.Point(246, 78);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(76, 69);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(165, 78);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 69);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(84, 78);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 69);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 78);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 69);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Location = new System.Drawing.Point(246, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(76, 69);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(165, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 69);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCE
            // 
            this.btnCE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Location = new System.Drawing.Point(3, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 69);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEql;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnC;
            this.ClientSize = new System.Drawing.Size(349, 460);
            this.Controls.Add(this.btnPannel);
            this.Controls.Add(this.calculationResult);
            this.Controls.Add(this.userInput);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.btnPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label calculationResult;
        private System.Windows.Forms.TableLayoutPanel btnPannel;
        private System.Windows.Forms.Button btnEql;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
    }
}

