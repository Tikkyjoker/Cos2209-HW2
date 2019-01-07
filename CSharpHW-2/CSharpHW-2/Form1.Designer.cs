namespace CSharpHW_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณากรอกรหัสบัตรประชาชน";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(18, 56);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(329, 22);
            this.ID.TabIndex = 1;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(136, 98);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(105, 25);
            this.Check.TabIndex = 2;
            this.Check.Text = "Chack!!";
            this.Check.UseVisualStyleBackColor = true;
            //this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 133);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Check;
    }
}

