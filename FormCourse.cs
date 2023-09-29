using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;

namespace RolledOutDevTool
{
    public partial class FormCourse : Form
    {

        string currentFile;
        public DataSet stages = new DataSet();
        DataTable dt = new DataTable();
        int dragRow = -1;
        Label dragLabel = null;

        public FormCourse()
        {
            InitializeComponent();
        }

        public void receive(DataRow i)
        {
            dataGridView1.Rows.Add(i.ItemArray);
            displayNumbers();
        }

        

        //START
        private void FormChild_Load(object sender, EventArgs e)
        {

            textDiff.Text = "0";
            textConfVer.Text = "0.1.0";
            
            while(!File.Exists("stages.json"))
            {
                DialogResult initScan = MessageBox.Show("The \"Stages\" directory in the game files for Rolled Out must be scanned for this program to work.\n A \"stages.json\" file will be generated.", "Notice", MessageBoxButtons.OKCancel);
                if(initScan == DialogResult.OK)
                {
                    scanStages();
                }
                else
                {
                    Environment.Exit(1);
                }
                
            }

            //Load Stages Database
            //Scan File
            StreamReader stgscan = new StreamReader("stages.json");
            JObject stgdb = JObject.Parse(stgscan.ReadToEnd());

            //Initialize Stage Database
            stages.Namespace = "stagebase";
            DataTable stgtbl = new DataTable();
            stgtbl.Columns.Add("UUID");
            stgtbl.Columns.Add("Name");
            stgtbl.Columns.Add("Preview");
            stgtbl.Columns[2].DataType = typeof(Bitmap);
            stages.Tables.Add(stgtbl);

            //Initialize DataGridView
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "UUID";
            dataGridView1.Columns[1].Name = "Name";
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = "Preview";
            dataGridView1.Columns.Add(imageCol);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersWidth = 60;

            //Initialize Loop Variables
            String imgdir;
            Bitmap img1, img2;

            //Add All Stage Information to Database
            foreach (JProperty i in stgdb.Properties())
            {
                imgdir = (string)stgdb.SelectToken(i.Name.ToString() + "[1]");

                if (File.Exists(imgdir))
                {
                    img1 = new Bitmap(imgdir);
                    img2 = new Bitmap(img1, 64, 64);
                    stgtbl.Rows.Add(
                        i.Name.ToString(),
                        (string)stgdb.SelectToken(i.Name.ToString() + "[0]"),
                        img2
                    );
                }
                else
                {
                    stgtbl.Rows.Add(
                        i.Name.ToString(),
                        (string)stgdb.SelectToken(i.Name.ToString() + "[0]"),
                        new Bitmap("fail.png")
                    );
                }
            }
        }

        //FILE -> LOAD
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Read course.json
                StreamReader reader = new StreamReader(ofd.FileName);
                currentFile = ofd.FileName;
                JObject jobj = JObject.Parse(reader.ReadToEnd());

                //Read Stage Database
                StreamReader stgscan = new StreamReader("stages.json");
                JObject stgdb = JObject.Parse(stgscan.ReadToEnd());

                //Get Metadata
                textConfVer.Text = (string)jobj.SelectToken("config_version");
                textUUID.Text = (string)jobj.SelectToken("metadata.uuid");
                textName.Text = (string)jobj.SelectToken("metadata.name.fallback");
                this.Text = (string)jobj.SelectToken("metadata.name.fallback");
                textCreator.Text = (string)jobj.SelectToken("metadata.creator_uuid");
                richTextDesc.Text = (string)jobj.SelectToken("metadata.description.fallback");
                textDiff.Text = (string)jobj.SelectToken("metadata.difficulty");

                //Clear Stages
                dataGridView1.Rows.Clear();

                //Get Stages
                JArray stagesraw = (JArray)jobj["stages"];

                //Initialize Loop Variables
                String imgdir;
                Bitmap img1, img2;

                //Add Stages from course.json to DataGridView
                foreach (JValue i in stagesraw)
                {
                    imgdir = (string)stgdb.SelectToken(i.ToString() + "[1]");

                    if (File.Exists(imgdir))
                    {
                        img1 = new Bitmap(imgdir);
                        img2 = new Bitmap(img1, 64, 64);
                        dataGridView1.Rows.Add(
                            i,
                            (string)stgdb.SelectToken(i.ToString() + "[0]"),
                            img2
                        );
                    }
                    else
                    {
                        dataGridView1.Rows.Add(
                            i,
                            (string)stgdb.SelectToken(i.ToString() + "[0]"),
                            new Bitmap("fail.png")
                        );
                    }
                }
               
                //Close StreamReader
                reader.Close();
            }
            displayNumbers();
        }

        //FILE -> SAVE AS
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Initialize Variables
            JObject coursegen = new JObject();
            List<String> stages = new List<String>();

            //Add Stage UUIDs to Array List
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                stages.Add(dataGridView1[0, i].Value.ToString());
            }

            //Create Metadata JObject
            JObject metadata = new JObject();
            metadata.Add(new JProperty("uuid", textUUID.Text));
            metadata.Add(new JProperty("name", new JObject(new JProperty("fallback", textName.Text))));
            metadata.Add(new JProperty("tags", new List<String>()));
            metadata.Add(new JProperty("creator_uuid", textCreator.Text));
            metadata.Add(new JProperty("description", new JObject(new JProperty("fallback", richTextDesc.Text))));
            try
            {
                metadata.Add(new JProperty("difficulty", Int32.Parse(textDiff.Text)));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Difficulty must be an integer.\nSetting Difficulty to 0.", "Error");
                textDiff.Text = "0";
                metadata.Add(new JProperty("difficulty", 0));
            }

            //Append Contents to Main JObject
            coursegen.Add(new JProperty("config_version", textConfVer.Text));
            coursegen.Add(new JProperty("metadata", metadata));
            coursegen.Add(new JProperty("stages", stages));

            //Append Main JObject to JSON File
            File.WriteAllText("course.json", coursegen.ToString());
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON (*.json)|*.json";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamWriter file = File.CreateText(sfd.FileName))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.Formatting = Formatting.Indented;
                    coursegen.WriteTo(writer);
                }
                this.Text = textName.Text;
            }
        }

        //FILE -> SAVE
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            //Initialize Variables
            JObject coursegen = new JObject();
            List<String> stages = new List<String>();

            //Add Stage UUIDs to Array List
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                stages.Add(dataGridView1[0, i].Value.ToString());
            }

            //Create Metadata JObject
            JObject metadata = new JObject();
            metadata.Add(new JProperty("uuid", textUUID.Text));
            metadata.Add(new JProperty("name", new JObject(new JProperty("fallback", textName.Text))));
            metadata.Add(new JProperty("tags", new List<String>()));
            metadata.Add(new JProperty("creator_uuid", textCreator.Text));
            metadata.Add(new JProperty("description", new JObject(new JProperty("fallback", richTextDesc.Text))));
            try
            {
                metadata.Add(new JProperty("difficulty", Int32.Parse(textDiff.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Difficulty must be an integer.\nSetting Difficulty to 0.", "Error");
                textDiff.Text = "0";
                metadata.Add(new JProperty("difficulty", 0));
            }

            //Append Contents to Main JObject
            coursegen.Add(new JProperty("config_version", textConfVer.Text));
            coursegen.Add(new JProperty("metadata", metadata));
            coursegen.Add(new JProperty("stages", stages));

            //Append Main JObject to JSON File
            if (currentFile == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JSON (*.json)|*.json";
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamWriter file = File.CreateText(sfd.FileName))
                    using (JsonTextWriter writer = new JsonTextWriter(file))
                    {
                        writer.Formatting = Formatting.Indented;
                        coursegen.WriteTo(writer);
                    }
                    this.Text = textName.Text;
                }
            }
            else
            {
                File.WriteAllText(currentFile, coursegen.ToString());
                using (StreamWriter file = File.CreateText(currentFile))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.Formatting = Formatting.Indented;
                    coursegen.WriteTo(writer);
                }
                
            }
        }

        //STAGES -> ADD STAGES
        private void addStagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Add Form
            FormAdd stgAdd = new FormAdd(stages, this);
            stgAdd.Show();
        }

        //STAGES -> SCAN STAGES FOLDER
        private void scanStageFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scanStages())
            {
                MessageBox.Show("You must restart the program for the new stage directory to take effect.");
            }
        }

        //UUIDs -> GENERATE NEW COURSE UUID
        private void generateNewCourseUUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textUUID.Text = Guid.NewGuid().ToString();
        }

        //UUIDs -> GENERATE NEW COURSE UUID
        private void generateNewCreatorUUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textCreator.Text = Guid.NewGuid().ToString();
        }




        //DRAG ORDER CHANGE
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dragRow = e.RowIndex;
            if (dragLabel == null) dragLabel = new Label();
            dragLabel.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            dragLabel.Parent = dataGridView1;
            dragLabel.Location = e.Location;
            displayNumbers();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if(dataGridView1.Rows.Count > 0) {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                int dropRow = -1;
                if (hit.Type != DataGridViewHitTestType.None)
                {
                    dropRow = hit.RowIndex;
                    if (dragRow >= 0)
                    {
                        int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
                        if (tgtRow != dragRow)
                        {
                            DataGridViewRow row = dataGridView1.Rows[dragRow];
                            dataGridView1.Rows.Remove(row);
                            dataGridView1.Rows.Insert(tgtRow, row);

                            dataGridView1.ClearSelection();
                            row.Selected = true;
                        }
                    }
                }
                else if (dragRow >= 0) {
                    dataGridView1.Rows[dragRow].Selected = true; 
                }

                if (dragLabel != null)
                {
                    dragLabel.Dispose();
                    dragLabel = null;
                }
                displayNumbers();
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragLabel != null)
            {
                dragLabel.Location = e.Location;
                dataGridView1.ClearSelection();
            }
            displayNumbers();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //SHOW STAGES IN ORDER
        private void displayNumbers()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                dataGridView1.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                
            }
        }

        //SCAN STAGES FOLDER
        private bool scanStages()
        {
            //Initialize Folder Browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath) && fbd.SelectedPath.Contains("Stages"))
            {
                //Create Dataset for Stages
                DataSet ds = new DataSet("DS");
                ds.Namespace = "sample";
                DataTable stages = new DataTable();
                stages.Columns.Add("UUID");
                stages.Columns.Add("Name");
                stages.Columns.Add("Preview");
                ds.Tables.Add(stages);

                //Scan Entire Directory
                String[] files = Directory.GetFiles(fbd.SelectedPath, "*.json", SearchOption.AllDirectories);

                //Initialize Loop Variables
                String name, uuid, img;
                JObject param, stagelist = new JObject();

                //Initialize Progress Popup
                FormScanning frmscn = new FormScanning();
                frmscn.Show();
                frmscn.TopMost = true;
                frmscn.initProgBar(files.Length);

                //Add Stages to Dataset
                foreach (String i in files)
                {
                    using (StreamReader reader = new StreamReader(i))
                    {
                        param = JObject.Parse(reader.ReadLine());
                        uuid = (string)param.SelectToken("metadata.uuid");
                        name = (string)param.SelectToken("metadata.name.fallback");
                        img = i.Substring(0, i.Length - 11) + "preview512.png";
                        stages.Rows.Add(uuid, name, img);
                        stagelist.Add(new JProperty(uuid, name, img));
                    }
                    frmscn.progStep();
                    Application.DoEvents();
                }

                try
                {
                    //Export Stages Dataset to JSON
                    File.WriteAllText("stages.json", stagelist.ToString());
                    using (StreamWriter file = File.CreateText("stages.json"))
                    using (JsonTextWriter writer = new JsonTextWriter(file))
                    {
                        writer.Formatting = Formatting.Indented;
                        stagelist.WriteTo(writer);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                frmscn.Close();
                MessageBox.Show("Stage Directory was Successfully Scanned! If problems occur, try deleting the \"stages.json\" file and rescan.");
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Directory");
                return false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rolled Out Course Editor" +
                "\nProgrammed by Daniel Kruse (Sapphire Bullet Bill)" +
                "\nDeveloped in C# .NET using Visual Studio 2022. Also uses the Newtonsoft JSON dependency." +
                "\nAdditional Code retrieved from ChronusDOTNet" +
                "\nThis program is used for creating and modifying \"course.json\" files for the Rolled Out game." +
                "\nFor more information about the game, check https://rolledoutgame.com/" +
                "\nThis software is not affiliated or endorsed by the developers of Rolled Out.");
        }

        private void clearStageListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
