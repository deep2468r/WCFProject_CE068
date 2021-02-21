
namespace MyCityClient
{
    partial class RegisterForm
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
            this.userid_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter UserID :- ";
            // 
            // userid_textBox
            // 
            this.userid_textBox.Location = new System.Drawing.Point(235, 86);
            this.userid_textBox.Name = "userid_textBox";
            this.userid_textBox.Size = new System.Drawing.Size(100, 22);
            this.userid_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password :- ";
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(235, 170);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(100, 22);
            this.pass_textBox.TabIndex = 3;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(153, 242);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 27);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userid_textBox);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userid_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button register_button;
    }
}