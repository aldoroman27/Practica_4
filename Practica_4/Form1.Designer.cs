namespace Practica_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.analizarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRACTICA 4";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Location = new System.Drawing.Point(178, 113);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(255, 20);
            this.expressionTextBox.TabIndex = 1;
            // 
            // analizarButton
            // 
            this.analizarButton.BackColor = System.Drawing.Color.LimeGreen;
            this.analizarButton.Location = new System.Drawing.Point(198, 159);
            this.analizarButton.Name = "analizarButton";
            this.analizarButton.Size = new System.Drawing.Size(75, 23);
            this.analizarButton.TabIndex = 2;
            this.analizarButton.Text = "Analizar";
            this.analizarButton.UseVisualStyleBackColor = false;
            this.analizarButton.Click += new System.EventHandler(this.analizarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.BackColor = System.Drawing.Color.Red;
            this.limpiarButton.Location = new System.Drawing.Point(323, 160);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 22);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = false;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese una expresión:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.analizarButton);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRACTICA 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expressionTextBox;
        private System.Windows.Forms.Button analizarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label label2;
    }
}

