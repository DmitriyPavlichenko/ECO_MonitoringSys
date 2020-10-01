﻿using Data;
using Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace oprForm
{
    public partial class MaterialsForm : Form
    {
        private DBManager db = new DBManager();
        private int nameColIdx = 0;
        private int priceColIdx = 1;
        private int unitsColIdx = 2;
        private int descColIdx = 3;
        private Resource saved;

        public MaterialsForm()
        {
            InitializeComponent();

            getMaterials();
        }

        private void getMaterials()
        {
            resDGV.Rows.Clear();
            db.Connect();
            var obj = db.GetRows("resource", "*", "");
            var res = new List<Resource>();
            foreach (var row in obj)
            {
                res.Add(ResourceMapper.Map(row));
            }

            foreach (var r in res)
            {
                resDGV.Rows.Add(r, r.price, r.unit, r.description);
            }

            db.Disconnect();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var selected = resDGV.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                if (row.Cells[0].Value is Resource)
                {
                    var res = row.Cells[0].Value as Resource;
                    try
                    {
                        db.Connect();
                        string cols = "resource_id";
                        string values = res.id.ToString();

                        db.DeleteFromDB("resource", cols, values);
                        resDGV.Rows.Remove(row);
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1451)
                        {
                            MessageBox.Show("Ресурс використовуэться.");
                        }
                    }
                    finally
                    {
                        db.Disconnect();
                    }
                }
            }
        }

        private void commitValue(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == nameColIdx)
            {
                var val = resDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (val.Length != 0 && !val.Equals(" "))
                {
                    saved.name = val;
                }
                else
                {
                    MessageBox.Show("Назвe не повиннa бути пустa.");
                }
                resDGV.Rows[e.RowIndex].Cells[0].Value = saved;
                return;
            }
            if (resDGV.Rows[e.RowIndex].Cells[0].Value is Resource)
            {
                var res = resDGV.Rows[e.RowIndex].Cells[0].Value as Resource;
                if (e.ColumnIndex == descColIdx)
                {
                    var val = resDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (val.Length != 0 && !val.Equals(" "))
                        res.description = val;
                    else
                    {
                        MessageBox.Show("Опис не повинен бути пустим.");
                    }
                }
                else if (e.ColumnIndex == priceColIdx)
                {
                    var val = resDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    try
                    {
                        res.price = Double.Parse(val);
                    }
                    catch
                    {
                        MessageBox.Show("Введіть число.");
                    }
                }
                else if (e.ColumnIndex == unitsColIdx)
                {
                    var val = resDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (val.Length != 0 && !val.Equals(" "))
                    {
                        res.unit = val;
                    }
                    else
                    {
                        MessageBox.Show("Опис не повинен бути пустим.");
                    }
                }
            }
        }

        private void cancelEdit()
        {
            //TODO
            return;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in resDGV.Rows)
            {
                if (row.Cells[0].Value is Resource)
                {
                    var res = row.Cells[0].Value as Resource;
                    db.Connect();

                    string[] cols = { "resource_id", "name", "description", "units", "price" };
                    string[] values = { res.id.ToString(), DBUtil.AddQuotes(res.name), DBUtil.AddQuotes(res.description), DBUtil.AddQuotes(res.unit), res.price.ToString() };

                    db.UpdateRecord("resource", cols, values);

                    db.Disconnect();
                }
            }
        }

        private void cacheResFromFirstCol(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == nameColIdx)
            {
                saved = resDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Resource;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.Connect();
                string[] fields = { "name", "description", "price", "units" };
                String val1 = DBUtil.AddQuotes(nameTB.Text);
                String val2 = DBUtil.AddQuotes(descriptionTB.Text);
                 String val3 = Double.Parse(priceTB.Text).ToString();
                String val4 = DBUtil.AddQuotes(measureTB.Text);
                string[] values = { val1, val2, val3,  val4};
                db.InsertToBD("resource", fields, values);
                db.Disconnect();
                getMaterials();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введено ціну.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = resDGV.CurrentCell.RowIndex;
            var cells = resDGV.Rows[index].Cells;
            var textBoxes = panel1.Controls.OfType<TextBox>().ToArray();

            for (int i = 0; i < cells.Count; i++)
            {
                textBoxes[i].Text = cells[i].Value.ToString();
            }
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {

        }
    }
}