namespace HW2612WinForm
{
    partial class myForm
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
            this.bTxt = new System.Windows.Forms.TextBox();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.powerBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.resultsLst = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(276, 64);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(100, 20);
            this.bTxt.TabIndex = 0;
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(87, 64);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(100, 20);
            this.aTxt.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(209, 64);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(43, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(209, 108);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(43, 23);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(209, 152);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(43, 23);
            this.mulBtn.TabIndex = 4;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(209, 194);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(43, 23);
            this.divBtn.TabIndex = 5;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // powerBtn
            // 
            this.powerBtn.Location = new System.Drawing.Point(209, 237);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(43, 23);
            this.powerBtn.TabIndex = 6;
            this.powerBtn.Text = "Γ";
            this.powerBtn.UseVisualStyleBackColor = true;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Location = new System.Drawing.Point(209, 282);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(43, 23);
            this.sqrtBtn.TabIndex = 7;
            this.sqrtBtn.Text = "√";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // resultsLst
            // 
            this.resultsLst.FormattingEnabled = true;
            this.resultsLst.Location = new System.Drawing.Point(96, 350);
            this.resultsLst.Name = "resultsLst";
            this.resultsLst.Size = new System.Drawing.Size(280, 95);
            this.resultsLst.TabIndex = 8;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(397, 422);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(397, 64);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 10;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 489);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultsLst);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.powerBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.bTxt);
            this.Name = "myForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button powerBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.ListBox resultsLst;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button randomBtn;
    }
}

