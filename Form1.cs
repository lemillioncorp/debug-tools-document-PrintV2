using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Print_Document_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AdicionarProdutoCarrinho_E_CalculosVenda()
        {
            double total = 0;
            double subtotal = 0;

            //CALCULAR O NUMERO DE ITENS(PRODUTOS ADICIONADO NA LISTA
            box_numero_itens_adicionados.Text = "" + (lista_itens_adicionados.RowCount + 1) + "";

            //ADICIONAR OS CAMPOS NA LISTA
            lista_itens_adicionados.Rows.Add(lista_itens_adicionados.RowCount, box_aluno.Text.Trim(),  box_curso.Text.Trim(), box_qtd.Text, box_preco.Text);

            foreach (DataGridViewRow itemAdicionado in lista_itens_adicionados.Rows)
            {
                //Declaração de Variaveis e Calculo da Venda
                double QTD = Convert.ToDouble(itemAdicionado.Cells[3].Value);
                double PRECO = Convert.ToDouble(itemAdicionado.Cells[4].Value);

                subtotal = QTD * PRECO;
                itemAdicionado.Cells[5].Value = subtotal;


                total = total + subtotal;
                //txt_subtotal.Text = Convert.ToString(subtotal)    
             
            }

      

            label5.Text = total.ToString();
            
        }
        private void Clean()
        {
            box_preco.Clear();
            box_aluno.ResetText();
            box_curso.SelectedIndex = 0;
            box_qtd.SelectedIndex = 0;
           
        }

        private void Box_add_Click(object sender, EventArgs e)
        {
            if (box_preco.Text == "" && box_qtd.Text == "" || box_qtd.Text == string.Empty || box_preco.Text == string.Empty)
            {
                MessageBox.Show("DIGITE UM PREÇO E UMA QUANTIDADE", "ERRO -  PREÇO E OU QUANTIDADE VAZIA");
            }
            else
            {
                AdicionarProdutoCarrinho_E_CalculosVenda();
                Clean();
            }
          
            
        }

        private void Box_print_preview_Click(object sender, EventArgs e)
        {
           

            DVPrintDocument.DocumentName = "RELATORIO DA VENDA";
            
            DVPrintPreviewDialog.Document = DVPrintDocument;
            DVPrintPreviewDialog.ShowDialog();
        }

        private void Box_print_Click(object sender, EventArgs e)
        {
            DVPrintDocument.DocumentName = "RELATORIO DA VENDA";
         
            DVPrintDocument.Print();
        }

        private void DVPrintPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int y = 20;
            Bitmap bmp = Properties.Resources.hydradev;
            Image newImg = bmp;
            e.Graphics.DrawImage(newImg, 270, -50, newImg.Width, newImg.Height);
            e.Graphics.DrawString("\n ============VENDA DE PRODUTOS============= \n"
                , new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(0, 90));

            foreach (DataGridViewRow row in lista_itens_adicionados.Rows)
            {
                e.Graphics.DrawString(
                    "" +
                   "\n Código: " + row.Cells[0].Value.ToString() +
                   "\n Nome do Aluno: " + row.Cells[1].Value.ToString() + 
                   "\n Curso: " + row.Cells[2].Value.ToString() +
                   "\n Quantidade: " + row.Cells[3].Value.ToString() +
                   "\n Preço: " + row.Cells[4].Value.ToString() +
                   "\n =============================================== \n"
                   , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(10, y += 150, 600, 140));
                //RectangleF(220, width += 200, width, heigth)

                //txt_subtotal.Text = Convert.ToString(subtotal)    
                e.Graphics.DrawString("Total Final: " + label5.Text.ToString() + " KZ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 850));
            }
            
            e.Graphics.DrawString("\n ================= Volte Sempre. =============================== \n", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(290, 870));
            e.Graphics.DrawString("\n ===============" + DateTime.Now.ToLongDateString() + "===================== \n", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(290, 890));


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
