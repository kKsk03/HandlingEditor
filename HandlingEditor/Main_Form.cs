using System.Resources;
using static System.Windows.Forms.LinkLabel;

namespace HandlingEditor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.isHandlingOpen)
            {
                comboBox_carnames.Enabled = false;
            }
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_handling = new OpenFileDialog();
            ofd_handling.Multiselect = false;
            ofd_handling.Filter = "cfg file (*.cfg)|*.cfg|所有文件 (*.*)|*.*";
            ofd_handling.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult ofd_result = ofd_handling.ShowDialog();
            if (ofd_result == DialogResult.OK)
            {
                comboBox_carnames.Enabled = getCarNames(ofd_handling.FileName);
            }
        }

        private void menu_file_close_Click(object sender, EventArgs e)
        {
            comboBox_carnames.Enabled = false;
            // 清理comboBox的数据
            comboBox_carnames.Items.Clear();
            comboBox_carnames.Text = null;
        }

        bool getCarNames(string cfg_path)
        {
            string[] name_lines = File.ReadAllLines(cfg_path);
            List<string> vehicleNames = new List<string>();
            foreach (string line in name_lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith(";") || line.Trim().StartsWith("%") || line.Trim().StartsWith("$") || line.Trim().StartsWith("^"))
                {
                    continue;
                }
                string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string vehicleName = data[0].Trim();
                vehicleNames.Add(vehicleName);

                if (line.Contains("RCRAIDER"))
                {
                    break;
                }
            }
            comboBox_carnames.Items.AddRange(vehicleNames.ToArray());
            return true;
        }
    }
}