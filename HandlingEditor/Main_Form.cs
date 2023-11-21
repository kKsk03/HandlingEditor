using System.Text;

namespace HandlingEditor
{
    public partial class Main_Form : Form
    {
        string handling_cfg_dir;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

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
                handling_cfg_dir = ofd_handling.FileName;
                listBox_carnames.Enabled = getCarNames(ofd_handling.FileName);
            }
        }

        private void menu_file_close_Click(object sender, EventArgs e)
        {
            // 清理comboBox的数据
            listBox_carnames.Items.Clear();
            listBox_carnames.Text = null;
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

                if (line.Contains("RCRAIDER")) // 标准的Handling文件最后一项
                {
                    break;
                }
            }
            listBox_carnames.Items.AddRange(vehicleNames.ToArray());
            return true;
        }

        private void listBox_carnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCar = listBox_carnames.SelectedItem.ToString();
            string[] allLines = File.ReadAllLines(handling_cfg_dir);

            // 查找包含选定车辆名的行
            string selectedCarLine = allLines.FirstOrDefault(line => line.Contains(selectedCar));

            if (selectedCarLine != null)
            {
                List<string> numericData = GetNumericData(selectedCarLine);

                // 获取数据之后，将数据放入各个textbox
                textBox_carname.Text = selectedCar; // 直接获取ListBox中的车名
                textBox_carweight.Enabled = true; textBox_carweight.Text = double.Parse(numericData[0]).ToString("0.00"); //2位小数
                textBox_turnmass.Enabled = true; textBox_turnmass.Text = double.Parse(numericData[1]).ToString("0.00"); //2位小数
                textBox_dragmess.Enabled = true; textBox_dragmess.Text = double.Parse(numericData[2]).ToString("0.00"); //2位小数
                textBox_gravity_x.Enabled = true; textBox_gravity_x.Text = double.Parse(numericData[3]).ToString("0.00"); //2位小数
                textBox_gravity_y.Enabled = true; textBox_gravity_y.Text = double.Parse(numericData[4]).ToString("0.00"); //2位小数
                textBox_gravity_z.Enabled = true; textBox_gravity_z.Text = double.Parse(numericData[5]).ToString("0.00"); //2位小数
                textBox_drown_per.Enabled = true; textBox_drown_per.Text = double.Parse(numericData[6]).ToString(); //没有小数
            }
        }

        /// <summary>
        /// 用于获取已选定车辆名后的数据，并生成数组，将每一项数据放入数组内，方便后续调用
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private List<string> GetNumericData(string line)
        {
            List<string> numericData = new List<string>();
            StringBuilder currentNumber = new StringBuilder();
            foreach (char c in line)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (currentNumber.Length > 0)
                    {
                        numericData.Add(currentNumber.ToString());
                        currentNumber.Clear();
                    }
                }
                else if (char.IsDigit(c) || c == '.' || c == '-')
                {
                    // 遇到数字、小数点或负号，添加到当前数字
                    currentNumber.Append(c);
                }
            }
            if (currentNumber.Length > 0)
            {
                numericData.Add(currentNumber.ToString());
            }
            return numericData;
        }
    }
}