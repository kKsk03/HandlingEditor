namespace HandlingEditor
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            menuStrip = new MenuStrip();
            menu_file = new ToolStripMenuItem();
            menu_file_open = new ToolStripMenuItem();
            menu_file_save = new ToolStripMenuItem();
            menu_file_close = new ToolStripMenuItem();
            toolStripSeparator_file = new ToolStripSeparator();
            menu_file_exit = new ToolStripMenuItem();
            menu_about = new ToolStripMenuItem();
            label1 = new Label();
            tabControl_cfgdata = new TabControl();
            tabPage_normal = new TabPage();
            label9 = new Label();
            label8 = new Label();
            textBox_drown_per = new TextBox();
            textBox_gravity_z = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox_gravity_y = new TextBox();
            textBox_gravity_x = new TextBox();
            textBox_dragmess = new TextBox();
            textBox_turnmass = new TextBox();
            textBox_carweight = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox_carname = new TextBox();
            label2 = new Label();
            tabPage_grip = new TabPage();
            listBox_carnames = new ListBox();
            menuStrip.SuspendLayout();
            tabControl_cfgdata.SuspendLayout();
            tabPage_normal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_file, menu_about });
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.Name = "menuStrip";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { menu_file_open, menu_file_save, menu_file_close, toolStripSeparator_file, menu_file_exit });
            menu_file.Name = "menu_file";
            resources.ApplyResources(menu_file, "menu_file");
            // 
            // menu_file_open
            // 
            menu_file_open.Name = "menu_file_open";
            resources.ApplyResources(menu_file_open, "menu_file_open");
            menu_file_open.Click += menu_file_open_Click;
            // 
            // menu_file_save
            // 
            menu_file_save.Name = "menu_file_save";
            resources.ApplyResources(menu_file_save, "menu_file_save");
            // 
            // menu_file_close
            // 
            menu_file_close.Name = "menu_file_close";
            resources.ApplyResources(menu_file_close, "menu_file_close");
            menu_file_close.Click += menu_file_close_Click;
            // 
            // toolStripSeparator_file
            // 
            toolStripSeparator_file.Name = "toolStripSeparator_file";
            resources.ApplyResources(toolStripSeparator_file, "toolStripSeparator_file");
            // 
            // menu_file_exit
            // 
            menu_file_exit.Name = "menu_file_exit";
            resources.ApplyResources(menu_file_exit, "menu_file_exit");
            // 
            // menu_about
            // 
            menu_about.Name = "menu_about";
            resources.ApplyResources(menu_about, "menu_about");
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tabControl_cfgdata
            // 
            tabControl_cfgdata.Controls.Add(tabPage_normal);
            tabControl_cfgdata.Controls.Add(tabPage_grip);
            resources.ApplyResources(tabControl_cfgdata, "tabControl_cfgdata");
            tabControl_cfgdata.Name = "tabControl_cfgdata";
            tabControl_cfgdata.SelectedIndex = 0;
            // 
            // tabPage_normal
            // 
            tabPage_normal.Controls.Add(label9);
            tabPage_normal.Controls.Add(label8);
            tabPage_normal.Controls.Add(textBox_drown_per);
            tabPage_normal.Controls.Add(textBox_gravity_z);
            tabPage_normal.Controls.Add(label7);
            tabPage_normal.Controls.Add(label6);
            tabPage_normal.Controls.Add(label5);
            tabPage_normal.Controls.Add(textBox_gravity_y);
            tabPage_normal.Controls.Add(textBox_gravity_x);
            tabPage_normal.Controls.Add(textBox_dragmess);
            tabPage_normal.Controls.Add(textBox_turnmass);
            tabPage_normal.Controls.Add(textBox_carweight);
            tabPage_normal.Controls.Add(label4);
            tabPage_normal.Controls.Add(label3);
            tabPage_normal.Controls.Add(textBox_carname);
            tabPage_normal.Controls.Add(label2);
            resources.ApplyResources(tabPage_normal, "tabPage_normal");
            tabPage_normal.Name = "tabPage_normal";
            tabPage_normal.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // textBox_drown_per
            // 
            resources.ApplyResources(textBox_drown_per, "textBox_drown_per");
            textBox_drown_per.Name = "textBox_drown_per";
            // 
            // textBox_gravity_z
            // 
            resources.ApplyResources(textBox_gravity_z, "textBox_gravity_z");
            textBox_gravity_z.Name = "textBox_gravity_z";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // textBox_gravity_y
            // 
            resources.ApplyResources(textBox_gravity_y, "textBox_gravity_y");
            textBox_gravity_y.Name = "textBox_gravity_y";
            // 
            // textBox_gravity_x
            // 
            resources.ApplyResources(textBox_gravity_x, "textBox_gravity_x");
            textBox_gravity_x.Name = "textBox_gravity_x";
            // 
            // textBox_dragmess
            // 
            resources.ApplyResources(textBox_dragmess, "textBox_dragmess");
            textBox_dragmess.Name = "textBox_dragmess";
            // 
            // textBox_turnmass
            // 
            resources.ApplyResources(textBox_turnmass, "textBox_turnmass");
            textBox_turnmass.Name = "textBox_turnmass";
            // 
            // textBox_carweight
            // 
            resources.ApplyResources(textBox_carweight, "textBox_carweight");
            textBox_carweight.Name = "textBox_carweight";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox_carname
            // 
            resources.ApplyResources(textBox_carname, "textBox_carname");
            textBox_carname.Name = "textBox_carname";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tabPage_grip
            // 
            resources.ApplyResources(tabPage_grip, "tabPage_grip");
            tabPage_grip.Name = "tabPage_grip";
            tabPage_grip.UseVisualStyleBackColor = true;
            // 
            // listBox_carnames
            // 
            resources.ApplyResources(listBox_carnames, "listBox_carnames");
            listBox_carnames.FormattingEnabled = true;
            listBox_carnames.Name = "listBox_carnames";
            listBox_carnames.SelectedIndexChanged += listBox_carnames_SelectedIndexChanged;
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox_carnames);
            Controls.Add(tabControl_cfgdata);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Main_Form";
            Load += Main_Form_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl_cfgdata.ResumeLayout(false);
            tabPage_normal.ResumeLayout(false);
            tabPage_normal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menu_file;
        private ToolStripMenuItem menu_file_open;
        private ToolStripMenuItem menu_file_save;
        private ToolStripMenuItem menu_file_close;
        private ToolStripSeparator toolStripSeparator_file;
        private ToolStripMenuItem menu_file_exit;
        private ToolStripMenuItem menu_about;
        private Label label1;
        private TabControl tabControl_cfgdata;
        private TabPage tabPage_normal;
        private TabPage tabPage_grip;
        private ListBox listBox_carnames;
        private Label label2;
        private TextBox textBox_gravity_y;
        private TextBox textBox_gravity_x;
        private TextBox textBox_dragmess;
        private TextBox textBox_turnmass;
        private TextBox textBox_carweight;
        private Label label4;
        private Label label3;
        private TextBox textBox_carname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox textBox_drown_per;
        private TextBox textBox_gravity_z;
    }
}