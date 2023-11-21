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
            comboBox_carnames = new ComboBox();
            label1 = new Label();
            menuStrip.SuspendLayout();
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
            // comboBox_carnames
            // 
            comboBox_carnames.FormattingEnabled = true;
            resources.ApplyResources(comboBox_carnames, "comboBox_carnames");
            comboBox_carnames.Name = "comboBox_carnames";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(comboBox_carnames);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Main_Form";
            Load += Main_Form_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private ComboBox comboBox_carnames;
        private Label label1;
    }
}