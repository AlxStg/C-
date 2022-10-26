namespace Aula60
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Main = new System.Windows.Forms.Label();
            this.tb_Main = new System.Windows.Forms.TextBox();
            this.btn_Main = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Main
            // 
            this.lb_Main.AutoSize = true;
            this.lb_Main.Location = new System.Drawing.Point(107, 48);
            this.lb_Main.Name = "lb_Main";
            this.lb_Main.Size = new System.Drawing.Size(208, 13);
            this.lb_Main.TabIndex = 0;
            this.lb_Main.Text = "SANTIAGO CULTURAS SUSTENTÁVEIS";
            // 
            // tb_Main
            // 
            this.tb_Main.Location = new System.Drawing.Point(110, 94);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.Size = new System.Drawing.Size(205, 20);
            this.tb_Main.TabIndex = 1;
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(123, 186);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(192, 23);
            this.btn_Main.TabIndex = 2;
            this.btn_Main.Text = "OK";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(346, 48);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "F5";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.tb_Main);
            this.Controls.Add(this.lb_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Main;
        private System.Windows.Forms.TextBox tb_Main;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_refresh;
    }
}

