using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;


namespace POS_ML_Test
{
    internal static class Program
    {
        public static string ConnectionString;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Log_In());
        }

        // Replace the incorrect line in LoadConnectionString method:
        public static void LoadConnectionString()
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(AppContext.BaseDirectory) // ensures it looks in bin\Debug
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();

            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public static class Current_User
        {
            public static Guid Current_user_id { get; set; }
            public static string Current_user_name { get; set; }
        }

        public static string Created_Info(string createdBy, DateTime createdOn, int totalLength = 80)
        {
            string leftText = $"Created by: {createdBy}";
            string rightText = $"Created On: {createdOn:dd-MM-yyyy HH:mm:ss}";

            return leftText.PadRight(totalLength - rightText.Length) + rightText;
        }

        public static string Modified_Info(string modifiedBy, DateTime modifiedOn, int totalLength = 80)
        {
            string leftText = $"Modified by: {modifiedBy}";
            string rightText = $"Modified On: {modifiedOn:dd-MM-yyyy HH:mm:ss}";

            return leftText.PadRight(totalLength - rightText.Length) + rightText;
        }
        public static void AllowDecimalInput(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            // Allow control keys (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Only allow digits and one decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Optional: limit to 2 decimal places while typing
            if (tb.Text.Contains("."))
            {
                int index = tb.Text.IndexOf(".");
                if (tb.SelectionStart > index && tb.Text.Substring(index + 1).Length >= 2)
                {
                    e.Handled = true;
                }
            }
        }

        public static void AllowIntegerInput(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace)
            if (char.IsControl(e.KeyChar)) return;

            // Only allow digits
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public static void ShowAutoMessage(string message, int durationMs = 1000)
        {
            Form msgForm = new Form()
            {
                Size = new Size(300, 100),
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                BackColor = Color.LightGreen
            };

            Label lbl = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Text = message,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            msgForm.Controls.Add(lbl);

            // Explicitly use Windows Forms Timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            {
                Interval = durationMs
            };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                msgForm.Close();
            };
            timer.Start();

            msgForm.ShowDialog();
        }
    }
}


