using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoM2UI
{
	public partial class MainForm : Form
	{
		#region Member declarations

		private const string TimeTextFileName = "Time.txt";
		private const string NotesTextFileName = "Notes.txt";

		private DateTime lastUpdateDateTime;
		private bool isSaved;

		#endregion

		#region Constructors

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Private methods

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.timeTextBox.Text = GetFileText(MainForm.TimeTextFileName);
			this.notesTextBox.Text = GetFileText(MainForm.NotesTextFileName);
			this.reportTextBox.Text = GetReportText(this.timeTextBox.Text);

			this.lastUpdateDateTime = DateTime.Now;

			this.isSaved = true;
			this.lastSavedLabel.Text = string.Format("Loaded");
		}


		private string GetFileText(string fileName)
		{
			if (!File.Exists(fileName))
			{
				File.WriteAllText(fileName, string.Empty);
			}

			var timeText = File.ReadAllText(fileName);

			return timeText;
		}


		private void saveTimer_Tick(object sender, EventArgs e)
		{
			if (!this.isSaved)
			{
				TimeSpan unsavedTimeSpan = DateTime.Now - this.lastUpdateDateTime;

				if (unsavedTimeSpan.TotalSeconds > 5)
				{
					SaveText();
				}
			}
		}


		private void SaveText()
		{
			File.WriteAllText(MainForm.TimeTextFileName, this.timeTextBox.Text);
			File.WriteAllText(MainForm.NotesTextFileName, this.notesTextBox.Text);

			this.reportTextBox.Text = GetReportText(this.timeTextBox.Text);

			this.lastSavedLabel.Text = string.Format("Saved: {0:HH:mm}", DateTime.Now);
			this.saveTimer.Stop();
		}


		private string GetReportText(string timeText)
		{
			var reportDateLines = GetReportDateLines(timeText);

			Console.WriteLine(reportDateLines);

			var totalHoursPerMonth = new SortedDictionary<string, double>();

			var reportTextBuilder = new StringBuilder();

			foreach (var reportDate in reportDateLines.Keys)
			{
				reportTextBuilder.AppendLine(reportDate.ToString("ddd dd/MM/yyyy"));
				reportTextBuilder.AppendLine(reportDate.ToString("=============="));

				var dateTotalHoursByDescription = new Dictionary<string, double>();

				var lines = reportDateLines[reportDate];

				for (int i = 0; i < lines.Count; i++)
				{
					if (string.IsNullOrWhiteSpace(lines[i].Item2))
					{
						continue;
					}

					var startTime = lines[i].Item1;

					DateTime stopTime;

					if (i + 1 == lines.Count)
					{
						if (reportDate != DateTime.Now.Date)
						{
							continue;
						}

						stopTime = DateTime.Now;
					}
					else
					{
						stopTime = lines[i + 1].Item1;
					}

					var time = stopTime - startTime;

					if (dateTotalHoursByDescription.ContainsKey(lines[i].Item2))
					{
						dateTotalHoursByDescription[lines[i].Item2] = dateTotalHoursByDescription[lines[i].Item2] + time.TotalHours;
					}
					else
					{
						dateTotalHoursByDescription[lines[i].Item2] = time.TotalHours;
					}
				}

				double dateTotalHours = 0;

				foreach (var description in dateTotalHoursByDescription.Keys)
				{
					reportTextBuilder.AppendLine(
						string.Format("{0:0.00}h : {1}", dateTotalHoursByDescription[description], description));

                    var descriptionDateTotal = dateTotalHoursByDescription[description];

                    dateTotalHours += descriptionDateTotal;

					var monthlyKey = $"{reportDate.ToString("yyyy-MMM")} {description}";

                    if (totalHoursPerMonth.ContainsKey(monthlyKey))
                    {
                        double currentTotal = totalHoursPerMonth[monthlyKey];
                        totalHoursPerMonth[monthlyKey] = currentTotal + descriptionDateTotal;
					}
					else
                    {
						totalHoursPerMonth.Add(monthlyKey, descriptionDateTotal);
					}
				}

				reportTextBuilder.AppendLine(
					string.Format("{0:0.00}h : Total", dateTotalHours));

				reportTextBuilder.AppendLine();
			}

            reportTextBuilder.AppendLine("Monthly totals");
            reportTextBuilder.AppendLine("==============");

            foreach (var monthKey in totalHoursPerMonth.Keys)
            {
				reportTextBuilder.AppendLine($"{monthKey}: {totalHoursPerMonth[monthKey]:0.00}h");
			}

			return reportTextBuilder.ToString();
		}


		private static Dictionary<DateTime, List<Tuple<DateTime, string>>> GetReportDateLines(string timeText)
		{
			string[] timeLines = timeText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			var reportDateLines = new Dictionary<DateTime, List<Tuple<DateTime, string>>>();

			DateTime reportDate = DateTime.Now.Date;

			foreach (var timeLine in timeLines)
			{
				DateTime lineDate;
				if (DateTime.TryParse(timeLine, out lineDate))
				{
					reportDate = lineDate.Date;
				}

				var lineTimeMatch =
					Regex.Match(timeLine, "^(?<hours>[0-2][0-9])[:]?(?<minutes>[0-5][0-9])[ ]?(?<description>.*)");

				if (lineTimeMatch.Success)
				{
					string timeMatch =
						lineTimeMatch.Groups["hours"].Value + ":" + lineTimeMatch.Groups["minutes"].Value;
					string descriptionMatch =
						lineTimeMatch.Groups["description"].Value;

					DateTime time;
					if (DateTime.TryParse(timeMatch, out time))
					{
						if (!reportDateLines.ContainsKey(reportDate))
						{
							reportDateLines.Add(reportDate, new List<Tuple<DateTime, string>>());
						}

						var reportDateLine = new Tuple<DateTime, string>(time, descriptionMatch);

						reportDateLines[reportDate].Add(reportDateLine);
					}
				}
			}
			return reportDateLines;
		}


		private void textChanged(object sender, EventArgs e)
		{
			this.isSaved = false;
			this.lastUpdateDateTime = DateTime.Now;
			this.lastSavedLabel.Text = string.Format("Edited: {0:HH:mm}", DateTime.Now);

			this.saveTimer.Start();
		}


		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.saveTimer.Stop();
		}


		private void timeTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.T))
			{
				var currentDateText = 
					string.Format("================================================================================================"
						+ "\r\n"
						+ "\r\n{0:ddd dd/MM/yy}"
						+ "\r\n"
						+ "\r\n", DateTime.Now);
				this.timeTextBox.Paste(currentDateText);
			}
		}

		#endregion
	}
}
