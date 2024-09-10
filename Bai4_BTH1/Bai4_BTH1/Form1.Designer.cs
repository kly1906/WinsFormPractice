namespace Bai4_BTH1
{
    partial class frmOperation
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            grbOperation = new GroupBox();
            rdbDiv = new RadioButton();
            rdbMul = new RadioButton();
            rdbSub = new RadioButton();
            rdbAdd = new RadioButton();
            txtResult = new TextBox();
            lblResult = new Label();
            grbOperation.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber1.Location = new Point(57, 26);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(46, 21);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Số 1:";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber2.Location = new Point(57, 62);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(46, 21);
            lblNumber2.TabIndex = 0;
            lblNumber2.Text = "Số 2:";
            lblNumber2.Click += lblNumber2_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(137, 22);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(394, 30);
            txtNum1.TabIndex = 0;
            txtNum1.KeyPress += txtNum1_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(137, 58);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(394, 30);
            txtNum2.TabIndex = 1;
            // 
            // grbOperation
            // 
            grbOperation.Controls.Add(rdbDiv);
            grbOperation.Controls.Add(rdbMul);
            grbOperation.Controls.Add(rdbSub);
            grbOperation.Controls.Add(rdbAdd);
            grbOperation.Location = new Point(57, 110);
            grbOperation.Name = "grbOperation";
            grbOperation.Size = new Size(474, 92);
            grbOperation.TabIndex = 2;
            grbOperation.TabStop = false;
            grbOperation.Text = "Phép tính";
            grbOperation.Enter += grbOperation_Enter;
            // 
            // rdbDiv
            // 
            rdbDiv.AutoSize = true;
            rdbDiv.Location = new Point(386, 38);
            rdbDiv.Name = "rdbDiv";
            rdbDiv.Size = new Size(63, 27);
            rdbDiv.TabIndex = 5;
            rdbDiv.TabStop = true;
            rdbDiv.Text = "Chia";
            rdbDiv.UseVisualStyleBackColor = true;
            rdbDiv.CheckedChanged += rdbDiv_CheckedChanged;
            // 
            // rdbMul
            // 
            rdbMul.AutoSize = true;
            rdbMul.Location = new Point(262, 38);
            rdbMul.Name = "rdbMul";
            rdbMul.Size = new Size(70, 27);
            rdbMul.TabIndex = 4;
            rdbMul.TabStop = true;
            rdbMul.Text = "Nhân";
            rdbMul.UseVisualStyleBackColor = true;
            rdbMul.CheckedChanged += rdbMul_CheckedChanged;
            // 
            // rdbSub
            // 
            rdbSub.AutoSize = true;
            rdbSub.Location = new Point(150, 38);
            rdbSub.Name = "rdbSub";
            rdbSub.Size = new Size(55, 27);
            rdbSub.TabIndex = 3;
            rdbSub.TabStop = true;
            rdbSub.Text = "Trừ";
            rdbSub.UseVisualStyleBackColor = true;
            rdbSub.CheckedChanged += rdbSub_CheckedChanged;
            // 
            // rdbAdd
            // 
            rdbAdd.AutoSize = true;
            rdbAdd.Location = new Point(24, 38);
            rdbAdd.Name = "rdbAdd";
            rdbAdd.Size = new Size(70, 27);
            rdbAdd.TabIndex = 2;
            rdbAdd.TabStop = true;
            rdbAdd.Text = "Cộng";
            rdbAdd.UseVisualStyleBackColor = true;
            rdbAdd.CheckedChanged += rdbAdd_CheckedChanged;
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(137, 230);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(394, 30);
            txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(57, 233);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(77, 23);
            lblResult.TabIndex = 3;
            lblResult.Text = "Kết quả:";
            // 
            // frmOperation
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(605, 288);
            Controls.Add(lblResult);
            Controls.Add(grbOperation);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            MaximumSize = new Size(621, 328);
            MinimumSize = new Size(621, 328);
            Name = "frmOperation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phép tính";
            Load += frmOperation_Load;
            grbOperation.ResumeLayout(false);
            grbOperation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private GroupBox grbOperation;
        private RadioButton rdbDiv;
        private RadioButton rdbMul;
        private RadioButton rdbSub;
        private RadioButton rdbAdd;
        private TextBox txtResult;
        private Label lblResult;
    }
}