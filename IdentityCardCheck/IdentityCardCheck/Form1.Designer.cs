namespace IdentityCardCheck
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.校验 = new System.Windows.Forms.Button();
            this.lab_error = new System.Windows.Forms.Label();
            this.lab_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_id.Location = new System.Drawing.Point(12, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(239, 26);
            this.tb_id.TabIndex = 0;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "身份证号";
            // 
            // 校验
            // 
            this.校验.Location = new System.Drawing.Point(162, 68);
            this.校验.Name = "校验";
            this.校验.Size = new System.Drawing.Size(75, 23);
            this.校验.TabIndex = 2;
            this.校验.Text = "开始校核";
            this.校验.UseVisualStyleBackColor = true;
            this.校验.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_error
            // 
            this.lab_error.AutoEllipsis = true;
            this.lab_error.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_error.Location = new System.Drawing.Point(9, 119);
            this.lab_error.Name = "lab_error";
            this.lab_error.Size = new System.Drawing.Size(270, 134);
            this.lab_error.TabIndex = 3;
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(162, 16);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(83, 12);
            this.lab_num.TabIndex = 4;
            this.lab_num.Text = "已录入字数：0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_error);
            this.Controls.Add(this.校验);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "身份证号有效性校核";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 校验;
        private System.Windows.Forms.Label lab_error;
        private System.Windows.Forms.Label lab_num;
    }
}

