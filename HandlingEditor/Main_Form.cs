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

                // 常规
                textBox_carname.Text = selectedCar; // 直接获取ListBox中的车名
                textBox_carweight.Enabled = true; textBox_carweight.Text = numericData[1];
                textBox_turnmass.Enabled = true; textBox_turnmass.Text = numericData[2];
                textBox_dragmess.Enabled = true; textBox_dragmess.Text = numericData[3];
                textBox_gravity_x.Enabled = true; textBox_gravity_x.Text = numericData[4];
                textBox_gravity_y.Enabled = true; textBox_gravity_y.Text = numericData[5];
                textBox_gravity_z.Enabled = true; textBox_gravity_z.Text = numericData[6];
                textBox_drown_per.Enabled = true; textBox_drown_per.Text = numericData[7];

                // 抓地力
                textBox_grip_b.Enabled = true; textBox_grip_b.Text = numericData[8];
                textBox_grip_data.Enabled = true; textBox_grip_data.Text = numericData[9];
                textBox_grip_fr.Enabled = true; textBox_grip_fr.Text = numericData[10];

                // 参数
                textBox_gear.Enabled = true; textBox_gear.Text = numericData[11];
                textBox_topspeed.Enabled = true; textBox_topspeed.Text = numericData[12];
                textBox_speedup.Enabled = true; textBox_speedup.Text = numericData[13];
                textBox_speedup_force.Enabled = true; textBox_speedup_force.Text = numericData[14];
                textBox_drive_form.Enabled = true; textBox_drive_form.Text = numericData[15];
                textBox_engine_type.Enabled = true; textBox_engine_type.Text = numericData[16];
                textBox_brake.Enabled = true; textBox_brake.Text = numericData[17];
                textBox_brake_balance.Enabled = true; textBox_brake_balance.Text = numericData[18];
                textBox_abs.Enabled = true; textBox_abs.Text = numericData[19];
                textBox_max_turnangle.Enabled = true; textBox_max_turnangle.Text = numericData[20];

                // 悬挂
                textBox_hand_g.Enabled = true; textBox_hand_g.Text = numericData[21];
                textBox_hand_force.Enabled = true; textBox_hand_force.Text = numericData[22];
                textBox_hs_force.Enabled = true; textBox_hs_force.Text = numericData[23];
                textBox_hand_top.Enabled = true; textBox_hand_top.Text = numericData[24];
                textBox_hand_down.Enabled = true; textBox_hand_down.Text = numericData[25];
                textBox_hand_balance.Enabled = true; textBox_hand_balance.Text = numericData[26];
                textBox_hand_hard.Enabled = true; textBox_hand_hard.Text = numericData[27];

                // 其他
                textBox_door.Enabled = true; textBox_door.Text = numericData[28];
                textBox_damage.Enabled = true; textBox_damage.Text = numericData[29];
                textBox_price.Enabled = true; textBox_price.Text = numericData[30];

                // 特殊
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
            StringBuilder currentToken = new StringBuilder();
            foreach (char c in line)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (currentToken.Length > 0)
                    {
                        numericData.Add(currentToken.ToString());
                        currentToken.Clear();
                    }
                }
                else
                {
                    // 添加到当前数字或字母
                    currentToken.Append(c);
                }
            }
            if (currentToken.Length > 0)
            {
                numericData.Add(currentToken.ToString());
            }
            return numericData;
        }
    }
}