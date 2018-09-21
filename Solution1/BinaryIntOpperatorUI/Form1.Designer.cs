namespace BinaryIntOpperatorUI
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
            this.ui_radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.ui_radioButtonSub = new System.Windows.Forms.RadioButton();
            this.ui_textBoxX = new System.Windows.Forms.TextBox();
            this.ui_labelOperator = new System.Windows.Forms.Label();
            this.ui_textBoxY = new System.Windows.Forms.TextBox();
            this.ui_buttonOperate = new System.Windows.Forms.Button();
            this.ui_texBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ui_radioButtonAdd
            // 
            this.ui_radioButtonAdd.AutoSize = true;
            this.ui_radioButtonAdd.Checked = true;
            this.ui_radioButtonAdd.Location = new System.Drawing.Point(21, 20);
            this.ui_radioButtonAdd.Name = "ui_radioButtonAdd";
            this.ui_radioButtonAdd.Size = new System.Drawing.Size(44, 17);
            this.ui_radioButtonAdd.TabIndex = 0;
            this.ui_radioButtonAdd.TabStop = true;
            this.ui_radioButtonAdd.Text = "Add";
            this.ui_radioButtonAdd.UseVisualStyleBackColor = true;
            this.ui_radioButtonAdd.CheckedChanged += new System.EventHandler(this.ui_radioButtonAdd_CheckedChanged);
            // 
            // ui_radioButtonSub
            // 
            this.ui_radioButtonSub.AutoSize = true;
            this.ui_radioButtonSub.Location = new System.Drawing.Point(21, 55);
            this.ui_radioButtonSub.Name = "ui_radioButtonSub";
            this.ui_radioButtonSub.Size = new System.Drawing.Size(65, 17);
            this.ui_radioButtonSub.TabIndex = 1;
            this.ui_radioButtonSub.Text = "Subtract";
            this.ui_radioButtonSub.UseVisualStyleBackColor = true;
            this.ui_radioButtonSub.CheckedChanged += new System.EventHandler(this.ui_radioButtonSub_CheckedChanged);
            // 
            // ui_textBoxX
            // 
            this.ui_textBoxX.Location = new System.Drawing.Point(21, 119);
            this.ui_textBoxX.Name = "ui_textBoxX";
            this.ui_textBoxX.Size = new System.Drawing.Size(100, 20);
            this.ui_textBoxX.TabIndex = 2;
            // 
            // ui_labelOperator
            // 
            this.ui_labelOperator.AutoSize = true;
            this.ui_labelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_labelOperator.Location = new System.Drawing.Point(127, 117);
            this.ui_labelOperator.Name = "ui_labelOperator";
            this.ui_labelOperator.Size = new System.Drawing.Size(21, 24);
            this.ui_labelOperator.TabIndex = 3;
            this.ui_labelOperator.Text = "+";
            // 
            // ui_textBoxY
            // 
            this.ui_textBoxY.Location = new System.Drawing.Point(154, 119);
            this.ui_textBoxY.Name = "ui_textBoxY";
            this.ui_textBoxY.Size = new System.Drawing.Size(100, 20);
            this.ui_textBoxY.TabIndex = 4;
            // 
            // ui_buttonOperate
            // 
            this.ui_buttonOperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_buttonOperate.Location = new System.Drawing.Point(260, 113);
            this.ui_buttonOperate.Name = "ui_buttonOperate";
            this.ui_buttonOperate.Size = new System.Drawing.Size(26, 33);
            this.ui_buttonOperate.TabIndex = 5;
            this.ui_buttonOperate.Text = "=";
            this.ui_buttonOperate.UseVisualStyleBackColor = true;
            this.ui_buttonOperate.Click += new System.EventHandler(this.ui_buttonOperate_Click);
            // 
            // ui_texBoxAnswer
            // 
            this.ui_texBoxAnswer.Location = new System.Drawing.Point(292, 119);
            this.ui_texBoxAnswer.Name = "ui_texBoxAnswer";
            this.ui_texBoxAnswer.ReadOnly = true;
            this.ui_texBoxAnswer.Size = new System.Drawing.Size(100, 20);
            this.ui_texBoxAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 159);
            this.Controls.Add(this.ui_texBoxAnswer);
            this.Controls.Add(this.ui_buttonOperate);
            this.Controls.Add(this.ui_textBoxY);
            this.Controls.Add(this.ui_labelOperator);
            this.Controls.Add(this.ui_textBoxX);
            this.Controls.Add(this.ui_radioButtonSub);
            this.Controls.Add(this.ui_radioButtonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ui_radioButtonAdd;
        private System.Windows.Forms.RadioButton ui_radioButtonSub;
        private System.Windows.Forms.TextBox ui_textBoxX;
        private System.Windows.Forms.Label ui_labelOperator;
        private System.Windows.Forms.TextBox ui_textBoxY;
        private System.Windows.Forms.Button ui_buttonOperate;
        private System.Windows.Forms.TextBox ui_texBoxAnswer;
    }
}

