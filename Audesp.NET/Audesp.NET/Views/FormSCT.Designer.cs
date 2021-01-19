
namespace Audesp.NET
{
    partial class FormSCT
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
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.TabAjuste = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtProcesso = new System.Windows.Forms.TextBox();
            this.dgvEmpenhos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TabExecucao = new System.Windows.Forms.TabPage();
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.TabControlPrincipal.SuspendLayout();
            this.TabAjuste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpenhos)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlPrincipal.Controls.Add(this.TabAjuste);
            this.TabControlPrincipal.Controls.Add(this.TabExecucao);
            this.TabControlPrincipal.Location = new System.Drawing.Point(9, 39);
            this.TabControlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(1264, 618);
            this.TabControlPrincipal.TabIndex = 0;
            // 
            // TabAjuste
            // 
            this.TabAjuste.Controls.Add(this.btnPesquisar);
            this.TabAjuste.Controls.Add(this.txtProcesso);
            this.TabAjuste.Controls.Add(this.dgvEmpenhos);
            this.TabAjuste.Controls.Add(this.label1);
            this.TabAjuste.Location = new System.Drawing.Point(4, 24);
            this.TabAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.TabAjuste.Name = "TabAjuste";
            this.TabAjuste.Padding = new System.Windows.Forms.Padding(2);
            this.TabAjuste.Size = new System.Drawing.Size(1256, 590);
            this.TabAjuste.TabIndex = 0;
            this.TabAjuste.Text = "Ajuste";
            this.TabAjuste.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(134, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtProcesso
            // 
            this.txtProcesso.Location = new System.Drawing.Point(3, 37);
            this.txtProcesso.Name = "txtProcesso";
            this.txtProcesso.Size = new System.Drawing.Size(125, 23);
            this.txtProcesso.TabIndex = 5;
            this.txtProcesso.TextChanged += new System.EventHandler(this.txtProcesso_TextChanged);
            // 
            // dgvEmpenhos
            // 
            this.dgvEmpenhos.AllowUserToAddRows = false;
            this.dgvEmpenhos.AllowUserToDeleteRows = false;
            this.dgvEmpenhos.AllowUserToResizeRows = false;
            this.dgvEmpenhos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpenhos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpenhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpenhos.Location = new System.Drawing.Point(3, 80);
            this.dgvEmpenhos.Name = "dgvEmpenhos";
            this.dgvEmpenhos.ReadOnly = true;
            this.dgvEmpenhos.RowHeadersVisible = false;
            this.dgvEmpenhos.RowTemplate.Height = 25;
            this.dgvEmpenhos.Size = new System.Drawing.Size(1250, 500);
            this.dgvEmpenhos.TabIndex = 4;
            this.dgvEmpenhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpenhos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processo";
            // 
            // TabExecucao
            // 
            this.TabExecucao.Location = new System.Drawing.Point(4, 24);
            this.TabExecucao.Margin = new System.Windows.Forms.Padding(2);
            this.TabExecucao.Name = "TabExecucao";
            this.TabExecucao.Padding = new System.Windows.Forms.Padding(2);
            this.TabExecucao.Size = new System.Drawing.Size(1256, 590);
            this.TabExecucao.TabIndex = 1;
            this.TabExecucao.Text = "Execução";
            this.TabExecucao.UseVisualStyleBackColor = true;
            // 
            // lblNotificacoes
            // 
            this.lblNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificacoes.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNotificacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotificacoes.ForeColor = System.Drawing.Color.White;
            this.lblNotificacoes.Location = new System.Drawing.Point(9, 6);
            this.lblNotificacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificacoes.Name = "lblNotificacoes";
            this.lblNotificacoes.Size = new System.Drawing.Size(1264, 31);
            this.lblNotificacoes.TabIndex = 1;
            this.lblNotificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Location = new System.Drawing.Point(0, 659);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.StatusStripMain.Size = new System.Drawing.Size(1284, 22);
            this.StatusStripMain.TabIndex = 2;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // FormSCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.lblNotificacoes);
            this.Controls.Add(this.TabControlPrincipal);
            this.Name = "FormSCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audesp.NET";
            this.TabControlPrincipal.ResumeLayout(false);
            this.TabAjuste.ResumeLayout(false);
            this.TabAjuste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpenhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage TabAjuste;
        private System.Windows.Forms.TabPage TabExecucao;
        private System.Windows.Forms.Label lblNotificacoes;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpenhos;
        private System.Windows.Forms.TextBox txtProcesso;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

