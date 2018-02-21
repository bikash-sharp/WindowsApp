using App_BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestariTerrace.Forms
{
    public partial class PrinterSetup : Form
    {
        public static string filePath = Path.Combine(Environment.CurrentDirectory, "Printer.txt");
        public PrinterSetup()
        {
            InitializeComponent();
        }

        public IPAddress ValidateIP(MaskedTextBox input)
        {
            IPAddress ipAddress;
            if (input.Text.Contains(" "))
                input.Text = input.Text.Replace(" ", "");
            if (IPAddress.TryParse(input.Text, out ipAddress))
            {
                //IP address has been parsed correctly
            }
            return ipAddress;
        }

        private void btnPrinterSave_Click(object sender, EventArgs e)
        {
            bool isExist = File.Exists(filePath);
            try
            {
                //bool IsKitchenIPCorrect = ValidateIP(txtKitchen) == null ? false : true ;
                //bool IsCashierIPCorrect = ValidateIP(txtCashPrinter) == null ? false : true;
                bool IsKitchenIPCorrect = true;
                bool IsCashierIPCorrect = true;
                if (!IsKitchenIPCorrect)
                {
                    MessageBox.Show("Kitchen Printer IP is not a valid IP", "Printer Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(!IsCashierIPCorrect)
                {
                    MessageBox.Show("Cashier Printer IP is not a valid IP", "Printer Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (StreamWriter writer = new StreamWriter("Printer.txt"))
                {
                    //writer.WriteLine("Kitchen$" + ValidateIP(txtKitchen).ToString());
                    //writer.WriteLine("CashCounter$" + ValidateIP(txtCashPrinter).ToString());
                    writer.WriteLine("Kitchen$" + txtKitchen.Text);
                    writer.WriteLine("CashCounter$" + txtCashPrinter.Text);
                    writer.WriteLine("DisplayPort$" + txtPort.Text.ToUpper());
                }
                MessageBox.Show("Printer Setup done successfully", "Printer Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Printer Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrinterSetup_Load(object sender, EventArgs e)
        {
            
            try
            {
                //txtKitchen.Text = "   .   .   .   ";
                //txtKitchen.PromptChar = ' ';
                //txtKitchen.Mask = "009.009.009.900";
                //txtKitchen.ResetOnSpace = false;
                //txtKitchen.SkipLiterals = false;

                //txtCashPrinter.Text = "   .   .   .   ";
                //txtCashPrinter.PromptChar = ' ';
                //txtCashPrinter.Mask = "009.009.009.900";
                //txtCashPrinter.ResetOnSpace = false;
                //txtCashPrinter.SkipLiterals = false;


                FileInfo _fileinfo = new FileInfo(filePath);
                if(_fileinfo.Exists)
                {
                    string[] lines = File.ReadAllLines(filePath);
                    txtKitchen.Text = lines[0].Split('$')[1];
                    txtCashPrinter.Text = lines[1].Split('$')[1];
                    txtPort.Text = lines[2].Split('$')[2];
                }
                else
                {
                    MessageBox.Show("Printer/Port Setting Not found", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetPrinterName(EmPrinterType printerType)
        {
            string result = string.Empty;
            try
            {
                FileInfo _fileinfo = new FileInfo(filePath);
                if (_fileinfo.Exists)
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if(printerType == EmPrinterType.Kitchen)
                    {
                        result = lines[0].Split('$')[1];
                    }
                    else if(printerType == EmPrinterType.CashCounter)
                    {
                        result = lines[1].Split('$')[1];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
