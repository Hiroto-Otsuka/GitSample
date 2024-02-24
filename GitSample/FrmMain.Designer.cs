namespace GitSample
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txtExpression1 = new System.Windows.Forms.TextBox();
            this.txtExpression2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 22);
            label1.TabIndex = 0;
            label1.Text = "値１";
            // 
            // txtExpression1
            // 
            this.txtExpression1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression1.Location = new System.Drawing.Point(16, 43);
            this.txtExpression1.Name = "txtExpression1";
            this.txtExpression1.Size = new System.Drawing.Size(162, 29);
            this.txtExpression1.TabIndex = 1;
            // 
            // txtExpression2
            // 
            this.txtExpression2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression2.Location = new System.Drawing.Point(205, 43);
            this.txtExpression2.Name = "txtExpression2";
            this.txtExpression2.Size = new System.Drawing.Size(162, 29);
            this.txtExpression2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label2.Location = new System.Drawing.Point(201, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 22);
            label2.TabIndex = 2;
            label2.Text = "値２";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(16, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(351, 29);
            this.txtResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label3.Location = new System.Drawing.Point(12, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 22);
            label3.TabIndex = 4;
            label3.Text = "結果";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtExpression2);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtExpression1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression1;
        private System.Windows.Forms.TextBox txtExpression2;
        private System.Windows.Forms.TextBox txtResult;
    }
}

