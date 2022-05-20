using GameTracker.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker.WinUI
{
    public partial class frmGameTracker : Form
    {
        public frmGameTracker()
        {
            InitializeComponent();

            CheckApplicationDirectoryAndFiles();
            ActivateTimer();
        }
        Timer _timer = new Timer();
        //static bool exitFlag = false;

        void ActivateTimer()
        {
            var timerInterval = 1000;
            var gameImageCheckingInterval = ConfigurationManager.AppSettings["GameImageCheckingInterval"];
            if (Settings.Default.GameImageCheckingInterval > 500)
            {
                timerInterval = Settings.Default.GameImageCheckingInterval;
            }
            _timer.Tick += new EventHandler(TimerEventProcessor);
            _timer.Interval = timerInterval;
            _timer.Start();
            //while (exitFlag==false)
            //{
            //    Application.DoEvents();
            //}
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(GetApplicationPath(Resources.GameImagesDirectory));

            var files = directory.GetFiles();

            var imageFile = (from f in directory.GetFiles()
                             orderby f.LastWriteTimeUtc descending
                             select f).FirstOrDefault();

            if (imageFile != null)
            {
                Image image = Image.FromFile(imageFile.FullName);
                //ImageConverter Class convert Image object to Byte Array.
                byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(image, typeof(byte[]));
                image.Dispose();
                //Convert Byte Array to Image and display in PictureBox.
                pbxCurrentGameImage.Image = Image.FromStream(new MemoryStream(bytes));
                //  pbxCurrentGameImage.Image = Image.FromFile(imageFile.FullName);// new Bitmap(imageFile.FullName);
                pbxCurrentGameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxCurrentGameImage.Update();
                pbxCurrentGameImage.Refresh();
            }
            else
            {
                pbxCurrentGameImage.Image = new Bitmap(Resources.GameImageNotFound);
                pbxCurrentGameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxCurrentGameImage.Update();
                pbxCurrentGameImage.Refresh();
            }
        }

        private void frmGameTracker_Load(object sender, EventArgs e)
        {
            //  CheckApplicationDirectoryAndFiles();

            LoadControllers();
        }

        private void CheckApplicationDirectoryAndFiles()
        {
            if (!Directory.Exists(Path.Combine(Application.LocalUserAppDataPath, Resources.ApplicationName)))
            {
                Directory.CreateDirectory(Path.Combine(Application.LocalUserAppDataPath, Resources.ApplicationName));
            }
            if (!Directory.Exists(GetApplicationPath(Resources.GameImagesDirectory)))
            {
                Directory.CreateDirectory(GetApplicationPath(Resources.GameImagesDirectory));
            }

            if (!File.Exists(GetApplicationPath(Resources.CurrentStatesFile)))
            {
                var currentStatesFile = File.Create(GetApplicationPath(Resources.CurrentStatesFile));
                currentStatesFile.Close();
            }
            if (!File.Exists(GetApplicationPath(Resources.StatesFile)))
            {
                var statesFile = File.Create(GetApplicationPath(Resources.StatesFile));
                statesFile.Close();
            }
            if (!File.Exists(GetApplicationPath(Resources.TagsFile)))
            {
                var tagsFile = File.Create(GetApplicationPath(Resources.TagsFile));
                tagsFile.Close();
            }
            if (!File.Exists(GetApplicationPath(Resources.ConditionsFile)))
            {
                var conditionsFile = File.Create(GetApplicationPath(Resources.ConditionsFile));
                conditionsFile.Close();
            }
            if (!File.Exists(GetApplicationPath(Resources.CameraCommandParametersFile)))
            {
                var cameraCommandParametersFile = File.Create(GetApplicationPath(Resources.CameraCommandParametersFile));
                cameraCommandParametersFile.Close();
            }
            if (!File.Exists(GetApplicationPath(Resources.CameraCommandsFile)))
            {
                var cameraCommandFile = File.Create(GetApplicationPath(Resources.CameraCommandsFile));
                cameraCommandFile.Close();
            }
        }

        private string GetApplicationPath(string pathName)
        {
            return Path.Combine(Application.LocalUserAppDataPath, Resources.ApplicationName, pathName);
        }
        private void LoadControllers()
        {
            if (File.Exists(GetApplicationPath(Resources.CurrentStatesFile)))
            {
                string[] currentStateslines = File.ReadAllLines(GetApplicationPath(Resources.CurrentStatesFile));
                if (currentStateslines.Any())
                    cbxCurrentState.Items.AddRange(currentStateslines);
                if (cbxCurrentState.Items.Count > 0)
                    cbxCurrentState.SelectedIndex = 0;
            }
            if (File.Exists(GetApplicationPath(Resources.StatesFile)))
            {
                string[] stateLines = File.ReadAllLines(GetApplicationPath(Resources.StatesFile));
                if (stateLines.Any())
                    cbxState.Items.AddRange(stateLines);
                if (cbxState.Items.Count > 0)
                    cbxState.SelectedIndex = 0;
            }
            if (File.Exists(GetApplicationPath(Resources.TagsFile)))
            {
                string[] tagLines = File.ReadAllLines(GetApplicationPath(Resources.TagsFile));
                if (tagLines.Any())
                    lbxTags.Items.AddRange(tagLines);
            }

            if (File.Exists(GetApplicationPath(Resources.ConditionsFile)))
            {
                string[] conditionLines = File.ReadAllLines(GetApplicationPath(Resources.ConditionsFile));
                if (conditionLines.Any())
                    cbxCondition.Items.AddRange(conditionLines);
                if (cbxCondition.Items.Count > 0)
                    cbxCondition.SelectedIndex = 0;
            }
            cbxConditionTypes.Items.Add("Contains");
            cbxConditionTypes.SelectedIndex = 0;

            if (File.Exists(GetApplicationPath(Resources.CameraCommandsFile)))
            {
                string[] commandLines = File.ReadAllLines(GetApplicationPath(Resources.CameraCommandsFile));
                if (commandLines.Any())
                    cbxCameraCommand.Items.AddRange(commandLines);
                if (cbxCameraCommand.Items.Count > 0)
                    cbxCameraCommand.SelectedIndex = 0;
            }

            if (File.Exists(GetApplicationPath(Resources.CameraCommandParametersFile)))
            {
                string[] commandParameterLines = File.ReadAllLines(GetApplicationPath(Resources.CameraCommandParametersFile));
                if (commandParameterLines.Any())
                    cbxCameraCommandParameter.Items.AddRange(commandParameterLines);
                if (cbxCameraCommandParameter.Items.Count > 0)
                    cbxCameraCommandParameter.SelectedIndex = 0;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var currentStateColumn = cbxCurrentState.SelectedIndex >= 0 ? cbxCurrentState.SelectedItem : string.Empty;
            var stateColumn = cbxState.SelectedIndex >= 0 ? cbxState.SelectedItem : string.Empty;
            var tagsColumn = string.Empty;
            if (lbxTags.SelectedItems.Count > 0)
            {
                foreach (var item in lbxTags.SelectedItems)
                {
                    if (!string.IsNullOrEmpty(tagsColumn))
                    {
                        tagsColumn = $"{tagsColumn},{item}";
                    }
                    else
                    {
                        tagsColumn = item.ToString();
                    }
                }
            }
            var conditionsType = cbxConditionTypes.SelectedIndex >= 0 ? cbxConditionTypes.SelectedItem.ToString() : string.Empty;
            var condition = cbxCondition.SelectedIndex >= 0 ? cbxCondition.SelectedItem.ToString() : string.Empty;
            var conditionValue = txtConditionValue.Text;
            var conditionColumn = string.Empty;
            var conditionArr = new string[] { conditionsType, condition, conditionValue };
            conditionColumn = string.Join(",", conditionArr);


            var cameraCommand = cbxCameraCommand.SelectedIndex >= 0 ? cbxCameraCommand.SelectedItem.ToString() : string.Empty;
            var cameraCommandParameter = cbxCameraCommandParameter.SelectedIndex >= 0 ? cbxCameraCommandParameter.SelectedItem.ToString() : string.Empty;
            var cameraCommandValue = txtCameraCommandValue.Text;
            var cameraCommandColumn = string.Empty;
            var cameraCommandArr = new string[] { cameraCommand, cameraCommandParameter, cameraCommandValue };
            cameraCommandColumn = string.Join(",", cameraCommandArr);


            dgvAssigned.Rows.Add(currentStateColumn, stateColumn, tagsColumn, conditionColumn, cameraCommandColumn);



        }

        private void dgvAssigned_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvAssigned.Rows[e.RowIndex].Cells[5].Value = "Delete";
        }

        private void dgvAssigned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("The selected row will be deleted, are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvAssigned.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
