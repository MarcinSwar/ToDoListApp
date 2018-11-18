﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Models;

namespace ToDoListApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var list = new List<Zadanie>();
            for (int i = 0; i < 10; i++) {
                var newZadanie = new Zadanie();
                newZadanie.idZadanie = i;
                newZadanie.Opis = "Ala ma kota" + i;
                newZadanie.Deadline = DateTime.Now;

                list.Add(newZadanie);
            }
            ZadaniaDataGridView1.DataSource = list;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
