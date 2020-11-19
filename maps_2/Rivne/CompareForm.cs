﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps
{
    public partial class CompareForm : Form
    {
        private readonly double[] multipliers;

        private string rowNameX;

        private IDictionary<string, List<object>> rowNameAndvalues;
        private IDictionary<string, double> emissionLimits;
        private IEnumerable<string> columnNames;
        private IEnumerable<string> rowsToUseInChart;

        private IDictionary<string, Color[]> colors;

        /// <summary>
        /// Конструктор для создания формы сравнения
        /// </summary>
        /// <param name="rowNameAndvalues">Значения для отображения (строка + её имя).</param>
        /// <param name="columnNames">Имена колонок (объекты, для которых отображается информация). 
        /// Используется отношение каждая коллекция в rowAndvalues последовательно равна каждому значению columnNames.</param>
        /// <param name="legend">Легенда для отображения дополнительной ифнформации.</param>
        public CompareForm(IDictionary<string, List<object>> rowNameAndvalues, IEnumerable<string> columnNames, 
                           string legend) 
            : this(rowNameAndvalues, columnNames, legend, null, null, null)
        { }
        /// <summary>
        /// Конструктор для создания формы сравнения
        /// </summary>
        /// <param name="rowNameAndvalues">Значения для отображения (строка + её имя).</param>
        /// <param name="columnNames">Имена колонок (объекты, для которых отображается информация). 
        /// Используется отношение каждая коллекция в rowAndvalues последовательно равна каждому значению columnNames.</param>
        /// <param name="legend">Легенда для отображения дополнительной ифнформации.</param>
        public CompareForm(IDictionary<string, List<object>> rowNameAndvalues, IEnumerable<string> columnNames, 
                           string legend, IDictionary<string, double> emissionLimits) 
            : this(rowNameAndvalues, columnNames, legend, emissionLimits, null, null)
        { }
        /// <summary>
        /// Конструктор для создания формы сравнения
        /// </summary>
        /// <param name="rowNameAndvalues">Значения для отображения (строка + её имя).</param>
        /// <param name="columnNames">Имена колонок (объекты, для которых отображается информация). 
        /// Используется отношение каждая коллекция в rowAndvalues последовательно равна каждому значению columnNames.</param>
        /// <param name="legend">Легенда для отображения дополнительной ифнформации.</param>
        /// <param name="rowsToUseInChart">Строки, которые будут использоватся в графике</param>
        /// <param name="rowX">Имя строки, значения которой будут использоватся в оси Х графика</param>
        public CompareForm(IDictionary<string, List<object>> rowNameAndvalues, IEnumerable<string> columnNames,
                           string legend, IEnumerable<string> rowsToUseInChart, string rowX)
            : this(rowNameAndvalues, columnNames, legend, null, rowsToUseInChart, rowX)
        { }

        /// <summary>
        /// Конструктор для создания формы сравнения
        /// </summary>
        /// <param name="rowNameAndvalues">Значения для отображения (строка + её имя)</param>
        /// <param name="columnNames">Имена колонок (объекты, для которых отображается информация). 
        /// Используется отношение каждая коллекция в rowAndvalues последовательно равна каждому значению columnNames.</param>
        /// <param name="legend">Легенда для отображения дополнительной ифнформации.</param>
        /// <param name="emissionLimits">Лимит выбросов (для каждой строки одно число).</param>
        /// <param name="rowsToUseInChart">Строки, которые будут использоватся в графике</param>
        /// <param name="rowX">Имя строки, значения которой будут использоватся в оси Х графика</param>
        public CompareForm(IDictionary<string, List<object>> rowNameAndvalues, IEnumerable<string> columnNames,
                           string legend, IDictionary<string, double> emissionLimits, 
                           IEnumerable<string> rowsToUseInChart, string rowX)
        {
            InitializeComponent();

            this.rowNameAndvalues = rowNameAndvalues;
            this.columnNames = columnNames;
            this.emissionLimits = emissionLimits;
            this.rowsToUseInChart = rowsToUseInChart;
            this.rowNameX = rowX;

            if (emissionLimits == null)
            {
                CompareChart.Visible = false;
            }

            LegendLabel.Text = legend;

            colors = null;

            multipliers = new double[10];

            SetMultipliers();
            FillGrid();
            FillChart();
        }

        private void FillChart()
        {
            if (!rowNameAndvalues.ContainsKey(rowNameX))
            {
                return;
            }

            System.Windows.Forms.DataVisualization.Charting.Series series = null;
            int index = 0;

            foreach (var rowName in rowsToUseInChart)
            {
                if (rowNameAndvalues.ContainsKey(rowName))
                {
                    var legend = CompareChart.Legends.Add(rowName);
                    legend.Title = rowName;

                    var distinctColumnNames = columnNames.Distinct().Where(col => !string.IsNullOrEmpty(col));
                    List<object> tempList = new List<object>();

                    foreach (var distinctName in distinctColumnNames)
                    {
                        var xValues = GerRowDataFromColumn(rowNameX, distinctName);
                        var yValues = GerRowDataFromColumn(rowName, distinctName);

                        if (xValues.Count == 0 || yValues.Count == 0 ||
                            xValues[0].ToString() == "-" || yValues[0].ToString() == "-")
                        {
                            continue;
                        }

                        series = new System.Windows.Forms.DataVisualization.Charting.Series(distinctName.Insert(0, index + ". "))
                        {
                            ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                            ChartArea = "MainArea",
                            XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date,
                            YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double,
                            Legend = rowName
                        };

                        for (int i = 0; i < xValues.Count; i++)
                        {
                            series.Points.AddXY(xValues[i], yValues[i]);
                        }

                        CompareChart.Series.Add(series);
                    }
                }
                index++;
            }


        }

        private void FillGrid()
        {
            if (rowNameAndvalues == null)
            {
                throw new ArgumentNullException("rowNameAndvalues");
            }

            if (columnNames == null)
            {
                throw new ArgumentNullException("columnNames");
            }

            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
                dataGridViewColumn.HeaderText = columnName;
                dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                CompareDataGridView.Columns.Add(dataGridViewColumn);
            }

            if (CompareDataGridView.Columns.Count != 0)
            {
                CompareDataGridView.Columns[0].Frozen = true;
                CompareDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            CompareDataGridView.Rows.Add(rowNameAndvalues.Count);
            for (int i = 0; i < rowNameAndvalues.Count; i++)
            {
                object currentElement;
                
                CompareDataGridView.Rows[i].Cells[0].Value = rowNameAndvalues.Keys.ElementAt(i);

                for (int j = 0; j < CompareDataGridView.Columns.Count - 1; j++)
                {
                    currentElement = rowNameAndvalues.Values.ElementAt(i).ElementAtOrDefault(j);

                    if (currentElement != null)
                    {
                        CompareDataGridView.Rows[i].Cells[j + 1].Value = currentElement;
                    }
                    else
                    {
                        CompareDataGridView.Rows[i].Cells[j + 1].Value = "-";
                    }
                }
            }

            if (emissionLimits != null && emissionLimits.Count() != 0)
            {
                colors = new Dictionary<string, Color[]>(emissionLimits.Count());

                for (int i = 0; i < emissionLimits.Count; i++)
                {
                    string key = emissionLimits.Keys.ElementAt(i);

                    RowColorComboBox.Items.Add(key);
                    colors.Add(key, new System.Drawing.Color[multipliers.Length]);

                    int red = 0x00;
                    int blue = 0x99;
                    int green = 0x99;

                    for (int j = 0; j < multipliers.Length; j++)
                    {
                        if (j <= 4)
                        {
                            blue -= 0x1E;
                            green += 0x0A;
                        }
                        else if (j == 5)
                        {
                            red = 0xFF;
                            green = 0xFF;
                        }
                        else if (j <= 8)
                        {
                            green -= 0x55;
                        }
                        else
                        {
                            blue = 0xFF;
                            red = 0x00;
                        }

                        colors[key][j] = System.Drawing.Color.FromArgb(red, green, blue);
                    }
                }

                if (RowColorComboBox.Items.Count != 0)
                {
                    RowColorComboBox.SelectedIndex = 0;
                }

                FillCompareColorGrid(emissionLimits.Keys.First());

                AcceptColor();
            }
        }

        private void SetMultipliers()
        {
            double multiplier = 0.2;

            for (int i = 0; i < multipliers.Length; i++)
            {
                multipliers[i] = multiplier;

                if (multiplier < 1)
                {
                    multiplier += 0.2;
                }
                else if (multiplier < 2.5)
                {
                    multiplier += 0.5;
                }
                else
                {
                    multiplier++;
                }
            }
        }

        private List<object> GerRowDataFromColumn(string rowName, string columnName)
        {
            List<object> result = new List<object>();

            if (CompareDataGridView.Rows.Count == 0 || CompareDataGridView.Rows[0].Cells.Count == 0)
            {
                return result;
            }

            foreach (DataGridViewRow row in CompareDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == rowName)
                {
                    for (int i = 0; i < CompareDataGridView.Columns.Count; i++)
                    {
                        if (CompareDataGridView.Columns[i].HeaderText == columnName)
                        {
                            result.Add(row.Cells[i].Value);
                        }
                    }
                }
            }

            return result;
        }

        private void FillCompareColorGrid(string compareGridRowName)
        {
            if (!emissionLimits.ContainsKey(compareGridRowName) || colors.Count == 0)
            {
                return;
            }

            double currentLimit = emissionLimits[compareGridRowName];

            CompareColorDataGridView.Rows.Clear();
            CompareColorDataGridView.Rows.Add(multipliers.Length);

            for (int i = 0; i < multipliers.Length; i++)
            {
                if (i == multipliers.Length - 1)
                {
                    CompareColorDataGridView.Rows[i].Cells[0].Value = $"{(multipliers[i] * currentLimit)}+";
                }
                else
                {
                    CompareColorDataGridView.Rows[i].Cells[0].Value = multipliers[i] * currentLimit;
                }

                CompareColorDataGridView.Rows[i].Cells[1].Style = new DataGridViewCellStyle()
                {
                    BackColor = colors[compareGridRowName][i],
                    SelectionBackColor = colors[compareGridRowName][i]
                };
            }
        }

        private void AcceptColor()
        {
            string currentRowName = string.Empty;

            foreach (DataGridViewRow row in CompareDataGridView.Rows)
            {
                currentRowName = row.Cells[0].Value.ToString();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    decimal result;

                    if (decimal.TryParse(cell.Value.ToString(), out result))
                    {
                        for (int i = 0; i < multipliers.Length; i++)
                        {
                            if (emissionLimits.ContainsKey(currentRowName) && Convert.ToDecimal(emissionLimits[currentRowName] * multipliers[i]) >= result)
                            {
                                cell.Style = new DataGridViewCellStyle()
                                {
                                    ForeColor = colors[currentRowName][i],
                                    SelectionForeColor = colors[currentRowName][i]
                                };

                                break;
                            }

                            if (i == multipliers.Length - 1)
                            {
                                cell.Style = new DataGridViewCellStyle()
                                {
                                    ForeColor = colors[currentRowName][i],
                                    SelectionForeColor = colors[currentRowName][i]
                                };
                            }
                        }
                    }
                }
            }

            CompareDataGridView.Update();
        }

        private void UpdateCompareColor()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = colorDialog1.Color,
                    SelectionBackColor = colorDialog1.Color
                };

                CompareColorDataGridView.CurrentRow.Cells[1].Style = dataGridViewCellStyle;

                if (emissionLimits != null)
                {
                    colors[RowColorComboBox.Text][CompareColorDataGridView.Rows.IndexOf(CompareColorDataGridView.CurrentRow)] = colorDialog1.Color;
                }

                CompareColorDataGridView.Update();

                AcceptColor();
            }
        }

        private void UpdateColorButton_Click(object sender, EventArgs e)
        {
            if (CompareColorDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Виберіть рядок з кольором.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateCompareColor();
        }

        private void CompareColorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCompareColor();
        }

        private void RowColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emissionLimits != null)
            {
                FillCompareColorGrid(RowColorComboBox.Text);
            }
        }
    }
}
