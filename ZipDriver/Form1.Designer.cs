
namespace ZipDriver
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Folder = new System.Windows.Forms.TextBox();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.btn_ZipFolder = new System.Windows.Forms.Button();
            this.btn_ZipFile = new System.Windows.Forms.Button();
            this.btn_FileName = new System.Windows.Forms.Button();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasta:";
            // 
            // txt_Folder
            // 
            this.txt_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Folder.Location = new System.Drawing.Point(97, 24);
            this.txt_Folder.Name = "txt_Folder";
            this.txt_Folder.Size = new System.Drawing.Size(410, 28);
            this.txt_Folder.TabIndex = 1;
            // 
            // btn_Folder
            // 
            this.btn_Folder.Location = new System.Drawing.Point(513, 24);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(48, 28);
            this.btn_Folder.TabIndex = 2;
            this.btn_Folder.Text = "...";
            this.btn_Folder.UseVisualStyleBackColor = true;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_Click);
            // 
            // btn_ZipFolder
            // 
            this.btn_ZipFolder.Location = new System.Drawing.Point(567, 24);
            this.btn_ZipFolder.Name = "btn_ZipFolder";
            this.btn_ZipFolder.Size = new System.Drawing.Size(112, 28);
            this.btn_ZipFolder.TabIndex = 3;
            this.btn_ZipFolder.Text = "Zip";
            this.btn_ZipFolder.UseVisualStyleBackColor = true;
            this.btn_ZipFolder.Click += new System.EventHandler(this.btn_ZipFolder_Click);
            // 
            // btn_ZipFile
            // 
            this.btn_ZipFile.Location = new System.Drawing.Point(567, 58);
            this.btn_ZipFile.Name = "btn_ZipFile";
            this.btn_ZipFile.Size = new System.Drawing.Size(112, 28);
            this.btn_ZipFile.TabIndex = 7;
            this.btn_ZipFile.Text = "Zip";
            this.btn_ZipFile.UseVisualStyleBackColor = true;
            this.btn_ZipFile.Click += new System.EventHandler(this.btn_ZipFile_Click);
            // 
            // btn_FileName
            // 
            this.btn_FileName.Location = new System.Drawing.Point(513, 58);
            this.btn_FileName.Name = "btn_FileName";
            this.btn_FileName.Size = new System.Drawing.Size(48, 28);
            this.btn_FileName.TabIndex = 6;
            this.btn_FileName.Text = "...";
            this.btn_FileName.UseVisualStyleBackColor = true;
            this.btn_FileName.Click += new System.EventHandler(this.btn_FileName_Click);
            // 
            // txt_FileName
            // 
            this.txt_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FileName.Location = new System.Drawing.Point(97, 58);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(410, 28);
            this.txt_FileName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquivo:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(97, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(410, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(547, 128);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(132, 45);
            this.btn_Fechar.TabIndex = 9;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "@miller_vasco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(692, 185);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_ZipFile);
            this.Controls.Add(this.btn_FileName);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ZipFolder);
            this.Controls.Add(this.btn_Folder);
            this.Controls.Add(this.txt_Folder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZipDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Folder;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.Button btn_ZipFolder;
        private System.Windows.Forms.Button btn_ZipFile;
        private System.Windows.Forms.Button btn_FileName;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label3;
    }
}

