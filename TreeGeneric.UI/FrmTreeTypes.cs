﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using TreeGeneric.BussinessLogic;

namespace TreeGeneric.UI
{
    public partial class FrmTreeTypes : Form
    {
        private readonly ITreeTypeService treeTypeService;
        private readonly ILifetimeScope scope;
        public FrmTreeTypes(ILifetimeScope scope)
        {
            InitializeComponent();
            this.scope = scope;
            treeTypeService = scope.Resolve<ITreeTypeService>();
        }

        private void FrmTreeTypes_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = treeTypeService.GetAll().Select(s => new {s.Id, s.Name, RegionName = s.Regions.FirstOrDefault()?.Name}).ToList();
        }

        private void btnDeleteTree_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                treeTypeService.Delete(id);
                MessageBox.Show("Kayıt Başarıyla Silindi");
                MessageBox.Show("Liste Güncellendi");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!");
            }
        }

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            FrmTreeType frmTreeType=new FrmTreeType(treeTypeService,this,null,scope);
            frmTreeType.ShowDialog();
        }

        private void btnEditTree_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FrmTreeType frmTreeType = new FrmTreeType(treeTypeService, this, id,scope);
                frmTreeType.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçiniz!");
            }
        }
    }
}
