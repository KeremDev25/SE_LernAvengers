namespace FirstExercise
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtbx_prompt = new TextBox();
            txtbx_Name = new TextBox();
            comboBx_ChooseAI = new ComboBox();
            rbtn_Intern = new RadioButton();
            rbtn_Mockup = new RadioButton();
            rbtn_Final = new RadioButton();
            btn_Accept = new Button();
            checkBx_ChangedAI = new CheckBox();
            dateTimePicker = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtbx_prompt, 0, 1);
            tableLayoutPanel1.Controls.Add(txtbx_Name, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBx_ChooseAI, 0, 2);
            tableLayoutPanel1.Controls.Add(rbtn_Intern, 0, 3);
            tableLayoutPanel1.Controls.Add(rbtn_Mockup, 0, 4);
            tableLayoutPanel1.Controls.Add(rbtn_Final, 0, 5);
            tableLayoutPanel1.Controls.Add(btn_Accept, 1, 6);
            tableLayoutPanel1.Controls.Add(checkBx_ChangedAI, 1, 4);
            tableLayoutPanel1.Controls.Add(dateTimePicker, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 16F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.524862F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0994473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0994473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.392265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.392265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.392265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0994453F));
            tableLayoutPanel1.Size = new Size(1401, 790);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtbx_prompt
            // 
            tableLayoutPanel1.SetColumnSpan(txtbx_prompt, 2);
            txtbx_prompt.Dock = DockStyle.Fill;
            txtbx_prompt.Location = new Point(3, 46);
            txtbx_prompt.Multiline = true;
            txtbx_prompt.Name = "txtbx_prompt";
            txtbx_prompt.Size = new Size(1395, 168);
            txtbx_prompt.TabIndex = 1;
            txtbx_prompt.Text = "Prompt des KI-Erzeugnisses";
            // 
            // txtbx_Name
            // 
            txtbx_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtbx_Name, 2);
            txtbx_Name.Location = new Point(3, 3);
            txtbx_Name.Name = "txtbx_Name";
            txtbx_Name.Size = new Size(1395, 36);
            txtbx_Name.TabIndex = 0;
            txtbx_Name.Text = "Textbox für Name des KI-Erzeugnisses";
            // 
            // comboBx_ChooseAI
            // 
            comboBx_ChooseAI.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBx_ChooseAI.FormattingEnabled = true;
            comboBx_ChooseAI.Location = new Point(3, 292);
            comboBx_ChooseAI.Margin = new Padding(3, 3, 30, 3);
            comboBx_ChooseAI.Name = "comboBx_ChooseAI";
            comboBx_ChooseAI.Size = new Size(667, 38);
            comboBx_ChooseAI.TabIndex = 2;
            comboBx_ChooseAI.Text = "Genutzte KI auswählen";
            // 
            // rbtn_Intern
            // 
            rbtn_Intern.AutoSize = true;
            rbtn_Intern.Location = new Point(3, 394);
            rbtn_Intern.Name = "rbtn_Intern";
            rbtn_Intern.Size = new Size(180, 34);
            rbtn_Intern.TabIndex = 3;
            rbtn_Intern.TabStop = true;
            rbtn_Intern.Text = "Interne Zwecke";
            rbtn_Intern.UseVisualStyleBackColor = true;
            // 
            // rbtn_Mockup
            // 
            rbtn_Mockup.AutoSize = true;
            rbtn_Mockup.Location = new Point(3, 468);
            rbtn_Mockup.Name = "rbtn_Mockup";
            rbtn_Mockup.Size = new Size(110, 34);
            rbtn_Mockup.TabIndex = 4;
            rbtn_Mockup.TabStop = true;
            rbtn_Mockup.Text = "Mockup";
            rbtn_Mockup.UseVisualStyleBackColor = true;
            // 
            // rbtn_Final
            // 
            rbtn_Final.AutoSize = true;
            rbtn_Final.Location = new Point(3, 542);
            rbtn_Final.Name = "rbtn_Final";
            rbtn_Final.Size = new Size(153, 34);
            rbtn_Final.TabIndex = 5;
            rbtn_Final.TabStop = true;
            rbtn_Final.Text = "Finales Werk";
            rbtn_Final.UseVisualStyleBackColor = true;
            // 
            // btn_Accept
            // 
            btn_Accept.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Accept.Location = new Point(750, 663);
            btn_Accept.Margin = new Padding(50);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(601, 77);
            btn_Accept.TabIndex = 6;
            btn_Accept.Text = "Übernehmen";
            btn_Accept.UseVisualStyleBackColor = true;
            btn_Accept.Click += btn_Accept_Click;
            // 
            // checkBx_ChangedAI
            // 
            checkBx_ChangedAI.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBx_ChangedAI.AutoSize = true;
            checkBx_ChangedAI.Location = new Point(703, 485);
            checkBx_ChangedAI.Name = "checkBx_ChangedAI";
            checkBx_ChangedAI.Size = new Size(695, 34);
            checkBx_ChangedAI.TabIndex = 7;
            checkBx_ChangedAI.Text = "Wurde nachbearbeitet";
            checkBx_ChangedAI.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(730, 286);
            dateTimePicker.Margin = new Padding(30);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(641, 36);
            dateTimePicker.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 790);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "LernAvengersSuperDuperAnwendung";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtbx_Name;
        private TextBox txtbx_prompt;
        private ComboBox comboBx_ChooseAI;
        private RadioButton rbtn_Intern;
        private RadioButton rbtn_Mockup;
        private RadioButton rbtn_Final;
        private Button btn_Accept;
        private CheckBox checkBx_ChangedAI;
        private DateTimePicker dateTimePicker;
    }
}
