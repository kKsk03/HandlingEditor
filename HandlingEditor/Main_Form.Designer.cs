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
            label12 = new Label();
            textBox_grip_fr = new TextBox();
            textBox_grip_data = new TextBox();
            label11 = new Label();
            textBox_grip_b = new TextBox();
            label10 = new Label();
            tabPage_speed = new TabPage();
            label22 = new Label();
            textBox_max_turnangle = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            textBox_abs = new TextBox();
            textBox_brake_balance = new TextBox();
            textBox_brake = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBox_engine_type = new TextBox();
            textBox_drive_form = new TextBox();
            textBox_speedup_force = new TextBox();
            textBox_speedup = new TextBox();
            textBox_topspeed = new TextBox();
            textBox_gear = new TextBox();
            label13 = new Label();
            tabPage_handling = new TabPage();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            textBox_hand_hard = new TextBox();
            textBox_hand_balance = new TextBox();
            textBox_hand_down = new TextBox();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            textBox_hand_top = new TextBox();
            textBox_hs_force = new TextBox();
            textBox_hand_force = new TextBox();
            textBox_hand_g = new TextBox();
            label23 = new Label();
            tabPage_others = new TabPage();
            label32 = new Label();
            label31 = new Label();
            textBox_price = new TextBox();
            textBox_damage = new TextBox();
            textBox_door = new TextBox();
            label30 = new Label();
            tabPage_special = new TabPage();
            textBox21 = new TextBox();
            label33 = new Label();
            listBox_carnames = new ListBox();
            menuStrip.SuspendLayout();
            tabControl_cfgdata.SuspendLayout();
            tabPage_normal.SuspendLayout();
            tabPage_grip.SuspendLayout();
            tabPage_speed.SuspendLayout();
            tabPage_handling.SuspendLayout();
            tabPage_others.SuspendLayout();
            tabPage_special.SuspendLayout();
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
            tabControl_cfgdata.Controls.Add(tabPage_speed);
            tabControl_cfgdata.Controls.Add(tabPage_handling);
            tabControl_cfgdata.Controls.Add(tabPage_others);
            tabControl_cfgdata.Controls.Add(tabPage_special);
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
            tabPage_grip.Controls.Add(label12);
            tabPage_grip.Controls.Add(textBox_grip_fr);
            tabPage_grip.Controls.Add(textBox_grip_data);
            tabPage_grip.Controls.Add(label11);
            tabPage_grip.Controls.Add(textBox_grip_b);
            tabPage_grip.Controls.Add(label10);
            resources.ApplyResources(tabPage_grip, "tabPage_grip");
            tabPage_grip.Name = "tabPage_grip";
            tabPage_grip.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // textBox_grip_fr
            // 
            resources.ApplyResources(textBox_grip_fr, "textBox_grip_fr");
            textBox_grip_fr.Name = "textBox_grip_fr";
            // 
            // textBox_grip_data
            // 
            resources.ApplyResources(textBox_grip_data, "textBox_grip_data");
            textBox_grip_data.Name = "textBox_grip_data";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // textBox_grip_b
            // 
            resources.ApplyResources(textBox_grip_b, "textBox_grip_b");
            textBox_grip_b.Name = "textBox_grip_b";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // tabPage_speed
            // 
            tabPage_speed.Controls.Add(label22);
            tabPage_speed.Controls.Add(textBox_max_turnangle);
            tabPage_speed.Controls.Add(label21);
            tabPage_speed.Controls.Add(label20);
            tabPage_speed.Controls.Add(label19);
            tabPage_speed.Controls.Add(textBox_abs);
            tabPage_speed.Controls.Add(textBox_brake_balance);
            tabPage_speed.Controls.Add(textBox_brake);
            tabPage_speed.Controls.Add(label18);
            tabPage_speed.Controls.Add(label17);
            tabPage_speed.Controls.Add(label16);
            tabPage_speed.Controls.Add(label15);
            tabPage_speed.Controls.Add(label14);
            tabPage_speed.Controls.Add(textBox_engine_type);
            tabPage_speed.Controls.Add(textBox_drive_form);
            tabPage_speed.Controls.Add(textBox_speedup_force);
            tabPage_speed.Controls.Add(textBox_speedup);
            tabPage_speed.Controls.Add(textBox_topspeed);
            tabPage_speed.Controls.Add(textBox_gear);
            tabPage_speed.Controls.Add(label13);
            resources.ApplyResources(tabPage_speed, "tabPage_speed");
            tabPage_speed.Name = "tabPage_speed";
            tabPage_speed.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            label22.Name = "label22";
            // 
            // textBox_max_turnangle
            // 
            resources.ApplyResources(textBox_max_turnangle, "textBox_max_turnangle");
            textBox_max_turnangle.Name = "textBox_max_turnangle";
            // 
            // label21
            // 
            resources.ApplyResources(label21, "label21");
            label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.Name = "label19";
            // 
            // textBox_abs
            // 
            resources.ApplyResources(textBox_abs, "textBox_abs");
            textBox_abs.Name = "textBox_abs";
            // 
            // textBox_brake_balance
            // 
            resources.ApplyResources(textBox_brake_balance, "textBox_brake_balance");
            textBox_brake_balance.Name = "textBox_brake_balance";
            // 
            // textBox_brake
            // 
            resources.ApplyResources(textBox_brake, "textBox_brake");
            textBox_brake.Name = "textBox_brake";
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // textBox_engine_type
            // 
            resources.ApplyResources(textBox_engine_type, "textBox_engine_type");
            textBox_engine_type.Name = "textBox_engine_type";
            // 
            // textBox_drive_form
            // 
            resources.ApplyResources(textBox_drive_form, "textBox_drive_form");
            textBox_drive_form.Name = "textBox_drive_form";
            // 
            // textBox_speedup_force
            // 
            resources.ApplyResources(textBox_speedup_force, "textBox_speedup_force");
            textBox_speedup_force.Name = "textBox_speedup_force";
            // 
            // textBox_speedup
            // 
            resources.ApplyResources(textBox_speedup, "textBox_speedup");
            textBox_speedup.Name = "textBox_speedup";
            // 
            // textBox_topspeed
            // 
            resources.ApplyResources(textBox_topspeed, "textBox_topspeed");
            textBox_topspeed.Name = "textBox_topspeed";
            // 
            // textBox_gear
            // 
            resources.ApplyResources(textBox_gear, "textBox_gear");
            textBox_gear.Name = "textBox_gear";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // tabPage_handling
            // 
            tabPage_handling.Controls.Add(label29);
            tabPage_handling.Controls.Add(label28);
            tabPage_handling.Controls.Add(label27);
            tabPage_handling.Controls.Add(textBox_hand_hard);
            tabPage_handling.Controls.Add(textBox_hand_balance);
            tabPage_handling.Controls.Add(textBox_hand_down);
            tabPage_handling.Controls.Add(label26);
            tabPage_handling.Controls.Add(label25);
            tabPage_handling.Controls.Add(label24);
            tabPage_handling.Controls.Add(textBox_hand_top);
            tabPage_handling.Controls.Add(textBox_hs_force);
            tabPage_handling.Controls.Add(textBox_hand_force);
            tabPage_handling.Controls.Add(textBox_hand_g);
            tabPage_handling.Controls.Add(label23);
            resources.ApplyResources(tabPage_handling, "tabPage_handling");
            tabPage_handling.Name = "tabPage_handling";
            tabPage_handling.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(label29, "label29");
            label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(label28, "label28");
            label28.Name = "label28";
            // 
            // label27
            // 
            resources.ApplyResources(label27, "label27");
            label27.Name = "label27";
            // 
            // textBox_hand_hard
            // 
            resources.ApplyResources(textBox_hand_hard, "textBox_hand_hard");
            textBox_hand_hard.Name = "textBox_hand_hard";
            // 
            // textBox_hand_balance
            // 
            resources.ApplyResources(textBox_hand_balance, "textBox_hand_balance");
            textBox_hand_balance.Name = "textBox_hand_balance";
            // 
            // textBox_hand_down
            // 
            resources.ApplyResources(textBox_hand_down, "textBox_hand_down");
            textBox_hand_down.Name = "textBox_hand_down";
            // 
            // label26
            // 
            resources.ApplyResources(label26, "label26");
            label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(label25, "label25");
            label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // textBox_hand_top
            // 
            resources.ApplyResources(textBox_hand_top, "textBox_hand_top");
            textBox_hand_top.Name = "textBox_hand_top";
            // 
            // textBox_hs_force
            // 
            resources.ApplyResources(textBox_hs_force, "textBox_hs_force");
            textBox_hs_force.Name = "textBox_hs_force";
            // 
            // textBox_hand_force
            // 
            resources.ApplyResources(textBox_hand_force, "textBox_hand_force");
            textBox_hand_force.Name = "textBox_hand_force";
            // 
            // textBox_hand_g
            // 
            resources.ApplyResources(textBox_hand_g, "textBox_hand_g");
            textBox_hand_g.Name = "textBox_hand_g";
            // 
            // label23
            // 
            resources.ApplyResources(label23, "label23");
            label23.Name = "label23";
            // 
            // tabPage_others
            // 
            tabPage_others.Controls.Add(label32);
            tabPage_others.Controls.Add(label31);
            tabPage_others.Controls.Add(textBox_price);
            tabPage_others.Controls.Add(textBox_damage);
            tabPage_others.Controls.Add(textBox_door);
            tabPage_others.Controls.Add(label30);
            resources.ApplyResources(tabPage_others, "tabPage_others");
            tabPage_others.Name = "tabPage_others";
            tabPage_others.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            resources.ApplyResources(label32, "label32");
            label32.Name = "label32";
            // 
            // label31
            // 
            resources.ApplyResources(label31, "label31");
            label31.Name = "label31";
            // 
            // textBox_price
            // 
            resources.ApplyResources(textBox_price, "textBox_price");
            textBox_price.Name = "textBox_price";
            // 
            // textBox_damage
            // 
            resources.ApplyResources(textBox_damage, "textBox_damage");
            textBox_damage.Name = "textBox_damage";
            // 
            // textBox_door
            // 
            resources.ApplyResources(textBox_door, "textBox_door");
            textBox_door.Name = "textBox_door";
            // 
            // label30
            // 
            resources.ApplyResources(label30, "label30");
            label30.Name = "label30";
            // 
            // tabPage_special
            // 
            tabPage_special.Controls.Add(textBox21);
            tabPage_special.Controls.Add(label33);
            resources.ApplyResources(tabPage_special, "tabPage_special");
            tabPage_special.Name = "tabPage_special";
            tabPage_special.UseVisualStyleBackColor = true;
            // 
            // textBox21
            // 
            resources.ApplyResources(textBox21, "textBox21");
            textBox21.Name = "textBox21";
            // 
            // label33
            // 
            resources.ApplyResources(label33, "label33");
            label33.Name = "label33";
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
            tabPage_grip.ResumeLayout(false);
            tabPage_grip.PerformLayout();
            tabPage_speed.ResumeLayout(false);
            tabPage_speed.PerformLayout();
            tabPage_handling.ResumeLayout(false);
            tabPage_handling.PerformLayout();
            tabPage_others.ResumeLayout(false);
            tabPage_others.PerformLayout();
            tabPage_special.ResumeLayout(false);
            tabPage_special.PerformLayout();
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
        private Label label12;
        private TextBox textBox_grip_fr;
        private TextBox textBox_grip_data;
        private Label label11;
        private TextBox textBox_grip_b;
        private Label label10;
        private TabPage tabPage_speed;
        private TextBox textBox_gear;
        private Label label13;
        private Label label22;
        private TextBox textBox_max_turnangle;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox textBox_abs;
        private TextBox textBox_brake_balance;
        private TextBox textBox_brake;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBox_engine_type;
        private TextBox textBox_drive_form;
        private TextBox textBox_speedup_force;
        private TextBox textBox_speedup;
        private TextBox textBox_topspeed;
        private TabPage tabPage_handling;
        private TextBox textBox_hand_g;
        private Label label23;
        private Label label29;
        private Label label28;
        private Label label27;
        private TextBox textBox_hand_hard;
        private TextBox textBox_hand_balance;
        private TextBox textBox_hand_down;
        private Label label26;
        private Label label25;
        private Label label24;
        private TextBox textBox_hand_top;
        private TextBox textBox_hs_force;
        private TextBox textBox_hand_force;
        private TabPage tabPage_others;
        private Label label32;
        private Label label31;
        private TextBox textBox_price;
        private TextBox textBox_damage;
        private TextBox textBox_door;
        private Label label30;
        private TabPage tabPage_special;
        private TextBox textBox21;
        private Label label33;
    }
}