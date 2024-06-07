namespace FestasInfantis.WinApp.ModuloItem
{
    partial class ListagemItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listItens = new ListBox();
            SuspendLayout();
            // 
            // listItens
            // 
            listItens.Dock = DockStyle.Fill;
            listItens.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 20;
            listItens.Location = new Point(0, 0);
            listItens.Name = "listItens";
            listItens.Size = new Size(545, 287);
            listItens.TabIndex = 0;
            // 
            // ListagemItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listItens);
            Name = "ListagemItemControl";
            Size = new Size(545, 287);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listItens;
    }
}
