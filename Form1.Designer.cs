namespace SO3
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
            label1 = new Label();
            dodaj_alternativo = new Button();
            button1 = new Button();
            parametri_table = new DataGridView();
            Alternative_name = new TextBox();
            errorText1 = new Label();
            ((System.ComponentModel.ISupportInitialize)parametri_table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(260, 55);
            label1.TabIndex = 0;
            label1.Text = "K-T Metoda";
            // 
            // dodaj_alternativo
            // 
            dodaj_alternativo.Location = new Point(74, 162);
            dodaj_alternativo.Name = "dodaj_alternativo";
            dodaj_alternativo.Size = new Size(75, 39);
            dodaj_alternativo.TabIndex = 2;
            dodaj_alternativo.Text = "Dodaj Alternativo";
            dodaj_alternativo.UseVisualStyleBackColor = true;
            dodaj_alternativo.Click += dodaj_alternativo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(683, 376);
            button1.Name = "button1";
            button1.Size = new Size(105, 62);
            button1.TabIndex = 3;
            button1.Text = "Izračunaj vrednost alternativ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // parametri_table
            // 
            parametri_table.BackgroundColor = SystemColors.Control;
            parametri_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametri_table.GridColor = SystemColors.ControlDarkDark;
            parametri_table.Location = new Point(245, 101);
            parametri_table.Name = "parametri_table";
            parametri_table.Size = new Size(543, 257);
            parametri_table.TabIndex = 4;
            // 
            // Alternative_name
            // 
            Alternative_name.Location = new Point(12, 133);
            Alternative_name.Name = "Alternative_name";
            Alternative_name.Size = new Size(205, 23);
            Alternative_name.TabIndex = 5;
            // 
            // errorText1
            // 
            errorText1.AutoSize = true;
            errorText1.ForeColor = Color.IndianRed;
            errorText1.Location = new Point(16, 115);
            errorText1.Name = "errorText1";
            errorText1.Size = new Size(223, 15);
            errorText1.TabIndex = 6;
            errorText1.Text = "Izpolnite obrazec za dodajanje alternative";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorText1);
            Controls.Add(Alternative_name);
            Controls.Add(parametri_table);
            Controls.Add(button1);
            Controls.Add(dodaj_alternativo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)parametri_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button dodaj_alternativo;
        private Button button1;
        private DataGridView parametri_table;
        private TextBox Alternative_name;
        private Label errorText1;
    }
}
