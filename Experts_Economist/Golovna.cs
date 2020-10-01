﻿using Data;
using Maps;
using oprForm;
using System;
using System.Windows.Forms;
using UserLoginForm;



namespace Experts_Economist
{
    public partial class Golovna : Form
    {
        public int id_of_exp; //переменная для хранения id експерта
        public int id_of_user;
        private DBManager db = new DBManager();

        public Golovna(int id) //класс формы, input - id експерта
        {
            InitializeComponent();
            id_of_user = id;
            id_of_exp = (int)db.GetValue("user","id_of_expert",$"id_of_user = '{id_of_user}'");
        }

        private Rozrah RozrahMDIChild;
        private Result ResultMDIChild;
        private Redakt RedaktMDIChild;
        private IssuesForm IssuesMDIChild;
        private Dovidka dovidkaElements;
        private Dovidka dovidkaEnvironment;
        private Dovidka dovidkaGDK;
        private Dovidka dovidkaEmissions;
        private ImportDB importDB_csv;
        private ImportSQL importSQL;
        private ExportDB exportDB;
        private ConnectDB connectDB;
        private Map MapMDIChild;
        private LookEventsForm look;
        private NormOfCalc norm;

        private void Golovna_Load(object sender, EventArgs e)
        {
            label1.Text += " " + this.id_of_exp;
            label2.Text += " " + db.GetValue("expert", "expert_name", "id_of_expert = " + id_of_exp).ToString();
            if (id_of_exp == 0)
            {
                RedaktTSM.Visible = true;
                user_redakt_button.Visible = true;
                базаДанихToolStripMenuItem.Visible = true;
            }
            
            //if (MapMDIChild == null)
            //{
            //    MapMDIChild = new Map();
            //    MapMDIChild.id_of_exp = id_of_exp;
            //    MapMDIChild.MdiParent = this;
            //    MapMDIChild.Show();
            //    MapMDIChild.FormClosed += MapMDIChild_FormClosed;
            //}
            //MapMDIChild.BringToFront();
        }

        private void MapMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            MapMDIChild.Dispose();
            MapMDIChild = null;
        }

        //событие нажатия на кнопку Розрахунок - запуск формы Rozrah в главном окне(Mdi)
        private void RozrahTSM_Click(object sender, EventArgs e)
        {
            if (RozrahMDIChild == null)
            {
                RozrahMDIChild = new Rozrah();
                RozrahMDIChild.id_of_exp = id_of_exp;
                RozrahMDIChild.MdiParent = this;
                RozrahMDIChild.Show();
                RozrahMDIChild.FormClosed += RozrahMDIChild_FormClosed;
            }
            RozrahMDIChild.BringToFront();
        }

        private void RozrahMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            RozrahMDIChild.Dispose();
            RozrahMDIChild = null;
        }

        //событие нажатия на кнопку Перегляд результатів - запуск формы Result в главном окне(Mdi)
        private void ResultTSM_Click(object sender, EventArgs e)
        {
            if (ResultMDIChild == null)
            {
                ResultMDIChild = new Result();
                ResultMDIChild.id_of_exp = id_of_exp;
                ResultMDIChild.MdiParent = this;
                ResultMDIChild.Show();
                ResultMDIChild.FormClosed += ResultMDIChild_FormClosed;
            }
            ResultMDIChild.BringToFront();
        }

        private void ResultMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResultMDIChild.Dispose();
            ResultMDIChild = null;
        }

        //событие нажатия на кнопку Редактор формул - запуск формы Redakt в главном окне(Mdi)
        private void RedaktTSM_Click(object sender, EventArgs e)
        {
            if (RedaktMDIChild == null)
            {
                RedaktMDIChild = new Redakt();
                RedaktMDIChild.MdiParent = this;
                RedaktMDIChild.Show();
                RedaktMDIChild.FormClosed += RedaktMDIChild_FormClosed;
            }
            RedaktMDIChild.BringToFront();
        }

        private void RedaktMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            RedaktMDIChild.Dispose();
            RedaktMDIChild = null;
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlannedEventsForm child = new PlannedEventsForm(id_of_exp);
            child.MdiParent = this;
            child.Show();
        }

        private void переглядЗаходiвToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (look == null)
            {
                look = new LookEventsForm(id_of_exp);
                look.MdiParent = this;
                look.Show();
                look.FormClosed += (send, ev) => { look.Dispose(); look = null; };
            }
            look.BringToFront();
        }

        private void переглядПроблемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new IssuesForm();
            child.MdiParent = this;
            child.Show();
        }

        private void шаблониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new AddTemplateForm();
            child.MdiParent = this;
            child.Show();
        }

        private void додатиРесурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new AddMaterialForm();
            child.MdiParent = this;
            child.Show();
        }

        private void ресурсиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new MaterialsForm();
            child.MdiParent = this;
            child.Show();
        }

        private void змiнитиЗахiдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new AlterEventForm();
            child.MdiParent = this;
            child.Show();
        }

        private void переглядЗаходiвToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LookEventsForm child = new LookEventsForm(id_of_exp);
            child.MdiParent = this;
            child.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var child = new AlterEventForm();
            child.MdiParent = this;
            child.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlannedEventsForm child = new PlannedEventsForm(id_of_exp);
            child.MdiParent = this;
            child.Show();
        }

        private void змiнитиШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new AlterTemplateForm();
            child.MdiParent = this;
            child.Show();
        }

        

        private void user_redakt_button_Click(object sender, EventArgs e)
        {
            try
            {
                new User_editor().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MapMDIChild == null)
            {
                MapMDIChild = new Map();
                MapMDIChild.id_of_exp = id_of_exp;
                MapMDIChild.id_of_user = id_of_user;
                MapMDIChild.MdiParent = this;
                MapMDIChild.Show();
                MapMDIChild.FormClosed += (send, ev) => { MapMDIChild.Dispose(); MapMDIChild = null; };
            }
            MapMDIChild.BringToFront();
        }


        private void довідникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void гДКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dovidkaElements == null)
            {
                dovidkaElements = new Dovidka("elements", id_of_exp);
                dovidkaElements.Text = "ДОВІДКА - РЕЧОВИНИ";
                dovidkaElements.MdiParent = this;
                dovidkaElements.Show();
                dovidkaElements.FormClosed += (_sender, _event) =>
                {
                    dovidkaElements.Dispose();
                    dovidkaElements = null;
                };
            }
            dovidkaElements.BringToFront();
        }

        private void речовиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dovidkaGDK == null)
            {
                dovidkaGDK = new Dovidka("gdk", id_of_exp);
                dovidkaGDK.Text = "ДОВІДКА - ГДК";
                dovidkaGDK.MdiParent = this;
                dovidkaGDK.Show();
                dovidkaGDK.FormClosed += (_sender, _event) =>
                {
                    dovidkaGDK.Dispose();
                    dovidkaGDK = null;
                };
            }
            dovidkaGDK.BringToFront();
        }

        private void середовищеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dovidkaEnvironment == null)
            {
                dovidkaEnvironment = new Dovidka("environment", id_of_exp);
                dovidkaEnvironment.Text = "ДОВІДКА - СЕРЕДОВИЩА";
                dovidkaEnvironment.MdiParent = this;
                dovidkaEnvironment.Show();
                dovidkaEnvironment.FormClosed += (_sender, _event) =>
                {
                    dovidkaEnvironment.Dispose();
                    dovidkaEnvironment = null;
                };
            }
            dovidkaEnvironment.BringToFront();
        }

        private void забруднюючаРечовинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dovidkaEmissions == null)
            {
                dovidkaEmissions = new Dovidka("emissions", id_of_exp);
                dovidkaEmissions.Text = "ДОВІДКА - ЗАБРУДНЕННЯ";
                dovidkaEmissions.MdiParent = this;
                dovidkaEmissions.Show();
                dovidkaEmissions.FormClosed += (_sender, _event) =>
                {
                    dovidkaEmissions.Dispose();
                    dovidkaEmissions = null;
                };
            }
            dovidkaEmissions.BringToFront();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importDB_csv == null)
            {
                importDB_csv = new ImportDB();
                importDB_csv.MdiParent = this;
                importDB_csv.Show();
                importDB_csv.FormClosed += (_sender, _event) =>
                {
                    importDB_csv.Dispose();
                    importDB_csv = null;
                };
            }
            importDB_csv.BringToFront();
        }

        private void exportSQLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (exportDB == null)
            {
                exportDB = new ExportDB();
                exportDB.MdiParent = this;
                exportDB.Show();
                exportDB.FormClosed += (_sender, _event) =>
                {
                    exportDB.Dispose();
                    exportDB = null;
                };
            }
            exportDB.BringToFront();
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importSQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (importSQL == null)
            {
                importSQL = new ImportSQL();
                importSQL.MdiParent = this;
                importSQL.Show();
                importSQL.FormClosed += (_sender, _event) =>
                {
                    importSQL.Dispose();
                    importSQL = null;
                };
            }
            importSQL.BringToFront();
        }

        private void підключитисяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectDB == null)
            {
                connectDB = new ConnectDB();
                connectDB.MdiParent = this;
                connectDB.Show();
                connectDB.FormClosed += (_sender, _event) =>
                {
                    connectDB.Dispose();
                    connectDB = null;
                };
            }
            connectDB.BringToFront();
        }

        private void ПереглядПроблемToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void видЕкномічноїДіяльностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkersForm mk = new MarkersForm(connectDB, db);
            mk.Show();
        }

        private void ставкиПодатківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dovidkaEmissions == null)
            {
                dovidkaEmissions = new Dovidka("tax_values", id_of_exp);
                dovidkaEmissions.Text = "ДОВІДКА - ПОДАТКИ";
                dovidkaEmissions.MdiParent = this;
                dovidkaEmissions.Show();
                dovidkaEmissions.FormClosed += (_sender, _event) =>
                {
                    dovidkaEmissions.Dispose();
                    dovidkaEmissions = null;
                };
            }
            dovidkaEmissions.BringToFront();
        }


        private void результатиНормуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (norm == null)
            {
                norm = new NormOfCalc(db);
                norm.Show();
                norm.FormClosed += (_sender, _event) =>
                {
                    norm.Dispose();
                    norm = null;
                };
            }
            norm.BringToFront();
        }
    }
    
}