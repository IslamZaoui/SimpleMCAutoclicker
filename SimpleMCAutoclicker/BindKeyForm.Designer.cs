namespace SimpleMCAutoclicker
{
    partial class BindKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindKeyForm));
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(96, 26);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(109, 21);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "press the key...";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            materialLabel1.MouseDown += BindKeyForm_MouseDown;
            // 
            // BindKeyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 75);
            ControlBox = false;
            Controls.Add(materialLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BindKeyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BindKeyForm";
            Deactivate += BindKeyForm_Deactivate;
            Shown += BindKeyForm_Shown;
            KeyDown += BindKeyForm_KeyDown;
            MouseDown += BindKeyForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}