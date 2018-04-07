using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace AnovaTest
{
    public partial class anovaTest : Form
    {
        private bool numOfAlternativesTest = false;
        private bool numOfMeasurementsTest = false;
        private bool resultsGenerated = false;
        private int numberOfAlternatives = 0;
        private int numberOfMeasurements = 0;

        public anovaTest()
        {
            InitializeComponent();
            generateTable.Enabled = false;
            entriesDataGridView.AllowUserToAddRows = false;
            contrastDataGridView.AllowUserToAddRows = false;
            contrastTrustIntervalDataGridView.AllowUserToAddRows = false;
            generateResults.Enabled = false;
            probability95RadioButton.Select();
        }

        private void generateTable_Click(object sender, EventArgs e)
        {
            entriesDataGridView.Columns.Clear();
            int alternatives = Int32.Parse(numOfAlternatives.Text);
            int measurements = Int32.Parse(numOfMeasurements.Text);
            List<Alternative> alternativesList = new List<Alternative>();
            for(int i = 0; i < alternatives; i++)
            {
                alternativesList.Add(new Alternative("" + (i + 1), measurements));
            }
            foreach(Alternative alternativeIter in alternativesList)
            {
                entriesDataGridView.Columns.Add(alternativeIter.AlternativeName, alternativeIter.AlternativeName);
            }
            if(alternatives < 50)
            {
                entriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                entriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            foreach (DataGridViewColumn column in entriesDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < measurements; i++)
            {
                entriesDataGridView.Rows.Add();
                entriesDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString() + ".";
            }
            entriesDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            entriesDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            entriesDataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            entriesDataGridView.TopLeftHeaderCell.Value = "Vrijednosti\nmjerenja";
            entriesDataGridView.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            generateResults.Enabled = true;
            numberOfAlternatives = alternatives;
            numberOfMeasurements = measurements;
            resultsGenerated = false;
        }

        private void numOfAlternatives_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number = Int32.Parse(numOfAlternatives.Text);
                if(number > 1)
                {
                    numOfAlternatives.ForeColor = Color.Green;
                    numOfAlternativesTest = true;
                }
                else
                {
                    numOfAlternatives.ForeColor = Color.Red;
                    numOfAlternativesTest = false;
                }
            }
            catch (Exception)
            {
                numOfAlternatives.ForeColor = Color.Red;
                numOfAlternativesTest = false;
            }
            if(numOfAlternativesTest && numOfMeasurementsTest)
            {
                generateTable.Enabled = true;
            }
            else
            {
                generateTable.Enabled = false;
            }
        }

        private void numOfMeasurements_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number = Int32.Parse(numOfMeasurements.Text);
                if (number > 1)
                {
                    numOfMeasurements.ForeColor = Color.Green;
                    numOfMeasurementsTest = true;
                }
                else
                {
                    numOfMeasurements.ForeColor = Color.Red;
                    numOfMeasurementsTest = false;
                }
            }
            catch (Exception)
            {
                numOfMeasurements.ForeColor = Color.Red;
                numOfMeasurementsTest = false;
            }
            if (numOfAlternativesTest && numOfMeasurementsTest)
            {
                generateTable.Enabled = true;
            }
            else
            {
                generateTable.Enabled = false;
            }
        }

        private void generateResults_Click(object sender, EventArgs e)
        {
            if(resultsGenerated)
            {
                entriesDataGridView.Rows.RemoveAt(entriesDataGridView.Rows.Count - 1);
                entriesDataGridView.Rows.RemoveAt(entriesDataGridView.Rows.Count - 1);
                contrastDataGridView.Columns.Clear();
                contrastTrustIntervalDataGridView.Columns.Clear();
            }
            float[] alternativesSums = new float[numberOfAlternatives];
            float[] alternativesMeans = new float[numberOfAlternatives];
            int i = 0;
            foreach(DataGridViewTextBoxColumn column in entriesDataGridView.Columns)
            {
                for(int j = 0; j < numberOfMeasurements; j++)
                {
                    try
                    {
                        if(entriesDataGridView.Rows[j].Cells[i].Value == null)
                        {
                            throw new FormatException();
                        }
                        float value = float.Parse(entriesDataGridView.Rows[j].Cells[i].Value.ToString());
                        alternativesSums[i] += value;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Unesena mjerenja nisu ispravnog formata.", "Greška"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                i++;
            }
            entriesDataGridView.Rows.Add();
            entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].HeaderCell.Value = "Srednja vrijednost";
            entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].ReadOnly = true;
            entriesDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            float totalAverageSum = 0.0f;
            float totalAverage = 0.0f;
            for (i = 0; i < numberOfAlternatives; i++)
            {
                alternativesMeans[i] = alternativesSums[i] / numberOfMeasurements;
                totalAverageSum += alternativesMeans[i];
                entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].Cells[i].Value
                    = alternativesMeans[i].ToString();
            }
            totalAverage = totalAverageSum / numberOfAlternatives;
            entriesDataGridView.Rows.Add();
            entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].HeaderCell.Value = "Efekat";
            entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].ReadOnly = true;
            entriesDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            float ssa = 0.0f;
            for(int k = 0; k < numberOfAlternatives; k++)
            {
                entriesDataGridView.Rows[entriesDataGridView.Rows.Count - 1].Cells[k].Value
                    = alternativesMeans[k] - totalAverage;
                ssa += (alternativesMeans[k] - totalAverage) * (alternativesMeans[k] - totalAverage);
            }
            ssa *= numberOfMeasurements;
            float sse = 0.0f;
            float sst = 0.0f;
            for(int j = 0; j < numberOfAlternatives; j++)
            {
                for(i = 0; i < numberOfMeasurements; i++)
                {
                    sse += (float.Parse(entriesDataGridView.Rows[i].Cells[j].Value.ToString()) - alternativesMeans[j])
                        * (float.Parse(entriesDataGridView.Rows[i].Cells[j].Value.ToString()) - alternativesMeans[j]);
                    sst += ((float.Parse(entriesDataGridView.Rows[i].Cells[j].Value.ToString()) - alternativesMeans[j])
                        + (alternativesMeans[j] - totalAverage))
                        * ((float.Parse(entriesDataGridView.Rows[i].Cells[j].Value.ToString()) - alternativesMeans[j])
                        + (alternativesMeans[j] - totalAverage));
                }
            }
            float saSquared = ssa / (numberOfAlternatives - 1);
            float seSquared = sse / (numberOfAlternatives * (numberOfMeasurements - 1));
            float ftestCalculated = saSquared / seSquared;
            sseLabel.Text = sse.ToString("0.0000");
            ssaLabel.Text = ssa.ToString("0.0000");
            sstLabel.Text = sst.ToString("0.0000");
            fCalculatedValue.Text = ftestCalculated.ToString("0.0000");
            Chart c = new Chart();
            double fTabulatedValue90thPercentile = c.DataManipulator.Statistics
                .InverseFDistribution(0.1f, numberOfAlternatives - 1, numberOfAlternatives * (numberOfMeasurements - 1));
            double fTabulatedValue95thPercentile = c.DataManipulator.Statistics
                .InverseFDistribution(0.05f, numberOfAlternatives - 1, numberOfAlternatives * (numberOfMeasurements - 1));
            double fTabulatedValue99thPercentile = c.DataManipulator.Statistics
                .InverseFDistribution(0.01f, numberOfAlternatives - 1, numberOfAlternatives * (numberOfMeasurements - 1));
            tabulated90Label.Text = fTabulatedValue90thPercentile.ToString("0.0000");
            tabulated95Label.Text = fTabulatedValue95thPercentile.ToString("0.0000");
            tabulated99Label.Text = fTabulatedValue99thPercentile.ToString("0.0000");
            float ssaDivSst = (ssa / sst) * 100;
            float sseDivSst = (sse / sst) * 100;
            ssaDivSstLabel.Text = ssaDivSst.ToString("0.0000") + " %";
            sseDivSstLabel.Text = sseDivSst.ToString("0.0000") + " %";

            contrastDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            contrastTrustIntervalDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;

            //*************************************************

            List<Alternative> alternativesList = new List<Alternative>();
            for (i = 0; i < numberOfAlternatives; i++)
            {
                alternativesList.Add(new Alternative("" + (i + 1), 0));
            }
            foreach (Alternative alternativeIter in alternativesList)
            {
                contrastDataGridView.Columns.Add(alternativeIter.AlternativeName, alternativeIter.AlternativeName);
            }
            if (numberOfAlternatives < 50)
            {
                contrastDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                contrastDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            foreach (DataGridViewColumn column in contrastDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.ReadOnly = true;
            }

            for (i = 0; i < numberOfAlternatives; i++)
            {
                contrastDataGridView.Rows.Add();
                contrastDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            contrastDataGridView.TopLeftHeaderCell.Value = "Kontrasti";
            contrastDataGridView.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            contrastDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            contrastDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            contrastDataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for(i = 0; i < numberOfAlternatives; i++)
            {
                for(int j = 0; j < numberOfAlternatives; j++)
                {
                    contrastDataGridView.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (i == j)
                    {
                        //contrastDataGridView.Rows[i].Cells[j].Value = "X";
                        contrastDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        contrastDataGridView.Rows[i].Cells[j].Value
                            = ((alternativesMeans[i] - totalAverage) - (alternativesMeans[j] - totalAverage))
                            .ToString("0.0000");
                    }
                }
            }

            //*************************************************
            
            foreach (Alternative alternativeIter in alternativesList)
            {
                contrastTrustIntervalDataGridView.Columns.Add(alternativeIter.AlternativeName, alternativeIter.AlternativeName);
            }
            if (numberOfAlternatives < 50)
            {
                contrastTrustIntervalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                contrastTrustIntervalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            foreach (DataGridViewColumn column in contrastTrustIntervalDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.ReadOnly = true;
            }

            for (i = 0; i < numberOfAlternatives; i++)
            {
                contrastTrustIntervalDataGridView.Rows.Add();
                contrastTrustIntervalDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            contrastTrustIntervalDataGridView.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            contrastTrustIntervalDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            contrastTrustIntervalDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            contrastTrustIntervalDataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (i = 0; i < numberOfAlternatives; i++)
            {
                for (int j = 0; j < numberOfAlternatives; j++)
                {
                    contrastTrustIntervalDataGridView.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (i == j)
                    {
                        //contrastTrustIntervalDataGridView.Rows[i].Cells[j].Value = "X";
                        contrastTrustIntervalDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        double se = Math.Sqrt((double)seSquared);
                        double sc = se * Math.Sqrt(2.0f / (numberOfAlternatives * numberOfMeasurements));
                        double alphaHalf = 0.00;
                        if (probability90RadioButton.Checked)
                        {
                            contrastTrustIntervalDataGridView.TopLeftHeaderCell.Value = "90%-tni intervali povjerenja\nza kontraste";
                            alphaHalf = 0.10;
                        }
                        else if (probability95RadioButton.Checked)
                        {
                            contrastTrustIntervalDataGridView.TopLeftHeaderCell.Value = "95%-tni intervali povjerenja\nza kontraste";
                            alphaHalf = 0.05;
                        }
                        else if (probability99RadioButton.Checked)
                        {
                            contrastTrustIntervalDataGridView.TopLeftHeaderCell.Value = "99%-tni intervali povjerenja\nza kontraste";
                            alphaHalf = 0.01;
                        }
                        Console.WriteLine(i + " " + j + " " + ((alternativesMeans[i] - totalAverage) - (alternativesMeans[j] - totalAverage)));
                        double lowerBound = ((alternativesMeans[i] - totalAverage) - (alternativesMeans[j] - totalAverage))
                            - c.DataManipulator.Statistics
                            .InverseTDistribution(alphaHalf, numberOfAlternatives * (numberOfMeasurements - 1)) * sc;
                        double upperBound = ((alternativesMeans[i] - totalAverage) - (alternativesMeans[j] - totalAverage))
                            + c.DataManipulator.Statistics.InverseTDistribution(alphaHalf,
                            numberOfAlternatives * (numberOfMeasurements - 1)) * sc;
                        contrastTrustIntervalDataGridView.Rows[i].Cells[j].Value
                            = "[" + lowerBound.ToString("0.0000") + " : " + upperBound.ToString("0.0000") + "]";
                        if(lowerBound * upperBound < 0)
                        {
                            contrastTrustIntervalDataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            contrastTrustIntervalDataGridView.Rows[i].Cells[j].Style.BackColor = Color.PaleVioletRed;
                        }
                    }
                }
            }

            //*************************************************

            resultsGenerated = true;
        }

        private void anovaTest_Load(object sender, EventArgs e)
        {

        }

        private void contrastDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
