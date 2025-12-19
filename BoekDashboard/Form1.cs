using BoekDB.Data;
using BoekDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BoekDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SetStatTitles();
            LoadAuthors();
            UpdateDashboard();
        }
        private void SetStatTitles()
        {
            totalBooksCtrl.SetTitle("Total books");
            priceAverageCtrl.SetTitle("Average price");
            pagesMinAverageCtrl.SetTitle("Min pages");
            pagesMaxAverageCtrl.SetTitle("Max pages");
            leastSoldBookCtrl.SetTitle("Least sold books");
            mostSoldBookCtrl.SetTitle("Most sold books");
        }

        private void UpdateDashboard(int? authorId = null)
        {
            var bookData = new Books();
            var orderData = new Orders();

            int totaal = bookData.GetBookCount(authorId);
            decimal avgPrice = bookData.GetAverageBookPrice(authorId);
            var pageCounts = bookData.GetMinAndMaxPageCount(authorId);
            List<BookChart> datapoints = bookData.GetReleaseBooksPerYears(authorId);

            var mostSold = orderData.GetMostSoldBook(authorId);
            var leastSold = orderData.GetLeastSoldBook(authorId);

            totalBooksCtrl.SetValue($"#{totaal}");
            priceAverageCtrl.SetValue($"€{avgPrice:F2}");
            pagesMinAverageCtrl.SetValue($"#{pageCounts.MinPages:F0}");
            pagesMaxAverageCtrl.SetValue($"#{pageCounts.MaxPages:F0}");

            if (mostSold != null)
            {
                mostSoldBookCtrl.SetName(mostSold.Title);
                mostSoldBookCtrl.SetPrice($"€{mostSold.Price:F2}");
                mostSoldBookCtrl.SetAmount(mostSold.Amount.ToString());
            }

            if (leastSold != null)
            {
                leastSoldBookCtrl.SetName(leastSold.Title);
                leastSoldBookCtrl.SetPrice($"€{leastSold.Price:F2}");
                leastSoldBookCtrl.SetAmount(leastSold.Amount.ToString());
            }


            UpdateChart(datapoints);
        }


        private void UpdateChart(List<BookChart> datapoints)
        {
            chart1.Series["Books"].Points.Clear();

            foreach (var point in datapoints)
            {
                chart1.Series["Books"].Points.AddXY(point.Year, point.ReleasedBookCount);
            }

            if (datapoints.Any())
            {
                var area = chart1.ChartAreas[0];
                area.AxisX.Minimum = datapoints.Min(x => x.Year);
                area.AxisX.Maximum = datapoints.Max(x => x.Year);
            }
        }

        private void LoadAuthors()
        {
            var authorData = new Authors();
            var authors = authorData.GetAuthors();

            authors.Insert(0, new Author
            {
                Id = 0,
                Name = "All authors"
            });

            AuthorCB.DataSource = authors;
            AuthorCB.DisplayMember = "Name";
            AuthorCB.ValueMember = "Id";
            AuthorCB.SelectedIndex = 0;
        }

        private void AuthorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuthorCB.SelectedItem == null) return;

            var selectedAuthor = AuthorCB.SelectedItem as Author;
            if (selectedAuthor == null) return;

            int? authorId = selectedAuthor.Id == 0
                ? (int?)null
                : selectedAuthor.Id;

            UpdateDashboard(authorId);
        }

    }
}
