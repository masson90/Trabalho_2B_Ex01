using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_04
{
    /*
    4) Utilizando o conceito de pilha, desenvolva uma aplicação que faça o
       empilhamento e o desempilhamento de dados.
    5) Utilizando o conceito de fila, desenvolva uma aplicação que coloque os
       elementos em fila e os retire da fila conforme necessário.
     */

    public partial class Form1 : Form
    {
        Queue<String> Fila = new Queue<String>();
        Stack<String> Pilha = new Stack<String>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite um valor!");
                textBox1.Focus();
            }
            else
            {
                Fila.Enqueue(textBox1.Text);
                Pilha.Push(textBox1.Text);

                textBox1.Clear();
                textBox1.Focus();

                listFila.Items.Clear();
                listPilha.Items.Clear();

                foreach (var item in Fila)
                {
                    listFila.Items.Add((Environment.NewLine + item.ToString()));
                    
                }
                foreach (var item in Pilha)
                {
                    listPilha.Items.Add((Environment.NewLine + item.ToString()));
                }

            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(Fila.Count > 0 && Pilha.Count > 0)
            {
                Fila.Dequeue();
                listFila.Items.Clear();
                foreach (var item in Fila)
                {
                    listFila.Items.Add((Environment.NewLine + item.ToString()));
                    
                }

                Pilha.Pop();
                listPilha.Items.Clear();
                foreach (var item in Pilha)
                {
                    listPilha.Items.Add((Environment.NewLine + item.ToString()));
                }
                
            }
            

            else
            {
                MessageBox.Show("Lista e Pilha Vazias");
            }
        
        }
    }
}
