﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.btnTransmitir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupLotes.Controls.Add(this.button1);
            this.groupLotes.Controls.Add(this.dataGridView2);
            this.groupLotes.Controls.Add(this.dataGridView1);
            this.groupLotes.Location = new System.Drawing.Point(13, 126);
            this.groupLotes.Name = "groupLotes";
            this.groupLotes.Size = new System.Drawing.Size(701, 333);
            this.groupLotes.TabIndex = 5;
            this.groupLotes.TabStop = false;
            this.groupLotes.Text = "Lotes";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(425, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(473, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(187, 258);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(379, 258);
            this.dataGridView1.TabIndex = 0;
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
            // FormAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 511);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}