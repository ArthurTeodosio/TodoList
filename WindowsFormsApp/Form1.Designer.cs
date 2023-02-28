namespace WindowsFormsApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Data = new System.Windows.Forms.Label();
            this.Tarefa = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Coloque a data");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(29, 30);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(36, 16);
            this.Data.TabIndex = 1;
            this.Data.Text = "Data";
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Tarefa
            // 
            this.Tarefa.AutoSize = true;
            this.Tarefa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarefa.Location = new System.Drawing.Point(29, 79);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Size = new System.Drawing.Size(47, 16);
            this.Tarefa.TabIndex = 2;
            this.Tarefa.Text = "Tarefa";
            this.Tarefa.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(96, 79);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(244, 20);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(373, 52);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 29);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(32, 140);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(416, 212);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(373, 373);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 33);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 422);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Tarefa);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Tarefa;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

