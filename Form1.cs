using Microsoft.Win32;

namespace L1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registryPath = @"SOFTWARE\YAKOVLEVA"; 

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                {
                    
                    string[] p5Values = (string[])key.GetValue("P5");
                    {
                       
                        string message = string.Join(Environment.NewLine, p5Values);
                        MessageBox.Show(message, "Зміст параметра P5");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string registryPath = @"SOFTWARE\YAKOVLEVA"; 

            using (RegistryKey key = Registry.LocalMachine.CreateSubKey(registryPath))
            {
                {
                   
                    string[] p6Values = {
                            "\"Я - усердна студентка",
                            "кафедрі комп’ютерної інженерії!\""
                        };

                   
                    key.SetValue("P6", p6Values, RegistryValueKind.MultiString);
                    string message = string.Join(Environment.NewLine, p6Values);
                    MessageBox.Show(message, "Зміст параметра P6");
                }
            }
        }
    }
}
