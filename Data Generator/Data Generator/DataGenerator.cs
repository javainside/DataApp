using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Generator
{
    public partial class DataGenerator : Form
    {

        List<TagProfile> tags;
        TagProfile currentTag;
        public DataGenerator()
        {
            InitializeComponent();
            
            datagridTagList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            tags = new List<TagProfile>();
            currentTag = new TagProfile(this);
            currentTag.Dock = DockStyle.None;
            currentTag.Location = new Point(0, 9);
            this.Controls.Add(currentTag);
            
            //tags.Add(currentTag);

           // datagridTagList.Rows.Add(new object[] { "Default Tag", 1 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // currentTag.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void createTag(string tagName, double data, TagProfile currTag)
        {
            currentTag = currTag;
            //TagProfile tag = new TagProfile(this);
            TagProfile tag = new TagProfile(currentTag, this);
            //tag = currentTag;
            tag.Dock = DockStyle.None;
            tag.Location = new Point(230, 9);
            this.Controls.Add(tag);

            tags.Add(tag);
           // datagridTagList.Rows.
            datagridTagList.Rows.Add(new object[] { tagName, data });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridTagList.CurrentRow != null)
            {
                if ((currentTag != null) && (currentTag != tags[datagridTagList.CurrentRow.Index]))
                {
                    currentTag.Hide();
                    currentTag = tags[datagridTagList.CurrentRow.Index];
                    //tags[datagridTagList.CurrentRow.Index].Show();
                    currentTag.Show();
                }

                
            }
        }

        public void updateValue(string tagName, string data, TagProfile tagFor)
        {
            int rowIndex = 0;
            foreach (TagProfile tag in tags)
            {
                if (tag == tagFor)
                {
                    //update row values on that index
                    datagridTagList.Rows[rowIndex].Cells[0].Value = tagName;
                    datagridTagList.Rows[rowIndex].Cells[1].Value = data;
                }
                rowIndex++;
            }
        }

        public void updateValue(string tagName, double data, TagProfile tagFor)
        {
            int rowIndex = 0;
            foreach (TagProfile tag in tags)
            {
                if (tag == tagFor)
                {
                    //update row values on that index
                    datagridTagList.Rows[rowIndex].Cells[0].Value = tagName;
                    datagridTagList.Rows[rowIndex].Cells[1].Value = data;
                }
                rowIndex++;
            }
        }

        public void updateTagName(string tagName)
        {
            int rowIndex = 0;
            foreach (TagProfile tag in tags)
            {
                if (tag == currentTag)
                {
                    //update row values on that index
                    datagridTagList.Rows[rowIndex].Cells[0].Value = tagName;
                }
                rowIndex++;
            }
        }

        private void grbboxTagData_Enter(object sender, EventArgs e)
        {

        }

        private void datagridTagList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
