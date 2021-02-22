namespace Print_Document_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.box_aluno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_preco = new System.Windows.Forms.TextBox();
            this.box_qtd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_curso = new System.Windows.Forms.ComboBox();
            this.box_add = new System.Windows.Forms.Button();
            this.box_print_preview = new System.Windows.Forms.Button();
            this.box_print = new System.Windows.Forms.Button();
            this.lista_itens_adicionados = new System.Windows.Forms.DataGridView();
            this.box_numero_itens_adicionados = new System.Windows.Forms.Label();
            this.DVPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.DVPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RnomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rcurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rqtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lista_itens_adicionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // box_aluno
            // 
            this.box_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_aluno.FormattingEnabled = true;
            this.box_aluno.Items.AddRange(new object[] {
            "Maria Kul",
            "John Smith",
            "Leius Perty",
            "Port Ukylitsyu",
            "Onme Ruwtsy",
            "Wtysr Merkuy"});
            this.box_aluno.Location = new System.Drawing.Point(233, 155);
            this.box_aluno.Name = "box_aluno";
            this.box_aluno.Size = new System.Drawing.Size(232, 28);
            this.box_aluno.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(809, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "KZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centaur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(721, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Curso:";
            // 
            // box_preco
            // 
            this.box_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_preco.Location = new System.Drawing.Point(233, 280);
            this.box_preco.Name = "box_preco";
            this.box_preco.Size = new System.Drawing.Size(232, 27);
            this.box_preco.TabIndex = 23;
            this.box_preco.WordWrap = false;
            // 
            // box_qtd
            // 
            this.box_qtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_qtd.FormattingEnabled = true;
            this.box_qtd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.box_qtd.Location = new System.Drawing.Point(233, 238);
            this.box_qtd.Name = "box_qtd";
            this.box_qtd.Size = new System.Drawing.Size(232, 28);
            this.box_qtd.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome Aluno:";
            // 
            // box_curso
            // 
            this.box_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_curso.FormattingEnabled = true;
            this.box_curso.Items.AddRange(new object[] {
            "Angular",
            "JavaScript",
            "CSharp",
            "VUE",
            "React Native",
            "PHP",
            "Laravel Whit PHP 8",
            "MVC",
            "Python",
            "React",
            "Flutter",
            "Dart",
            "Learn Machine"});
            this.box_curso.Location = new System.Drawing.Point(233, 196);
            this.box_curso.Name = "box_curso";
            this.box_curso.Size = new System.Drawing.Size(232, 28);
            this.box_curso.TabIndex = 19;
            // 
            // box_add
            // 
            this.box_add.Location = new System.Drawing.Point(508, 258);
            this.box_add.Name = "box_add";
            this.box_add.Size = new System.Drawing.Size(119, 45);
            this.box_add.TabIndex = 17;
            this.box_add.Text = "Add New Order";
            this.box_add.UseVisualStyleBackColor = true;
            this.box_add.Click += new System.EventHandler(this.Box_add_Click);
            // 
            // box_print_preview
            // 
            this.box_print_preview.Location = new System.Drawing.Point(737, 260);
            this.box_print_preview.Name = "box_print_preview";
            this.box_print_preview.Size = new System.Drawing.Size(105, 45);
            this.box_print_preview.TabIndex = 16;
            this.box_print_preview.Text = "Print Preview";
            this.box_print_preview.UseVisualStyleBackColor = true;
            this.box_print_preview.Click += new System.EventHandler(this.Box_print_preview_Click);
            // 
            // box_print
            // 
            this.box_print.Location = new System.Drawing.Point(633, 258);
            this.box_print.Name = "box_print";
            this.box_print.Size = new System.Drawing.Size(92, 45);
            this.box_print.TabIndex = 15;
            this.box_print.Text = "Print";
            this.box_print.UseVisualStyleBackColor = true;
            this.box_print.Click += new System.EventHandler(this.Box_print_Click);
            // 
            // lista_itens_adicionados
            // 
            this.lista_itens_adicionados.AllowUserToAddRows = false;
            this.lista_itens_adicionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_itens_adicionados.ColumnHeadersHeight = 30;
            this.lista_itens_adicionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rcodigo,
            this.RnomeAluno,
            this.Rcurso,
            this.Rqtd,
            this.Rpreco,
            this.Rtotal});
            this.lista_itens_adicionados.Location = new System.Drawing.Point(107, 311);
            this.lista_itens_adicionados.MultiSelect = false;
            this.lista_itens_adicionados.Name = "lista_itens_adicionados";
            this.lista_itens_adicionados.RowHeadersVisible = false;
            this.lista_itens_adicionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_itens_adicionados.Size = new System.Drawing.Size(737, 279);
            this.lista_itens_adicionados.TabIndex = 30;
            // 
            // box_numero_itens_adicionados
            // 
            this.box_numero_itens_adicionados.AutoSize = true;
            this.box_numero_itens_adicionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_numero_itens_adicionados.ForeColor = System.Drawing.Color.Indigo;
            this.box_numero_itens_adicionados.Location = new System.Drawing.Point(114, 603);
            this.box_numero_itens_adicionados.Name = "box_numero_itens_adicionados";
            this.box_numero_itens_adicionados.Size = new System.Drawing.Size(51, 22);
            this.box_numero_itens_adicionados.TabIndex = 28;
            this.box_numero_itens_adicionados.Text = "Total";
            // 
            // DVPrintDocument
            // 
            this.DVPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVPrintDocument_PrintPage);
            // 
            // DVPrintPreviewDialog
            // 
            this.DVPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVPrintPreviewDialog.Enabled = true;
            this.DVPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVPrintPreviewDialog.Icon")));
            this.DVPrintPreviewDialog.Name = "DVPrintPreviewDialog";
            this.DVPrintPreviewDialog.Visible = false;
            this.DVPrintPreviewDialog.Load += new System.EventHandler(this.DVPrintPreviewDialog_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Print_Document_V2.Properties.Resources.hydradev;
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Rcodigo
            // 
            this.Rcodigo.HeaderText = "CODIGO";
            this.Rcodigo.Name = "Rcodigo";
            this.Rcodigo.ReadOnly = true;
            // 
            // RnomeAluno
            // 
            this.RnomeAluno.HeaderText = "NOME ALUNO";
            this.RnomeAluno.Name = "RnomeAluno";
            this.RnomeAluno.ReadOnly = true;
            // 
            // Rcurso
            // 
            this.Rcurso.HeaderText = "CURSO";
            this.Rcurso.Name = "Rcurso";
            this.Rcurso.ReadOnly = true;
            // 
            // Rqtd
            // 
            this.Rqtd.HeaderText = "QUANTIDADE";
            this.Rqtd.Name = "Rqtd";
            this.Rqtd.ReadOnly = true;
            // 
            // Rpreco
            // 
            this.Rpreco.HeaderText = "PREÇO";
            this.Rpreco.Name = "Rpreco";
            this.Rpreco.ReadOnly = true;
            // 
            // Rtotal
            // 
            this.Rtotal.HeaderText = "TOTAL";
            this.Rtotal.Name = "Rtotal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lista_itens_adicionados);
            this.Controls.Add(this.box_aluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_numero_itens_adicionados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_preco);
            this.Controls.Add(this.box_qtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_curso);
            this.Controls.Add(this.box_add);
            this.Controls.Add(this.box_print_preview);
            this.Controls.Add(this.box_print);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_itens_adicionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_aluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_preco;
        private System.Windows.Forms.ComboBox box_qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_curso;
        private System.Windows.Forms.Button box_add;
        private System.Windows.Forms.Button box_print_preview;
        private System.Windows.Forms.Button box_print;
        private System.Windows.Forms.Label box_numero_itens_adicionados;
        private System.Windows.Forms.DataGridView lista_itens_adicionados;
        private System.Drawing.Printing.PrintDocument DVPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog DVPrintPreviewDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RnomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rcurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rqtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rtotal;
        private System.Windows.Forms.Button button1;
    }
}

