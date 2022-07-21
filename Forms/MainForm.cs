using coursework.Controllers;
using coursework.Exeptions;
using coursework.Fields;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace coursework.Forms
{
    public partial class MainForm : Form
    {
        MainContr mainContr;
        private delegate void setWarnLabel(string msg);
        private delegate void pointsClear();
        private delegate void pointsAdd(Quote quote);
        private delegate void chartMinMax(float min, float max);
        public MainForm()
        {
            mainContr = new MainContr();
            InitializeComponent();
            mainContr.AssetChangedEvent += displayAsset;
            mainContr.MarketChangedEvent += displayMarket;
            mainContr.QuotesGettedEvent += displayChart;
            mainContr.NoGettedQoutes += errorMessage;
            mainContr.CurrentAssetChangeEvent += _mainController_CurrentAssetChangeEvent;
            mainContr.CurrentMarketChangeEvent += _mainController_CurrentMarketChangeEvent;
            mainContr.EnableFunction += MainContr_EnableFunction;
            mainContr.DisableFunction += MainContr_DisableFunction;
            displayAssetHeader();
            displayMarketHeader();
            quoteChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            quoteChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            quoteChart.MouseWheel += quoteChart_MouseWheel;
        }

        private void MainContr_DisableFunction()
        {
            settingToolStripMenuItem.Enabled = false;
            settingToolStripMenuItem.BackColor = Color.DarkGray;
            marketSelectButton.Enabled = false;
            marketSelectButton.BackColor = Color.DarkGray;
            assetSelectButton.Enabled = false;
            assetSelectButton.BackColor = Color.DarkGray;
            viewSelectAsset.Enabled = false;
            viewSelectAsset.BackColor = Color.DarkGray;
            authButton.Enabled = true;
            authButton.BackColor = Color.DodgerBlue;
        }

        private void MainContr_EnableFunction()
        {
            settingToolStripMenuItem.Enabled = true;
            settingToolStripMenuItem.BackColor = Color.DodgerBlue;
            marketSelectButton.Enabled = true;
            marketSelectButton.BackColor = Color.DodgerBlue;
            assetSelectButton.Enabled = true;
            assetSelectButton.BackColor = Color.DodgerBlue;
            viewSelectAsset.Enabled = true;
            viewSelectAsset.BackColor = Color.DodgerBlue;
        }

        private void _mainController_CurrentMarketChangeEvent(int index)
        {
            for (int i = 0; i < marketListView.Items.Count; i++)
            {
                if (index == i)
                {
                    marketListView.Items[i].BackColor = Color.DodgerBlue;
                }
                else
                {
                    marketListView.Items[i].BackColor = Color.White;
                }
            }
        }

        private void _mainController_CurrentAssetChangeEvent(int index)
        {
            for (int i = 0; i < assetListView.Items.Count; i++)
            {
                if(index == i)
                {
                    assetListView.Items[i].BackColor = Color.DodgerBlue;
                }
                else
                {
                    assetListView.Items[i].BackColor = Color.White;
                }
            }
        }

        private void assetSelectButton_Click(object sender, EventArgs e)
        {
            if (assetListView.SelectedItems.Count > 0)
            {
                warningLabel.Visible = false;
                int indSelectItem = assetListView.SelectedIndices[0];
                mainContr.SetCurrentAsset(mainContr.Assets[indSelectItem]);
                clearPoints();
            }
            else
            {
                warningLabel.Text = Properties.Resources.ErrorMessageWarningNotExistSelectAsset;
                warningLabel.Visible = true;
            }
        }

        private void marketSelectButton_Click(object sender, EventArgs e)
        {
            if (marketListView.SelectedItems.Count > 0)
            {
                warningLabel.Visible = false;
                int indSelectItem = marketListView.SelectedIndices[0];
                mainContr.SetCurrentMarket(mainContr.Markets[indSelectItem]);
                /*displayAsset();*/
                clearPoints();
            }
            else
            {
                warningLabel.Text = Properties.Resources.ErrorMessageWarningNotExistSelectMarket;
                warningLabel.Visible = true;
            }
        }

        private void displayAsset()
        {
            assetListView.Items.Clear();

            foreach (Asset asset in mainContr.Assets)
            {
                List<string> values = new List<string>();
                foreach (Field field in mainContr.AssetFields)
                {
                    values.Add(field.GetValue(asset));
                }
                assetListView.Items.Add(new ListViewItem(values.ToArray()));
            }
            assetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void displayMarket()
        {
            marketListView.Items.Clear();

            foreach (Market market in mainContr.Markets)
            {
                List<string> values = new List<string>();
                foreach (Field field in mainContr.MarketFields)
                {
                    values.Add(field.GetValue(market));
                }
                marketListView.Items.Add(new ListViewItem(values.ToArray()));
            }
            marketListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void displayMarketHeader()
        {
            marketListView.Columns.Clear();
            foreach (Field field in mainContr.MarketFields)
            {
                ColumnHeader header = new ColumnHeader
                {
                    Text = field.NameType
                };
                marketListView.Columns.Add(header);
            }
            marketListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void quoteChart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void displayChart()
        {
            clearPoints();
            float min = mainContr.CurrentAsset.Quotes[0].Low;
            float max = mainContr.CurrentAsset.Quotes[0].High;
            foreach (Quote quote in mainContr.CurrentAsset.Quotes)
            {
                if (quote.High > max)
                    max = quote.High;
                if (quote.Low < min)
                    min = quote.Low;
                setXYPointsChart(quote);
                setAsis(min, max);
            }
        }

        private void setAsis(float min, float max)
        {
            if (quoteChart.InvokeRequired)
            {
                var d = new chartMinMax(setAsis);
                quoteChart.Invoke(d, new object[] { min, max });
            }
            else
            {
                quoteChart.ChartAreas[0].AxisY.Minimum = Math.Round(min, 2);
                quoteChart.ChartAreas[0].AxisY.Maximum = Math.Round(max, 2);
            }
        }

        private void setXYPointsChart(Quote quote)
        {
            if (quoteChart.InvokeRequired)
            {
                var d = new pointsAdd(setXYPointsChart);
                quoteChart.Invoke(d, new object[] { quote });
            }
            else
            {
                quoteChart.Series[Properties.Resources.HeaderQuoteChart].Points.
                    AddXY(quote.DateTime, quote.High, quote.Low, quote.Open, quote.Close);
            }
        }

        private void clearPoints()
        {
            if (quoteChart.InvokeRequired)
            {
                var d = new pointsClear(clearPoints);
                quoteChart.Invoke(d);
            }
            else
            {
                quoteChart.Series[Properties.Resources.HeaderQuoteChart].Points.Clear();
            }
        }

        private void errorMessage(string msg)
        {
            if (warningLabel.InvokeRequired)
            {
                var d = new setWarnLabel(errorMessage);
                warningLabel.Invoke(d, new object[] { msg });
            }
            else
            {
                warningLabel.Text = msg;
                warningLabel.Visible = true;
            }

        }


        private void displayAssetHeader()
        {
            assetListView.Columns.Clear();
            foreach (Field field in mainContr.AssetFields)
            {
                ColumnHeader header = new ColumnHeader
                {
                    Text = field.NameType
                };
                assetListView.Columns.Add(header);
            }
            assetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void addMarketSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                warningLabel.Visible = false;
                mainContr.AddMarket();
            }
            catch (AddMarketException ex)
            {
                warningLabel.Text = ex.Message;
                warningLabel.Visible = true;
            }

        }

        private void addAssetSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                warningLabel.Visible = false;
                mainContr.AddAsset();
            }
            catch (Exception ex)
            {
                warningLabel.Text = ex.Message;
                warningLabel.Visible = true;
            }
        }

        private void viewSelectAsset_Click(object sender, EventArgs e)
        {
            if (mainContr.CurrentAsset != null)
            {
                warningLabel.Visible = false;
                mainContr.GetQuotes(beginDateTimePicker.Value, endDateTimePicker.Value);
            }
            else
            {
                warningLabel.Text = Properties.Resources.ErrorMessageWarningNotExistCurrentAsset;
                warningLabel.Visible = true;
            }
        }

        private void deleteMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainContr.DeleteCurrentMarket();
        }

        private void deleteAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainContr.DeleteCurrentAsset();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            authButton.Enabled = false;
            authButton.BackColor = Color.DarkGray;
            mainContr.Auth();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            mainContr.Exit();
        }
    }
}
