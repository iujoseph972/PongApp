namespace PongApp
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.trollFacedCharacter = new System.Windows.Forms.PictureBox();
            this.noCharacter = new System.Windows.Forms.PictureBox();
            this.mogCharacter = new System.Windows.Forms.PictureBox();
            this.foreverAloneCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trollFacedCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAloneCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Cascadia Mono", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(66, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(686, 83);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Click A Character";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // trollFacedCharacter
            // 
            this.trollFacedCharacter.Image = global::PongApp.Properties.Resources.Pong_Character_Troll_Face;
            this.trollFacedCharacter.Location = new System.Drawing.Point(25, 161);
            this.trollFacedCharacter.Name = "trollFacedCharacter";
            this.trollFacedCharacter.Size = new System.Drawing.Size(160, 160);
            this.trollFacedCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trollFacedCharacter.TabIndex = 1;
            this.trollFacedCharacter.TabStop = false;
            this.trollFacedCharacter.Click += new System.EventHandler(this.trollFacedCharacter_Click);
            // 
            // noCharacter
            // 
            this.noCharacter.Image = global::PongApp.Properties.Resources.Pong_Character_No;
            this.noCharacter.Location = new System.Drawing.Point(432, 161);
            this.noCharacter.Name = "noCharacter";
            this.noCharacter.Size = new System.Drawing.Size(160, 160);
            this.noCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noCharacter.TabIndex = 2;
            this.noCharacter.TabStop = false;
            this.noCharacter.Click += new System.EventHandler(this.noCharacter_Click);
            // 
            // mogCharacter
            // 
            this.mogCharacter.Image = global::PongApp.Properties.Resources.Pong_Character_MOG;
            this.mogCharacter.Location = new System.Drawing.Point(231, 161);
            this.mogCharacter.Name = "mogCharacter";
            this.mogCharacter.Size = new System.Drawing.Size(160, 160);
            this.mogCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mogCharacter.TabIndex = 3;
            this.mogCharacter.TabStop = false;
            this.mogCharacter.Click += new System.EventHandler(this.mogCharacter_Click);
            // 
            // foreverAloneCharacter
            // 
            this.foreverAloneCharacter.Image = global::PongApp.Properties.Resources.Pong_Character_ForeverAlone;
            this.foreverAloneCharacter.Location = new System.Drawing.Point(628, 161);
            this.foreverAloneCharacter.Name = "foreverAloneCharacter";
            this.foreverAloneCharacter.Size = new System.Drawing.Size(160, 160);
            this.foreverAloneCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foreverAloneCharacter.TabIndex = 4;
            this.foreverAloneCharacter.TabStop = false;
            this.foreverAloneCharacter.Click += new System.EventHandler(this.foreverAloneCharacter_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreverAloneCharacter);
            this.Controls.Add(this.mogCharacter);
            this.Controls.Add(this.noCharacter);
            this.Controls.Add(this.trollFacedCharacter);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CharacterForm";
            this.Text = "Choose a Character";
            ((System.ComponentModel.ISupportInitialize)(this.trollFacedCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAloneCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label titleLabel;
        private PictureBox trollFacedCharacter;
        private PictureBox noCharacter;
        private PictureBox mogCharacter;
        private PictureBox foreverAloneCharacter;
    }
}