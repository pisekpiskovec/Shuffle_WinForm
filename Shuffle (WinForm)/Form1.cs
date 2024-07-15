using System.ComponentModel;

namespace Shuffle_WinForm
{
    public partial class Form1 : Form
    {
        BindingList<ItemHolder> beforeList = new BindingList<ItemHolder>();
        BindingList<int> ints = new BindingList<int>();
        BindingList<ItemHolder> afterList = new BindingList<ItemHolder>();

        public Form1()
        {
            InitializeComponent();
            lbLoaded.DataSource = beforeList;
            lbLoaded.DisplayMember = "DisplayPath";
            lbNums.DataSource = ints;
            lbAfter.DataSource = afterList;
            lbAfter.DisplayMember = "FullPath";
        }

        private void tsmiOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in Directory.GetFiles(dialog.SelectedPath))
                    if (Path.GetExtension(item) == ".mp3")
                        beforeList.Add(new ItemHolder(Path.GetFullPath(item)));
                tsbGenerateNums.Enabled = true;
            }
        }

        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3|*.mp3";
            if (dialog.ShowDialog() == DialogResult.OK) { beforeList.Add(new ItemHolder(dialog.FileName)); tsbGenerateNums.Enabled = true; }
        }

        private void tsbGenerateNums_Click(object sender, EventArgs e) { foreach (ItemHolder item in beforeList) ints.Add(RandomNumber(beforeList, ints)); tsbConcat.Enabled = true; }

        private int RandomNumber(BindingList<ItemHolder> CapacityList, BindingList<int> DestinationList)
        {
            int GeneratedNum = new Random().Next(1, CapacityList.Count + 1);
            if (DestinationList.IndexOf(GeneratedNum) != -1) GeneratedNum = RandomNumber(CapacityList, DestinationList);
            return GeneratedNum;
        }

        private void tsbConcat_Click(object sender, EventArgs e)
        {
            string NumberFormat = StringFormatPlaces(beforeList.Count);
            for (int i = 0; i < beforeList.Count; i++)
            {
                ItemHolder item = beforeList[i];
                string FullPath = $"{item.RootDirectory}\\{ints[i].ToString(NumberFormat)} - {item.DisplayPath}";
                afterList.Add(new ItemHolder(FullPath));
            }
            tssbSave.Enabled = true;
        }

        private string StringFormatPlaces(int a)
        {
            string b = a.ToString(), result = string.Empty;
            for (int i = 0; i < b.Length; i++)
                result += "0";
            return result ?? string.Empty;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < afterList.Count; i++)
            {
                File.Move(beforeList[i].FullPath, afterList[i].FullPath);
            }
            Preape();
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < afterList.Count; i++)
            {
                File.Copy(beforeList[i].FullPath, afterList[i].FullPath);
            }
            Preape();
        }

        private void Preape()
        {
            beforeList.Clear();
            ints.Clear();
            afterList.Clear();
            tsbGenerateNums.Enabled = false;
            tsbConcat.Enabled = false;
            tssbSave.Enabled = false;
        }
    }

    public class ItemHolder
    {
        public ItemHolder(string GetFullPath) { FullPath = GetFullPath.Replace("\r", string.Empty).Replace("\n", string.Empty); }
        public string FullPath {  get; set; } = string.Empty;
        public string DisplayPath { get { return Path.GetFileName(FullPath); } }
        public string RootDirectory { get { return Path.GetDirectoryName(FullPath) ?? string.Empty; } }
    }
}
