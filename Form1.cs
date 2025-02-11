using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;


namespace SignUpDemo
{
    public partial class mf : Form
    {
        [DllImport("wininet.dll")] // importing net dll //
        private extern static bool InternetGetConnectedState(out int dc, int rv);  // checking if connection iz fine //

        // variables //
        int i = Properties.Settings.Default.i;  // making variable i = saved variable i //
        string pah,open,ver;
        double ttlmark,obtmark,per;
        WebClient client;

        public mf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)  // Runs at the starting of the program //
        {
            try
            {
                // veb client //
                client = new WebClient();
                client.DownloadFileCompleted += client_DownloadFileCompleted;


                btn_comp.Checked = true;  // Selecting radio button_computer on the starting of the software //
                pah = Properties.Settings.Default.path;  // making pah variable equal to the saved path //
                txt_path.Text = Properties.Settings.Default.path;  // making text of path textbox equal to the saved path //
                if (Properties.Settings.Default.i == 0)  // if saved variable i is 0 //
                {
                    btn_end.Enabled = false; // disabling end button //
                }
                else // NOT(if) //
                {
                    txt_class.Text = Properties.Settings.Default.cl;  // making value of txt_class textbox to the saved variable cl  //
                    txt_num.Text = Properties.Settings.Default.num;  // making value of txt_num textbox to the saved variable num  //
                    txt_term.Text = Properties.Settings.Default.term;  // making value of txt_term textbox to the saved variable term  //
                    txt_year.Text = Properties.Settings.Default.year;  // making value of txt_year textbox to the saved variable year  //
                    txt_date.Text = Properties.Settings.Default.date;  // making value of txt_date textbox to the saved variable date  //
                    txt_num.Enabled = false;  // disabling strenth textbox //
                    txt_class.Enabled = false; // disabling class textbox //
                    txt_year.Enabled = false;  // disabling year textbox //
                    txt_term.Enabled = false;  // disabling term textbox //
                    txt_date.Enabled = false;  // disabling date textbox //
                    drop_month.Enabled = false;  // disabling month dropbox/combobox  //
                    btn_end.Enabled = true;  // enabling end button //
                    btn_path.Enabled = false; // disabling path button //
                }
            }
            catch (Exception f)
            {
                if (f.Message != "Parameter is not valid.")
                {
                    MessageBox.Show(f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Handle unepected error //
                }
                else
                {
                    MessageBox.Show(@"'Images\logo.png' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Handle unepected error //
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Exiting from Application //
        }

        private void num_valid(object sender, KeyPressEventArgs e)
        {
            // Validating Textboxes to only Accept Numbers //
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))  // only accepting numbers and decimal points //
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Bunifu.Framework.UI.BunifuMaterialTextbox).Text.IndexOf('.') > -1))  // validating only one decimal point //
            {
                e.Handled = true;
            }
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Changing window state to minimized //
        }

        private void btn_bio_CheckedChanged(object sender, EventArgs e)
        {
            // Checking radio button biology is selected or not and taking steps accordingly on comp_ttl textbox //
            if (btn_bio.Checked)
            {
                comp_ttl.Text = "60";  // making text comp_tll textbox equal to 60 //
            }
            else
            {
                comp_ttl.Text = "50";  // making text comp_tll textbox equal to 50 //
            }
        }

        private void btn_comp_CheckedChanged(object sender, EventArgs e)
        {
            // Checking radio button computer is selected or not and taking steps accordingly on comp_ttl textbox //
            if (btn_bio.Checked)
            {
                comp_ttl.Text = "50";  // making text comp_tll textbox equal to 50 //
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            btn_create.Text = "Creating...";  // Changing button text to Creating... //
            // Making Sure that all the text boxes are filled else a popup message will give error //

            if (txt_name.Text != "" && txt_class.Text != "" && txt_roll.Text != "" && txt_num.Text != "" && mark_chem.Text != "" && mark_phy.Text != "" && mark_urdu.Text != "" && mark_eng.Text != "" && mark_pk.Text != "" && mark_isl.Text != "" && mark_comp.Text != "" && mark_math.Text != "" && chem_ttl.Text != "" && phy_ttl.Text != "" && eng_ttl.Text != "" && urdu_ttl.Text != "" && math_ttl.Text != "" && isl_ttl.Text != "" && comp_ttl.Text != "")
            {
                if (double.Parse(mark_chem.Text) <= double.Parse(chem_ttl.Text) && double.Parse(mark_urdu.Text) <= double.Parse(urdu_ttl.Text) && double.Parse(mark_phy.Text) <= double.Parse(phy_ttl.Text) && double.Parse(mark_eng.Text) <= double.Parse(eng_ttl.Text) && double.Parse(mark_math.Text) <= double.Parse(math_ttl.Text) && double.Parse(mark_isl.Text) <= double.Parse(isl_ttl.Text) && double.Parse(mark_pk.Text) <= double.Parse(pk_ttl.Text) && double.Parse(mark_comp.Text) <= double.Parse(comp_ttl.Text))
                {
                    if (!File.Exists(pah + @"\" + txt_name.Text + ".xlsx")) // making sure that no excel file with same name exist in the saving directory //
                    {
                        if (int.Parse(txt_num.Text) > i)  // if number of students in the class is greater than variable i //
                        {
                            obtmark = double.Parse(mark_math.Text) + double.Parse(mark_urdu.Text) + double.Parse(mark_eng.Text) + double.Parse(mark_phy.Text) + double.Parse(mark_chem.Text) + double.Parse(mark_comp.Text) + double.Parse(mark_isl.Text) + double.Parse(mark_pk.Text); // Converting obtain marks of subjects and coverting it to decimal(double) formate and adding all obtain marks to get total obtain marks //
                            ttlmark = double.Parse(chem_ttl.Text) + double.Parse(urdu_ttl.Text) + double.Parse(phy_ttl.Text) + double.Parse(eng_ttl.Text) + double.Parse(math_ttl.Text) + double.Parse(isl_ttl.Text) + double.Parse(pk_ttl.Text) + double.Parse(comp_ttl.Text); // Converting total marks of subjects and coverting it to decimal(double) formate and adding all obtain marks to get total marks //
                            per = obtmark * 100 / ttlmark; // getting overall percentage //
                            // Creating Excel File //
                            try // adding try property to counter errors //
                            {
                                File.Copy(@"Source\layout.mf", pah + @"\" + txt_name.Text + ".xlsx"); // Copying layout file from program to the given path //
                                if (!File.Exists(pah + @"\positon.xlsx")) // if excel file named position does not exist in the selected path //
                                {
                                    File.Copy(@"Source\position.calc", pah + @"\positon.xlsx"); // Copying layout file from program to the given path //
                                }
                                Excel.Application file = new Excel.Application();  // Creating Excel file //
                                Excel.Workbook book = file.Workbooks.Open(pah + @"\" + txt_name.Text + ".xlsx");  // Importing layout //
                                Excel.Worksheet efile = file.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;  // Implimenting layout on Excel file //
                                // Creating and editing file  //
                                if (per > 80)
                                {
                                    efile.Cells[12, 8] = "A+";
                                    efile.Cells[28, 2] = "Millions of Congratulations " + txt_name.Text + "!";
                                    efile.Cells[29, 3] = "You are efficient and great listener. Your performance is superb in this";
                                    efile.Cells[30, 2] = "term. Keep it up with same zeal and zest. Parents, encourage " + txt_name.Text + " with";
                                    efile.Cells[31, 2] = "the gift of his choice.";
                                }

                                else if (per > 70)
                                {
                                    efile.Cells[12, 8] = "A";
                                    efile.Cells[28, 2] = "Nice Performance! Keep it up " + txt_name.Text + "!";
                                    efile.Cells[29, 3] = "You are a responsible and hard working student. Your performance is superb in";
                                    efile.Cells[30, 2] = "this term. You have proved your hard work by giving excellent marks. keep it up";
                                }
                                else if (per > 60)
                                {
                                    efile.Cells[12, 8] = "B";
                                    efile.Cells[28, 2] = "Keep it up " + txt_name.Text + "!";
                                    efile.Cells[29, 3] = "You are a confident and enthusiastic learner. You have great sense of humour.";
                                    efile.Cells[30, 2] = "You have performed excellent in this term. Keep up Your wonderful efforts.";
                                }
                                else if (per > 50)
                                {
                                    efile.Cells[12, 8] = "C";
                                    efile.Cells[28, 2] = "Needs Improvement!";
                                    efile.Cells[29, 3] = "Please come on Parents Teacher's Meeting to discuss acadenic ";
                                    efile.Cells[30, 2] = "problems of your child.";
                                }
                                else
                                {
                                    efile.Cells[12, 8] = "F";
                                    efile.Cells[28, 2] = "Needs Improvement!";
                                    efile.Cells[29, 3] = "Please come on Parents Teacher's Meeting to discuss acadenic ";
                                    efile.Cells[30, 2] = "problems of your child.";
                                }
                                Properties.Settings.Default.month = drop_month.selectedValue.ToString();
                                string month = drop_month.selectedValue.ToString();

                                // entering name on the perticular name cell in Excel file //
                                efile.Cells[9, 4] = txt_name.Text;
                                // entering total mark  of subjects on perticular cells //
                                efile.Cells[15, 4] = eng_ttl.Text;
                                efile.Cells[16, 4] = urdu_ttl.Text;
                                efile.Cells[17, 4] = math_ttl.Text;
                                efile.Cells[18, 4] = chem_ttl.Text;
                                efile.Cells[19, 4] = comp_ttl.Text;
                                efile.Cells[20, 4] = isl_ttl.Text;
                                efile.Cells[21, 4] = pk_ttl.Text;
                                efile.Cells[22, 4] = phy_ttl.Text;
                                // entering obt mark of subjects on perticular cells //
                                efile.Cells[15, 6] = mark_eng.Text;
                                efile.Cells[16, 6] = mark_urdu.Text;
                                efile.Cells[17, 6] = mark_math.Text;
                                efile.Cells[18, 6] = mark_chem.Text;
                                efile.Cells[19, 6] = mark_comp.Text;
                                efile.Cells[20, 6] = mark_isl.Text;
                                efile.Cells[21, 6] = mark_pk.Text;
                                efile.Cells[22, 6] = mark_phy.Text;
                                // entering data of total result //
                                efile.Cells[33, 5] = month + " " + txt_date.Text + ", 20" + txt_year.Text;
                                efile.Cells[11, 6] = obtmark;
                                efile.Cells[11, 9] = ttlmark;
                                efile.Cells[12, 4] = per;
                                efile.Cells[10, 5] = txt_class.Text;
                                efile.Cells[10, 9] = txt_roll.Text;
                                efile.Cells[24, 3] = txt_num.Text;
                                if (txt_term.Text == "1")
                                {
                                    efile.Cells[8, 2] = "QUANTITATIVE ASSESSMENT OF " + txt_term.Text + "st" + " Term, 20" + txt_year.Text + "-" + (int.Parse(txt_year.Text) + 1).ToString();  // Writing term and year on perticular cell //
                                    efile.Cells[11, 2] = "Appeared in " + txt_term.Text + "st" + " Semester and obtained";  // Writing semester on a perticular cell //
                                }
                                else if (txt_term.Text == "2")
                                {
                                    efile.Cells[8, 2] = "QUANTITATIVE ASSESSMENT OF " + txt_term.Text + "nd" + " Term, 20" + txt_year.Text + "-" + (int.Parse(txt_year.Text) + 1).ToString();  // Writing term and year on perticular cell //
                                    efile.Cells[11, 2] = "Appeared in " + txt_term.Text + "nd" + " Semester and obtained";  // Writing semester on a perticular cell //
                                }
                                else if (txt_term.Text == "3")
                                {
                                    efile.Cells[8, 2] = "QUANTITATIVE ASSESSMENT OF " + txt_term.Text + "rd" + " Term, 20" + txt_year.Text + "-" + (int.Parse(txt_year.Text) + 1).ToString();  // Writing term and year on perticular cell //
                                    efile.Cells[11, 2] = "Appeared in " + txt_term.Text + "rd" + " Semester and obtained";  // Writing semester on a perticular cell //
                                }
                                else
                                {
                                    efile.Cells[8, 2] = "QUANTITATIVE ASSESSMENT OF " + txt_term.Text + "th" + " Term, 20" + txt_year.Text + "-" + (int.Parse(txt_year.Text) + 1).ToString();  // Writing term and year on perticular cell //
                                    efile.Cells[11, 2] = "Appeared in " + txt_term.Text + "th" + " Semester and obtained";  // Writing semester on a perticular cell //
                                }
                                book.Close(true, Type.Missing, Type.Missing); // Exiting Excel file //
                                file.Quit();  // Quiting created excel file //

                                i += 1;
                                Properties.Settings.Default.i = i;
                                Properties.Settings.Default.Save();
                                Excel.Application po = new Excel.Application();  // Creating Excel file //
                                Excel.Workbook pbook = po.Workbooks.Open(pah + @"\positon.xlsx");  // Naming path //
                                Excel.Worksheet epo = po.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;  // getting access //
                                epo.Cells[i, 1] = txt_name.Text;
                                epo.Cells[i, 2] = per;
                                pbook.Close(true, Type.Missing, Type.Missing); // Exiting Excel file //
                                po.Quit();  // Quiting created excel file //
                                Properties.Settings.Default.cl = txt_class.Text;
                                Properties.Settings.Default.num = txt_num.Text;
                                Properties.Settings.Default.term = txt_term.Text;
                                Properties.Settings.Default.year = txt_year.Text;
                                Properties.Settings.Default.date = txt_date.Text;
                                Properties.Settings.Default.Save();

                                if (chk_open.Checked && int.Parse(txt_num.Text) != i)
                                {
                                    Process.Start(pah + @"\" + txt_name.Text + ".xlsx"); // opening excel file just created //
                                }
                                else
                                {
                                    open = pah + @"\" + txt_name.Text + ".xlsx";
                                }
                                mark_chem.Text = ""; mark_phy.Text = ""; mark_urdu.Text = ""; mark_eng.Text = ""; mark_math.Text = ""; mark_isl.Text = ""; mark_pk.Text = ""; mark_phy.Text = ""; mark_comp.Text = ""; txt_name.Text = ""; txt_roll.Text = ""; // making the textboxes of all subjects empty //
                                txt_name.Focus();
                                Properties.Settings.Default.i = i;
                                Properties.Settings.Default.Save();
                                if (Properties.Settings.Default.i == 0)  // if saved variable i is 0 //
                                {
                                    btn_end.Enabled = false; // disabling end button //
                                }
                                else // NOT(if) //
                                {
                                    txt_num.Enabled = false;  // disabling strenth textbox //
                                    txt_class.Enabled = false; // disabling class textbox //
                                    txt_year.Enabled = false;  // disabling year textbox //
                                    txt_term.Enabled = false;  // disabling term textbox //
                                    txt_date.Enabled = false;  // disabling date textbox //
                                    drop_month.Enabled = false;  // disabling month dropbox/combobox  //
                                    btn_end.Enabled = true;  // enabling end button //
                                    btn_path.Enabled = false;
                                }
                                if (int.Parse(txt_num.Text) == i)
                                {
                                    Advanced();
                                }

                            }
                            catch (Exception r) // When unexpected error occurs //
                            {
                                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Displaying errors through messagebox //
                            }
                        }
                        else
                        {
                            Advanced();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The result of student named " + txt_name.Text + " already exists in the selected directory!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Displaying a mistake through messagebox //
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter valid enteries.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Validation for invalid data //
                }
            }
            else
            {
                MessageBox.Show("Please fill all the feilds!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Displaying errors through messagebox //
            }
            btn_create.Text = "Create Result";
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            if (!panel_path.Visible)  // if path panel is visible or not and taking steps accordingly //
            {
                tran.ShowSync(panel_path);  // Showing panel with a manually defined transition on designer page //
            }
            else
            {
                tran.HideSync(panel_path);  // hiding panel with a manually defined transition on designer page //
            }
        }

        private void btn_bpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();  // Creating a Window for path selection //
            if (path.ShowDialog() == DialogResult.OK)  // if User selects the path and clicks OK //
            {
                txt_path.Text = path.SelectedPath;  // make path textbox equal to selected user path //
                Properties.Settings.Default.path = path.SelectedPath;  // Entering path on variable //
                pah = path.SelectedPath;  // Entering path on variable //
                Properties.Settings.Default.Save();  // Saving Variable in computer storage //
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            End();  // Executing a defined Step //
        }

        void Advanced()
        {
            try
            {
                btn_create.Text = "Positioning...";
                Excel.Application po = new Excel.Application();  // Creating Excel variable //
                Excel.Workbook pbook = po.Workbooks.Open(pah + @"\positon.xlsx");  // Naming path //
                Excel.Worksheet epo = po.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;  // getting access to vorkzheet//
                int n = 1;
                Excel.Application file = new Excel.Application();  // Creating Excel file //

                while (int.Parse(txt_num.Text) >= n)  // Applying required loop //
                {
                    string name = epo.Cells[n,1].Value();
                    double num = epo.Cells[n, 3].Value();
                    
                    Excel.Workbook book = file.Workbooks.Open(pah + @"\" + name + ".xlsx");  // Importing layout //
                    Excel.Worksheet efile = file.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;  // Implimenting layout on Excel file //
                    efile.Cells[24,7] = num;
                    book.Close(true, Type.Missing, Type.Missing); // Exiting Excel file //
                    n += 1;
                }

                file.Quit();
                pbook.Close(true, Type.Missing, Type.Missing); // Exiting Excel file //
                po.Quit();  // Quiting file //
                End();  // Executing a defined Step //
                if (chk_open.Checked)
                {
                    Process.Start(open);
                }
                Process.Start(pah);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                i -= 1;
            }
        }
        private void chk_open_OnChange(object sender, EventArgs e)
        {
            if (chk_open.Checked)
            {
                Properties.Settings.Default.open = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.open = false;
                Properties.Settings.Default.Save();
            }
        }

        void End()
        {
            i = 0;
            Properties.Settings.Default.i = i;
            Properties.Settings.Default.Save();
            txt_name.Enabled = true;
            txt_num.Enabled = true;
            txt_class.Enabled = true;
            txt_year.Enabled = true;
            txt_term.Enabled = true;
            txt_date.Enabled = true;
            drop_month.Enabled = true;
            btn_path.Enabled = true;
            Properties.Settings.Default.cl = "";
            Properties.Settings.Default.num = "";
            Properties.Settings.Default.term = "";
            Properties.Settings.Default.year = "";
            Properties.Settings.Default.date = "";
            txt_class.Text = "";
            txt_roll.Text = "";
            txt_term.Text = "";
            txt_num.Text = "";
            txt_year.Text = "";
            txt_date.Text = "";
            Properties.Settings.Default.Save();
            btn_end.Enabled = false;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            btn_chk.Text = "Checking...";  // changing the update button text to changing... //
            int de;
            if (InternetGetConnectedState(out de, 0).ToString().ToUpper() == "TRUE")  // checking if the inetrnet connection bool is true or false and taking steps accordingly //
	        {
                /*System.Threading.Thread thread = new System.Threading.Thread(() =>
                {
                    Uri uri = new Uri(@"https://icier-sockets.000webhostapp.com/wp-content/uploads/2021/10/ver.txt");  // assinging url of version file //
                    string filename = Path.GetFileName(uri.AbsolutePath); 
                    client.DownloadFileAsync(uri,@"\Update\" + filename);
                    
                });
                thread.Start();*/
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("No updates available!! You are already uptodate.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }
            else
            {
                MessageBox.Show("Please check your internet connection and try again.", "Internet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_chk.Text = "Check For Updates";
        }

        void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            /*using (StreamReader r = new StreamReader(@"Update\ver.txt"))
            {
                ver = r.ReadLine();
                MessageBox.Show(r.ReadLine());
            }
            if (double.Parse(ver) > double.Parse(Properties.Settings.Default.ver))
            {
                DialogResult r = MessageBox.Show("Updates available!! Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Update u = new Update();
                    u.Show();
                }
            }
            else
            {
                MessageBox.Show("No updates available!! You are already uptodate.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/




            Update u = new Update();
            u.Show();
        }

        private void btn_tut_Click(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (!panel_option.Visible)  // if path panel is visible or not and taking steps accordingly //
            {
                tran.ShowSync(panel_option);  // Showing panel with a manually defined transition on designer page //
            }
            else
            {
                tran.HideSync(panel_option);  // hiding panel with a manually defined transition on designer page //
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Settings f = new Settings();
            f.Show();
        }
    }
}