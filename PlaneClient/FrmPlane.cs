﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneClient
{
    public partial class FrmPlane : Telerik.WinControls.UI.RadForm
    {
        public FrmPlane()
        {
            InitializeComponent();
        }

        private void FrmPlane_Load(object sender, EventArgs e)
        {
            List<Plane> planes = new PlaneBUS().GetAll();
            gvPlane.DataSource = planes;
        }

        private void gvPlane_SelectionChanged(object sender, EventArgs e)
        {
            if (gvPlane.SelectedRows.Count > 0)
            {
                int Id = int.Parse(gvPlane.SelectedRows[0].Cells["Id"].Value.ToString());
                Plane plane = new PlaneBUS().GetDetails(Id);
                if (plane != null)
                {
                    txtId.Text = plane.Id.ToString();
                    txtBrand.Text = plane.Brand;
                    txtName.Text = plane.Name;
                    txtPricee.Text = plane.Price.ToString();
                    txtSize.Text = plane.Size.ToString();
                }
            }
        }

        private void gvPlane_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Plane newPlane = new Plane()
            {
                Id = 0,
                Brand = txtBrand.Text.Trim(),
                Name = txtName.Text.Trim(),
                Price = int.Parse(txtPricee.Text.Trim()),
                Size = int.Parse(txtSize.Text.Trim())
            };
            bool result = new PlaneBUS().AddNew(newPlane);
            if (result)
            {
                List<Plane> planes = new PlaneBUS().GetAll();
                gvPlane.DataSource = planes;
            }
            else MessageBox.Show("Please Again");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Plane newPlane = new Plane()
            {
                Id = int.Parse(txtId.Text.Trim()),
                Brand = txtBrand.Text.Trim(),
                Name = txtName.Text.Trim(),
                Price = int.Parse(txtPricee.Text.Trim()),
                Size = int.Parse(txtSize.Text.Trim())
            };
            bool result = new PlaneBUS().Update(newPlane);
            if (result)
            {
                List<Plane> planes = new PlaneBUS().GetAll();
                gvPlane.DataSource = planes;
            }
            else MessageBox.Show("Please Again");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chaa8c1 muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                bool result = new PlaneBUS().Delete(id);
                if (result)
                {
                    List<Plane> planes = new PlaneBUS().GetAll();
                    gvPlane.DataSource = planes;
                }
                else { MessageBox.Show("Sorry please again"); }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        

            String keyword = txt_search.Text.Trim();
            List<Plane> planes = new List<Plane>();
            if(keyword.Length > 0)
            {
                planes = new PlaneBUS().Search(keyword);
                gvPlane.DataSource = planes;
            }
            else
            {
                planes = new PlaneBUS().GetAll();
                gvPlane.DataSource = planes;
            }
        //  List<Plane> planes = new PlaneBUS().Search(keyword);
    
        }
    }
}
