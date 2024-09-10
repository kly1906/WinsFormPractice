namespace Bai2_BTH1
{
    partial class frmFont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFont));
            lblName = new Label();
            txtName = new TextBox();
            grbFont = new GroupBox();
            rdbUpper = new RadioButton();
            rdbLower = new RadioButton();
            btnClear = new Button();
            btnResult = new Button();
            txtResult = new TextBox();
            grbFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblName.Location = new Point(27, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(115, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Nhập họ và tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 27);
            txtName.TabIndex = 1;
            // 
            // grbFont
            // 
            grbFont.Controls.Add(rdbUpper);
            grbFont.Controls.Add(rdbLower);
            grbFont.Location = new Point(27, 60);
            grbFont.Name = "grbFont";
            grbFont.Size = new Size(313, 87);
            grbFont.TabIndex = 2;
            grbFont.TabStop = false;
            grbFont.Text = "Chọn kiểu chữ";
            // 
            // rdbUpper
            // 
            rdbUpper.AutoSize = true;
            rdbUpper.Location = new Point(6, 55);
            rdbUpper.Name = "rdbUpper";
            rdbUpper.Size = new Size(123, 23);
            rdbUpper.TabIndex = 3;
            rdbUpper.TabStop = true;
            rdbUpper.Text = "CHỮ IN HOA";
            rdbUpper.UseVisualStyleBackColor = true;
            // 
            // rdbLower
            // 
            rdbLower.AutoSize = true;
            rdbLower.Location = new Point(6, 26);
            rdbLower.Name = "rdbLower";
            rdbLower.Size = new Size(103, 23);
            rdbLower.TabIndex = 2;
            rdbLower.TabStop = true;
            rdbLower.Text = "chữ thường";
            rdbLower.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(358, 69);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 78);
            btnClear.TabIndex = 4;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(27, 167);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(115, 27);
            btnResult.TabIndex = 5;
            btnResult.Text = "Kết quả";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(158, 167);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(261, 27);
            txtResult.TabIndex = 6;
            txtResult.TextChanged += textBox2_TextChanged;
            // 
            // frmFont
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 220);
            Controls.Add(btnResult);
            Controls.Add(btnClear);
            Controls.Add(grbFont);
            Controls.Add(txtResult);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(463, 260);
            MinimumSize = new Size(463, 260);
            Name = "frmFont";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi kiểu chữ";
            Load += frmFont_Load;
            grbFont.ResumeLayout(false);
            grbFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private GroupBox grbFont;
        private RadioButton rdbUpper;
        private RadioButton rdbLower;
        private Button btnClear;
        private Button btnResult;
        private TextBox txtResult;
    }
}