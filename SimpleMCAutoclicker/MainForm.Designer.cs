namespace SimpleMCAutoclicker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label2 = new MaterialSkin.Controls.MaterialLabel();
            attackbtnbox = new MaterialSkin.Controls.MaterialComboBox();
            CPSTrackBar = new MaterialSkin.Controls.MaterialSlider();
            randomizeTrackBar = new MaterialSkin.Controls.MaterialSlider();
            activationBindButton = new MaterialSkin.Controls.MaterialButton();
            EnableSwitch = new MaterialSkin.Controls.MaterialSwitch();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Depth = 0;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(31, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MouseState = MaterialSkin.MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new Size(272, 57);
            label2.TabIndex = 1;
            label2.Text = "mouse attack button:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // attackbtnbox
            // 
            attackbtnbox.AutoResize = false;
            attackbtnbox.BackColor = Color.FromArgb(255, 255, 255);
            attackbtnbox.Depth = 0;
            attackbtnbox.DrawMode = DrawMode.OwnerDrawVariable;
            attackbtnbox.DropDownHeight = 174;
            attackbtnbox.DropDownStyle = ComboBoxStyle.DropDownList;
            attackbtnbox.DropDownWidth = 121;
            attackbtnbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attackbtnbox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            attackbtnbox.FormattingEnabled = true;
            attackbtnbox.IntegralHeight = false;
            attackbtnbox.ItemHeight = 43;
            attackbtnbox.Items.AddRange(new object[] { "Left", "Right" });
            attackbtnbox.Location = new Point(302, 91);
            attackbtnbox.Margin = new Padding(4, 3, 4, 3);
            attackbtnbox.MaxDropDownItems = 4;
            attackbtnbox.MouseState = MaterialSkin.MouseState.OUT;
            attackbtnbox.Name = "attackbtnbox";
            attackbtnbox.Size = new Size(135, 49);
            attackbtnbox.StartIndex = 0;
            attackbtnbox.TabIndex = 2;
            // 
            // CPSTrackBar
            // 
            CPSTrackBar.Depth = 0;
            CPSTrackBar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CPSTrackBar.Location = new Point(35, 210);
            CPSTrackBar.Margin = new Padding(4, 3, 4, 3);
            CPSTrackBar.MouseState = MaterialSkin.MouseState.HOVER;
            CPSTrackBar.Name = "CPSTrackBar";
            CPSTrackBar.RangeMax = 40;
            CPSTrackBar.RangeMin = 5;
            CPSTrackBar.Size = new Size(402, 40);
            CPSTrackBar.TabIndex = 6;
            CPSTrackBar.Text = "CPS";
            CPSTrackBar.Value = 10;
            CPSTrackBar.onValueChanged += CPSTrackBar_onValueChanged;
            // 
            // randomizeTrackBar
            // 
            randomizeTrackBar.Depth = 0;
            randomizeTrackBar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            randomizeTrackBar.Location = new Point(35, 263);
            randomizeTrackBar.Margin = new Padding(4, 3, 4, 3);
            randomizeTrackBar.MouseState = MaterialSkin.MouseState.HOVER;
            randomizeTrackBar.Name = "randomizeTrackBar";
            randomizeTrackBar.RangeMax = 10;
            randomizeTrackBar.Size = new Size(402, 40);
            randomizeTrackBar.TabIndex = 7;
            randomizeTrackBar.Text = "Randomize   ";
            randomizeTrackBar.Value = 0;
            randomizeTrackBar.onValueChanged += randomizeTrackBar_onValueChanged;
            // 
            // activationBindButton
            // 
            activationBindButton.AutoSize = false;
            activationBindButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            activationBindButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            activationBindButton.Depth = 0;
            activationBindButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activationBindButton.HighEmphasis = true;
            activationBindButton.Icon = null;
            activationBindButton.Location = new Point(35, 158);
            activationBindButton.Margin = new Padding(5, 7, 5, 7);
            activationBindButton.MouseState = MaterialSkin.MouseState.HOVER;
            activationBindButton.Name = "activationBindButton";
            activationBindButton.NoAccentTextColor = Color.Empty;
            activationBindButton.Size = new Size(402, 42);
            activationBindButton.TabIndex = 14;
            activationBindButton.Text = "Bind Activation Key";
            activationBindButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            activationBindButton.UseAccentColor = false;
            activationBindButton.UseVisualStyleBackColor = true;
            activationBindButton.Click += ActivationBindButton_Click;
            // 
            // EnableSwitch
            // 
            EnableSwitch.AutoSize = true;
            EnableSwitch.Depth = 0;
            EnableSwitch.Location = new Point(35, 313);
            EnableSwitch.Margin = new Padding(0);
            EnableSwitch.MouseLocation = new Point(-1, -1);
            EnableSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            EnableSwitch.Name = "EnableSwitch";
            EnableSwitch.Ripple = true;
            EnableSwitch.Size = new Size(186, 37);
            EnableSwitch.TabIndex = 15;
            EnableSwitch.Text = "enable autoclicker";
            EnableSwitch.UseVisualStyleBackColor = true;
            EnableSwitch.CheckedChanged += EnableSwitch_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 363);
            Controls.Add(EnableSwitch);
            Controls.Add(activationBindButton);
            Controls.Add(randomizeTrackBar);
            Controls.Add(CPSTrackBar);
            Controls.Add(attackbtnbox);
            Controls.Add(label2);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(467, 363);
            MinimumSize = new Size(467, 363);
            Name = "MainForm";
            Padding = new Padding(4, 74, 4, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple MC Autoclicker";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialComboBox attackbtnbox;
        private MaterialSkin.Controls.MaterialSlider CPSTrackBar;
        private MaterialSkin.Controls.MaterialSlider randomizeTrackBar;
        private MaterialSkin.Controls.MaterialButton activationBindButton;
        private MaterialSkin.Controls.MaterialSwitch EnableSwitch;
    }
}
