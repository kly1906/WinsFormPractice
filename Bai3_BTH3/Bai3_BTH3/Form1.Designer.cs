namespace Bai3_BTH3
{
    partial class frmcbb
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
            grbInput = new GroupBox();
            cbbUpdate = new ComboBox();
            btnUpdate = new Button();
            txtInput = new TextBox();
            groupBox2 = new GroupBox();
            lstDivisor = new ListBox();
            btnSum = new Button();
            btntEven = new Button();
            button4 = new Button();
            button5 = new Button();
            grbInput.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grbInput
            // 
            grbInput.Controls.Add(cbbUpdate);
            grbInput.Controls.Add(btnUpdate);
            grbInput.Controls.Add(txtInput);
            grbInput.Location = new Point(38, 12);
            grbInput.Name = "grbInput";
            grbInput.Size = new Size(273, 133);
            grbInput.TabIndex = 0;
            grbInput.TabStop = false;
            grbInput.Text = "Nhập số";
            // 
            // cbbUpdate
            // 
            cbbUpdate.FormattingEnabled = true;
            cbbUpdate.Location = new Point(16, 78);
            cbbUpdate.Name = "cbbUpdate";
            cbbUpdate.Size = new Size(236, 29);
            cbbUpdate.TabIndex = 2;
            cbbUpdate.SelectedIndexChanged += cbbUpdate_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(171, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 39);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "&Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(16, 28);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(149, 29);
            txtInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDivisor);
            groupBox2.Location = new Point(365, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // lstDivisor
            // 
            lstDivisor.FormattingEnabled = true;
            lstDivisor.ItemHeight = 21;
            lstDivisor.Location = new Point(17, 28);
            lstDivisor.Name = "lstDivisor";
            lstDivisor.ScrollAlwaysVisible = true;
            lstDivisor.Size = new Size(179, 88);
            lstDivisor.TabIndex = 3;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(365, 151);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(212, 39);
            btnSum.TabIndex = 4;
            btnSum.Text = "&Tổng các ước số";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btntEven
            // 
            btntEven.Location = new Point(365, 196);
            btntEven.Name = "btntEven";
            btntEven.Size = new Size(212, 39);
            btntEven.TabIndex = 5;
            btntEven.Text = "&Số lượng ước số chẵn";
            btntEven.UseVisualStyleBackColor = true;
            btntEven.Click += btntEven_Click;
            // 
            // button4
            // 
            button4.Location = new Point(365, 241);
            button4.Name = "button4";
            button4.Size = new Size(212, 39);
            button4.TabIndex = 6;
            button4.Text = "&Số lượng ước số nguyên tố";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(226, 241);
            button5.Name = "button5";
            button5.Size = new Size(101, 39);
            button5.TabIndex = 7;
            button5.Text = "&Thoát";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // frmcbb
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 292);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btntEven);
            Controls.Add(btnSum);
            Controls.Add(grbInput);
            Name = "frmcbb";
            Text = "Combobox";
            grbInput.ResumeLayout(false);
            grbInput.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInput;
        private ComboBox cbbUpdate;
        private Button btnUpdate;
        private TextBox txtInput;
        private GroupBox groupBox2;
        private ListBox lstDivisor;
        private Button btnSum;
        private Button btntEven;
        private Button button4;
        private Button button5;
    }
}