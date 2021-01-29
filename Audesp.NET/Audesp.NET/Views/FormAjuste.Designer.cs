
namespace Audesp.NET.Views
{
    partial class FormAjuste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuste));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpenho = new System.Windows.Forms.TextBox();
            this.btnPreencherLotes = new System.Windows.Forms.Button();
            this.txtLicitacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoAudespLicitacao = new System.Windows.Forms.TextBox();
            this.groupLotes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.dgvLotesAjuste = new System.Windows.Forms.DataGridView();
            this.dgvLotesLicitacao = new System.Windows.Forms.DataGridView();
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.btnTransmitir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkPreVisualizarXml = new System.Windows.Forms.LinkLabel();
            this.groupLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesAjuste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesLicitacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota de Empenho";
            // 
            // txtEmpenho
            // 
            this.txtEmpenho.Location = new System.Drawing.Point(121, 42);
            this.txtEmpenho.MaxLength = 11;
            this.txtEmpenho.Name = "txtEmpenho";
            this.txtEmpenho.ReadOnly = true;
            this.txtEmpenho.Size = new System.Drawing.Size(187, 23);
            this.txtEmpenho.TabIndex = 1;
            // 
            // btnPreencherLotes
            // 
            this.btnPreencherLotes.Image = ((System.Drawing.Image)(resources.GetObject("btnPreencherLotes.Image")));
            this.btnPreencherLotes.Location = new System.Drawing.Point(9, 41);
            this.btnPreencherLotes.Name = "btnPreencherLotes";
            this.btnPreencherLotes.Size = new System.Drawing.Size(106, 23);
            this.btnPreencherLotes.TabIndex = 2;
            this.btnPreencherLotes.Text = "Lotes";
            this.btnPreencherLotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreencherLotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreencherLotes.UseVisualStyleBackColor = true;
            this.btnPreencherLotes.Click += new System.EventHandler(this.btnPreencherLotes_Click);
            // 
            // txtLicitacao
            // 
            this.txtLicitacao.Location = new System.Drawing.Point(314, 42);
            this.txtLicitacao.Name = "txtLicitacao";
            this.txtLicitacao.Size = new System.Drawing.Size(187, 23);
            this.txtLicitacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Licitação (OC, RP, IN, DL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código Audesp da Licitação";
            // 
            // txtCodigoAudespLicitacao
            // 
            this.txtCodigoAudespLicitacao.Location = new System.Drawing.Point(507, 41);
            this.txtCodigoAudespLicitacao.Name = "txtCodigoAudespLicitacao";
            this.txtCodigoAudespLicitacao.Size = new System.Drawing.Size(187, 23);
            this.txtCodigoAudespLicitacao.TabIndex = 3;
            // 
            // groupLotes
            // 
            this.groupLotes.Controls.Add(this.label5);
            this.groupLotes.Controls.Add(this.label4);
            this.groupLotes.Controls.Add(this.btnAddAll);
            this.groupLotes.Controls.Add(this.dgvLotesAjuste);
            this.groupLotes.Controls.Add(this.dgvLotesLicitacao);
            this.groupLotes.Location = new System.Drawing.Point(13, 126);
            this.groupLotes.Name = "groupLotes";
            this.groupLotes.Size = new System.Drawing.Size(701, 333);
            this.groupLotes.TabIndex = 5;
            this.groupLotes.TabStop = false;
            this.groupLotes.Text = "Lotes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lotes do Ajuste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lotes da Licitação:";
            // 
            // btnAddAll
            // 
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.Location = new System.Drawing.Point(395, 172);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(44, 26);
            this.btnAddAll.TabIndex = 3;
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // dgvLotesAjuste
            // 
            this.dgvLotesAjuste.AllowUserToAddRows = false;
            this.dgvLotesAjuste.AllowUserToDeleteRows = false;
            this.dgvLotesAjuste.AllowUserToResizeRows = false;
            this.dgvLotesAjuste.BackgroundColor = System.Drawing.Color.White;
            this.dgvLotesAjuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotesAjuste.Location = new System.Drawing.Point(448, 57);
            this.dgvLotesAjuste.Name = "dgvLotesAjuste";
            this.dgvLotesAjuste.RowHeadersVisible = false;
            this.dgvLotesAjuste.RowTemplate.Height = 25;
            this.dgvLotesAjuste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotesAjuste.Size = new System.Drawing.Size(215, 258);
            this.dgvLotesAjuste.TabIndex = 1;
            this.dgvLotesAjuste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotesAjuste_CellContentClick);
            // 
            // dgvLotesLicitacao
            // 
            this.dgvLotesLicitacao.AllowUserToAddRows = false;
            this.dgvLotesLicitacao.AllowUserToDeleteRows = false;
            this.dgvLotesLicitacao.AllowUserToResizeRows = false;
            this.dgvLotesLicitacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvLotesLicitacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotesLicitacao.Location = new System.Drawing.Point(37, 57);
            this.dgvLotesLicitacao.Name = "dgvLotesLicitacao";
            this.dgvLotesLicitacao.RowHeadersVisible = false;
            this.dgvLotesLicitacao.RowTemplate.Height = 25;
            this.dgvLotesLicitacao.Size = new System.Drawing.Size(349, 258);
            this.dgvLotesLicitacao.TabIndex = 0;
            this.dgvLotesLicitacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotesLicitacao_CellContentClick);
            // 
            // lblNotificacoes
            // 
            this.lblNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificacoes.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNotificacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotificacoes.ForeColor = System.Drawing.Color.White;
            this.lblNotificacoes.Location = new System.Drawing.Point(13, 9);
            this.lblNotificacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificacoes.Name = "lblNotificacoes";
            this.lblNotificacoes.Size = new System.Drawing.Size(706, 31);
            this.lblNotificacoes.TabIndex = 6;
            this.lblNotificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransmitir
            // 
            this.btnTransmitir.Image = ((System.Drawing.Image)(resources.GetObject("btnTransmitir.Image")));
            this.btnTransmitir.Location = new System.Drawing.Point(13, 465);
            this.btnTransmitir.Name = "btnTransmitir";
            this.btnTransmitir.Size = new System.Drawing.Size(125, 32);
            this.btnTransmitir.TabIndex = 7;
            this.btnTransmitir.Text = "Transmitir";
            this.btnTransmitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransmitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransmitir.UseVisualStyleBackColor = true;
            this.btnTransmitir.Click += new System.EventHandler(this.btnTransmitir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(589, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 32);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoAudespLicitacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpenho);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLicitacao);
            this.groupBox1.Controls.Add(this.btnPreencherLotes);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // linkPreVisualizarXml
            // 
            this.linkPreVisualizarXml.AutoSize = true;
            this.linkPreVisualizarXml.Location = new System.Drawing.Point(155, 474);
            this.linkPreVisualizarXml.Name = "linkPreVisualizarXml";
            this.linkPreVisualizarXml.Size = new System.Drawing.Size(104, 15);
            this.linkPreVisualizarXml.TabIndex = 9;
            this.linkPreVisualizarXml.TabStop = true;
            this.linkPreVisualizarXml.Text = "Pré-visualizar XML";
            // 
            // FormAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 511);
            this.Controls.Add(this.linkPreVisualizarXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTransmitir);
            this.Controls.Add(this.lblNotificacoes);
            this.Controls.Add(this.groupLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audesp.NET - Ajuste";
            this.Load += new System.EventHandler(this.FormAjuste_Load);
            this.groupLotes.ResumeLayout(false);
            this.groupLotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesAjuste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesLicitacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpenho;
        private System.Windows.Forms.Button btnPreencherLotes;
        private System.Windows.Forms.TextBox txtLicitacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoAudespLicitacao;
        private System.Windows.Forms.GroupBox groupLotes;
        private System.Windows.Forms.Label lblNotificacoes;
        private System.Windows.Forms.Button btnTransmitir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvLotesAjuste;
        private System.Windows.Forms.DataGridView dgvLotesLicitacao;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkPreVisualizarXml;
    }
}