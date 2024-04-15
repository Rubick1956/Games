namespace Gamecenter
{
  partial class Mypr
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mypr));
            this.Win = new System.Windows.Forms.Label();
            this.Sss = new System.Windows.Forms.Panel();
            this.Rb15 = new System.Windows.Forms.RadioButton();
            this.Rb48 = new System.Windows.Forms.RadioButton();
            this.Rbkn = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Label();
            this.Polygon = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Size = new System.Windows.Forms.NumericUpDown();
            this.Saved = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Forw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            this.SuspendLayout();
            // 
            // Win
            // 
            this.Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Win.BackColor = System.Drawing.SystemColors.Control;
            this.Win.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win.Location = new System.Drawing.Point(0, 80);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(494, 75);
            this.Win.TabIndex = 17;
            this.Win.Text = "You Win";
            this.Win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Win.Visible = false;
            // 
            // Sss
            // 
            this.Sss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sss.BackgroundImage")));
            this.Sss.ForeColor = System.Drawing.Color.White;
            this.Sss.Location = new System.Drawing.Point(170, 174);
            this.Sss.Name = "Sss";
            this.Sss.Size = new System.Drawing.Size(162, 162);
            this.Sss.TabIndex = 19;
            this.Sss.Visible = false;
            // 
            // Rb15
            // 
            this.Rb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Rb15.Location = new System.Drawing.Point(191, 252);
            this.Rb15.Name = "Rb15";
            this.Rb15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rb15.Size = new System.Drawing.Size(125, 27);
            this.Rb15.TabIndex = 23;
            this.Rb15.TabStop = true;
            this.Rb15.Text = "15";
            this.Rb15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rb15.UseVisualStyleBackColor = true;
            // 
            // Rb48
            // 
            this.Rb48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Rb48.Location = new System.Drawing.Point(191, 218);
            this.Rb48.Name = "Rb48";
            this.Rb48.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rb48.Size = new System.Drawing.Size(125, 27);
            this.Rb48.TabIndex = 22;
            this.Rb48.TabStop = true;
            this.Rb48.Text = "2048";
            this.Rb48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rb48.UseVisualStyleBackColor = true;
            this.Rb48.CheckedChanged += new System.EventHandler(this.Rb48_CheckedChanged);
            // 
            // Rbkn
            // 
            this.Rbkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Rbkn.Location = new System.Drawing.Point(191, 184);
            this.Rbkn.Name = "Rbkn";
            this.Rbkn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rbkn.Size = new System.Drawing.Size(125, 27);
            this.Rbkn.TabIndex = 21;
            this.Rbkn.TabStop = true;
            this.Rbkn.Text = "X and O";
            this.Rbkn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rbkn.UseVisualStyleBackColor = true;
            this.Rbkn.CheckedChanged += new System.EventHandler(this.Rbkn_CheckedChanged);
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(170, 337);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(162, 104);
            this.Start.TabIndex = 16;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Game
            // 
            this.Game.AutoSize = true;
            this.Game.BackColor = System.Drawing.SystemColors.Control;
            this.Game.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Game.Location = new System.Drawing.Point(50, 38);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(402, 75);
            this.Game.TabIndex = 21;
            this.Game.Text = "Choose a game";
            this.Game.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Polygon
            // 
            this.Polygon.AutoSize = true;
            this.Polygon.BackColor = System.Drawing.SystemColors.Control;
            this.Polygon.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polygon.Location = new System.Drawing.Point(339, 184);
            this.Polygon.Name = "Polygon";
            this.Polygon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Polygon.Size = new System.Drawing.Size(118, 23);
            this.Polygon.TabIndex = 24;
            this.Polygon.Text = "polygon size";
            this.Polygon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Polygon.Visible = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(431, 457);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(63, 38);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(368, 222);
            this.Size.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Size.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(49, 20);
            this.Size.TabIndex = 25;
            this.Size.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Size.Visible = false;
            this.Size.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // Saved
            // 
            this.Saved.AutoSize = true;
            this.Saved.BackColor = System.Drawing.Color.White;
            this.Saved.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saved.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Saved.Location = new System.Drawing.Point(93, 216);
            this.Saved.Margin = new System.Windows.Forms.Padding(0);
            this.Saved.Name = "Saved";
            this.Saved.Size = new System.Drawing.Size(74, 32);
            this.Saved.TabIndex = 50;
            this.Saved.Text = "Saved";
            this.Saved.UseVisualStyleBackColor = false;
            this.Saved.Visible = false;
            this.Saved.Click += new System.EventHandler(this.Saved_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.CausesValidation = false;
            this.Save.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save.Location = new System.Drawing.Point(461, 463);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(33, 32);
            this.Save.TabIndex = 49;
            this.Save.Text = "S";
            this.Save.UseMnemonic = false;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.Location = new System.Drawing.Point(450, 479);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(48, 16);
            this.Help.TabIndex = 48;
            this.Help.Text = "click H";
            this.Help.Visible = false;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back.CausesValidation = false;
            this.Back.Font = new System.Drawing.Font("MT Extra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(0, 463);
            this.Back.Margin = new System.Windows.Forms.Padding(0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(34, 31);
            this.Back.TabIndex = 18;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Back_KeyUp);
            this.Back.Leave += new System.EventHandler(this.Back_Leave);
            // 
            // Forw
            // 
            this.Forw.AutoSize = true;
            this.Forw.BackColor = System.Drawing.SystemColors.Control;
            this.Forw.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forw.Location = new System.Drawing.Point(355, 155);
            this.Forw.Name = "Forw";
            this.Forw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Forw.Size = new System.Drawing.Size(88, 23);
            this.Forw.TabIndex = 51;
            this.Forw.Text = "3 for win";
            this.Forw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Forw.Visible = false;
            // 
            // Mypr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.ControlBox = false;
            this.Controls.Add(this.Forw);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Saved);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Rbkn);
            this.Controls.Add(this.Rb48);
            this.Controls.Add(this.Rb15);
            this.Controls.Add(this.Sss);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-7, -2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mypr";
            this.Text = "THEBESTGAMES";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mypr_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Mypr_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Win;
    private System.Windows.Forms.Panel Sss;
    private System.Windows.Forms.RadioButton Rb15;
    private System.Windows.Forms.RadioButton Rb48;
    private System.Windows.Forms.RadioButton Rbkn;
    private System.Windows.Forms.Button Start;
    private System.Windows.Forms.Label Game;
    private System.Windows.Forms.Label Polygon;
    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.NumericUpDown Size;
    private System.Windows.Forms.Button Saved;
    private System.Windows.Forms.Label Help;
    private System.Windows.Forms.Button Back;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Label Forw;
  }
}