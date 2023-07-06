using System.Linq;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace TravelRecommendationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public DataTable CSVtoDataTable(string strFilePath, char csvDelimiter)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(csvDelimiter);
                foreach (string header in headers)
                {
                    try
                    {
                        dt.Columns.Add(header);
                    }
                    catch { }
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(csvDelimiter);
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }

        List<string> cit = new List<string>();

        string CsvFilePath;
        char csvDelimiter;
        DataTable dt;

        private void connect_Click(object sender, EventArgs e)
        {
            CsvFilePath = @"flights.csv";
            csvDelimiter = ',';
            dt = CSVtoDataTable(CsvFilePath, csvDelimiter);
            connect.Enabled = false;
            string pricepre;
            decimal price;
            dt.Columns.Add("priceT", typeof(System.Decimal));
            foreach (DataRow row in dt.Rows)
            {
                pricepre = row.Field<string>("price").ToString();
                price = Convert.ToDecimal(pricepre);
                row["priceT"] = price;
            }
            begin.Enabled = true;
            DataRow[] x = dt.Select();
            foreach (DataRow row in x)
            {
                if (!cit.Contains(row.Field<string>("from")))
                    cit.Add(row.Field<string>("from"));
                        
            }
            foreach (string item in cit)
            {
                beginning.Items.Add(item);
            }

        }
        private void begin_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            int numbers = Decimal.ToInt32(cities.Value);
            decimal budg = budget.Value;
            string start;
            int userC = Decimal.ToInt32(user.Value);
            if (beginning.SelectedItem != null)
            {
                start = beginning.SelectedItem.ToString();
            }
            else start = "Recife (PE)";
            findNext(userC, budg, numbers, start);
        }

        void findNext(int user, decimal budget, int numbers, string start)
        {
            List<string> unvisited = new List<string>();
            unvisited = cit.ToList();
            unvisited.Remove(start);
            List<string> visited = new List<string>();
            DataRow[] rows;
            string filterEx;
            decimal priceHere;
            string sortEx = "priceT ASC";
            visited.Add(start);
            string exclude;
            for (int i = 1; i < numbers; i++)
            {
                exclude = "('" + string.Join("','", unvisited) + "')";
                filterEx = string.Format("userCode = '{0}' AND from = '{1}' AND to IN {2}", user, visited[visited.Count - 1], exclude);
                rows = dt.Select(filterEx, sortEx);
                if (rows.Length > 0)
                {
                    priceHere = rows[0].Field<decimal>("priceT");

                    if (unvisited.Contains(rows[0].Field<string>("to")) && priceHere <= budget && !String.IsNullOrEmpty(rows[0].Field<string>("to")))
                    {
                        visited.Add(rows[0].Field<string>("to"));
                        unvisited.Remove(rows[0].Field<string>("to"));
                        budget -= priceHere;
                    }
                    else if (priceHere >= budget) break;
                }
            }


            foreach (string city in visited)
            {
                if (String.IsNullOrEmpty(city)) continue;
                output.AppendText(city);
                output.AppendText(Environment.NewLine);
            }
            output.AppendText("Remaining budget: $" + budget);
            output.AppendText(Environment.NewLine);
        }

        
    }
}