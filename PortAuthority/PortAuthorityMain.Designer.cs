namespace PortAuthority
{
    partial class PortAuthorityMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortAuthorityMain));
            this.CurrentVersionLabel = new System.Windows.Forms.Label();
            this.CurrentVersionText = new System.Windows.Forms.TextBox();
            this.NewestVersionLabel = new System.Windows.Forms.LinkLabel();
            this.NewestVersionText = new System.Windows.Forms.TextBox();
            this.InterfaceLabel = new System.Windows.Forms.Label();
            this.InterfaceBox = new System.Windows.Forms.ComboBox();
            this.MacLabel = new System.Windows.Forms.Label();
            this.MacText = new System.Windows.Forms.TextBox();
            this.IpLabel = new System.Windows.Forms.Label();
            this.IpText = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.MsgText = new System.Windows.Forms.TextBox();
            this.JackText = new System.Windows.Forms.TextBox();
            this.RoomText = new System.Windows.Forms.TextBox();
            this.JackLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomJackGroup = new System.Windows.Forms.GroupBox();
            this.MapButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.RoomJackGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentVersionLabel
            // 
            this.CurrentVersionLabel.AutoSize = true;
            this.CurrentVersionLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentVersionLabel.Name = "CurrentVersionLabel";
            this.CurrentVersionLabel.Size = new System.Drawing.Size(79, 13);
            this.CurrentVersionLabel.TabIndex = 0;
            this.CurrentVersionLabel.Text = "Current Version";
            // 
            // CurrentVersionText
            // 
            this.CurrentVersionText.Location = new System.Drawing.Point(15, 26);
            this.CurrentVersionText.Name = "CurrentVersionText";
            this.CurrentVersionText.ReadOnly = true;
            this.CurrentVersionText.Size = new System.Drawing.Size(100, 20);
            this.CurrentVersionText.TabIndex = 1;
            this.CurrentVersionText.TextChanged += new System.EventHandler(this.CurrentVersionText_TextChanged);
            // 
            // NewestVersionLabel
            // 
            this.NewestVersionLabel.AutoSize = true;
            this.NewestVersionLabel.Location = new System.Drawing.Point(12, 54);
            this.NewestVersionLabel.Name = "NewestVersionLabel";
            this.NewestVersionLabel.Size = new System.Drawing.Size(81, 13);
            this.NewestVersionLabel.TabIndex = 2;
            this.NewestVersionLabel.TabStop = true;
            this.NewestVersionLabel.Text = "Newest Version";
            this.NewestVersionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewestVersionLabel_LinkClicked);
            // 
            // NewestVersionText
            // 
            this.NewestVersionText.Location = new System.Drawing.Point(12, 70);
            this.NewestVersionText.Name = "NewestVersionText";
            this.NewestVersionText.ReadOnly = true;
            this.NewestVersionText.Size = new System.Drawing.Size(100, 20);
            this.NewestVersionText.TabIndex = 3;
            // 
            // InterfaceLabel
            // 
            this.InterfaceLabel.AutoSize = true;
            this.InterfaceLabel.Location = new System.Drawing.Point(180, 9);
            this.InterfaceLabel.Name = "InterfaceLabel";
            this.InterfaceLabel.Size = new System.Drawing.Size(97, 13);
            this.InterfaceLabel.TabIndex = 4;
            this.InterfaceLabel.Text = "Select an Interface";
            // 
            // InterfaceBox
            // 
            this.InterfaceBox.DisplayMember = "Description";
            this.InterfaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterfaceBox.FormattingEnabled = true;
            this.InterfaceBox.Location = new System.Drawing.Point(183, 26);
            this.InterfaceBox.Name = "InterfaceBox";
            this.InterfaceBox.Size = new System.Drawing.Size(276, 21);
            this.InterfaceBox.TabIndex = 5;
            this.InterfaceBox.SelectedIndexChanged += new System.EventHandler(this.InterfaceBox_SelectedIndexChanged);
            // 
            // MacLabel
            // 
            this.MacLabel.AutoSize = true;
            this.MacLabel.Location = new System.Drawing.Point(183, 52);
            this.MacLabel.Name = "MacLabel";
            this.MacLabel.Size = new System.Drawing.Size(71, 13);
            this.MacLabel.TabIndex = 6;
            this.MacLabel.Text = "MAC Address";
            // 
            // MacText
            // 
            this.MacText.Location = new System.Drawing.Point(186, 69);
            this.MacText.Name = "MacText";
            this.MacText.ReadOnly = true;
            this.MacText.Size = new System.Drawing.Size(126, 20);
            this.MacText.TabIndex = 7;
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(332, 53);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(58, 13);
            this.IpLabel.TabIndex = 8;
            this.IpLabel.Text = "IP Address";
            // 
            // IpText
            // 
            this.IpText.Location = new System.Drawing.Point(335, 69);
            this.IpText.Name = "IpText";
            this.IpText.ReadOnly = true;
            this.IpText.Size = new System.Drawing.Size(124, 20);
            this.IpText.TabIndex = 9;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(12, 133);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 10;
            this.UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 174);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 11;
            this.PassLabel.Text = "Password";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(81, 130);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 12;
            this.UserText.Text = "Username";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(81, 171);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(100, 20);
            this.PassText.TabIndex = 13;
            this.PassText.Text = "Password";
            this.PassText.UseSystemPasswordChar = true;
            // 
            // MsgText
            // 
            this.MsgText.Enabled = false;
            this.MsgText.Location = new System.Drawing.Point(12, 240);
            this.MsgText.Name = "MsgText";
            this.MsgText.ReadOnly = true;
            this.MsgText.Size = new System.Drawing.Size(340, 20);
            this.MsgText.TabIndex = 14;
            // 
            // JackText
            // 
            this.JackText.Location = new System.Drawing.Point(157, 60);
            this.JackText.Name = "JackText";
            this.JackText.Size = new System.Drawing.Size(62, 20);
            this.JackText.TabIndex = 18;
            // 
            // RoomText
            // 
            this.RoomText.Location = new System.Drawing.Point(44, 60);
            this.RoomText.Name = "RoomText";
            this.RoomText.Size = new System.Drawing.Size(61, 20);
            this.RoomText.TabIndex = 17;
            // 
            // JackLabel
            // 
            this.JackLabel.AutoSize = true;
            this.JackLabel.Location = new System.Drawing.Point(173, 38);
            this.JackLabel.Name = "JackLabel";
            this.JackLabel.Size = new System.Drawing.Size(30, 13);
            this.JackLabel.TabIndex = 16;
            this.JackLabel.Text = "Jack";
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(55, 38);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(35, 13);
            this.RoomLabel.TabIndex = 15;
            this.RoomLabel.Text = "Room";
            // 
            // RoomJackGroup
            // 
            this.RoomJackGroup.Controls.Add(this.MapButton);
            this.RoomJackGroup.Controls.Add(this.JackText);
            this.RoomJackGroup.Controls.Add(this.RoomText);
            this.RoomJackGroup.Controls.Add(this.JackLabel);
            this.RoomJackGroup.Controls.Add(this.RoomLabel);
            this.RoomJackGroup.Location = new System.Drawing.Point(187, 95);
            this.RoomJackGroup.Name = "RoomJackGroup";
            this.RoomJackGroup.Size = new System.Drawing.Size(271, 136);
            this.RoomJackGroup.TabIndex = 19;
            this.RoomJackGroup.TabStop = false;
            this.RoomJackGroup.Text = "Room/Jack";
            this.RoomJackGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MapButton
            // 
            this.MapButton.Enabled = false;
            this.MapButton.Location = new System.Drawing.Point(102, 95);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(75, 23);
            this.MapButton.TabIndex = 19;
            this.MapButton.Text = "Map";
            this.MapButton.UseVisualStyleBackColor = true;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(358, 240);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 20);
            this.ProgressBar.TabIndex = 20;
            // 
            // PortAuthorityMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.RoomJackGroup);
            this.Controls.Add(this.MsgText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.IpText);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.MacText);
            this.Controls.Add(this.MacLabel);
            this.Controls.Add(this.InterfaceBox);
            this.Controls.Add(this.InterfaceLabel);
            this.Controls.Add(this.NewestVersionText);
            this.Controls.Add(this.NewestVersionLabel);
            this.Controls.Add(this.CurrentVersionText);
            this.Controls.Add(this.CurrentVersionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortAuthorityMain";
            this.Text = "PortAuthority";
            this.Load += new System.EventHandler(this.PortAuthorityMain_Load);
            this.RoomJackGroup.ResumeLayout(false);
            this.RoomJackGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentVersionLabel;
        private System.Windows.Forms.TextBox CurrentVersionText;
        private System.Windows.Forms.LinkLabel NewestVersionLabel;
        private System.Windows.Forms.TextBox NewestVersionText;
        private System.Windows.Forms.Label InterfaceLabel;
        private System.Windows.Forms.ComboBox InterfaceBox;
        private System.Windows.Forms.Label MacLabel;
        private System.Windows.Forms.TextBox MacText;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.TextBox IpText;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox MsgText;
        private System.Windows.Forms.TextBox JackText;
        private System.Windows.Forms.TextBox RoomText;
        private System.Windows.Forms.Label JackLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.GroupBox RoomJackGroup;
        private System.Windows.Forms.Button MapButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

