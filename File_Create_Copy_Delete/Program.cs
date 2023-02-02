using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Create_Copy_Delete
{
    public partial class frmOperations : Form
    {
        private TextBox textBox1;

        public frmOperations()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender,System.EventArgs e)
        {
            File.CreateTex(@"f:\" + txtCreateFile.Text + ".txt");//create a new file
        }
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            File.Delete(@"f:\" + txtDeleteFile.Text + ".txt");//delete the existing file
        }
        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            File.Copy(@"f:\" + txtCreateFile.Text + ".txt",@"f:\"+ txtCopyFile.Text+".txt",true);//create a new file
        }
        // private void InitializeComponent()
        //{
        //this.SuspendLayout();
        // 
        // frmOperations
        // 
        //this.ClientSize = new System.Drawing.Size(284, 261);
        //this.Name = "frmOperations";
        //this.Load += new System.EventHandler(this.frmOperations_Load);
        //this.ResumeLayout(false);

        //}

        private void frmOperations_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // frmOperations
            // 
            this.ClientSize = new System.Drawing.Size(687, 261);
            this.Controls.Add(this.textBox1);
            this.Name = "frmOperations";
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
