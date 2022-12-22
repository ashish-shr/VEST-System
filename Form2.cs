using System;
using System.Windows.Forms;
using VEST;

namespace VEST_System_3._0
{

    /*
     Attributions
        
    <a href="https://www.flaticon.com/free-icons/mint" title="mint icons">Mint icons created by Aldo Cervantes - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/grass" title="grass icons">Grass icons created by Freepik - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/big-data" title="big data icons">Big data icons created by Freepik - Flaticon</a>
    https://icons8.com/
    <a href="https://www.flaticon.com/free-icons/add" title="add icons">Add icons created by Flat Icons - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/clear" title="clear icons">Clear icons created by Pixel perfect - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/remove-database" title="remove database icons">Remove database icons created by Yogi Aprelliyanto - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/question" title="question icons">Question icons created by Roundicons - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/link" title="link icons">Link icons created by Freepik - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/poem" title="poem icons">Poem icons created by Smashicons - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/research" title="research icons">Research icons created by geotatah - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/result" title="result icons">Result icons created by Freepik - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/table" title="table icons">Table icons created by Flat Icons - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/location" title="location icons">Location icons created by Freepik - Flaticon</a>
    <a href="https://www.flaticon.com/free-icons/attribute" title="attribute icons">Attribute icons created by Iconpro86 - Flaticon</a>
     
     */
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }

            if (MessageBox.Show("Confirm if you want to exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            {
                            e.Cancel = true;
            }
        }


        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("References used for developing the application: -\r\n\r\nCFD. (2004). Community Forest Resource Survey Guideline (Improved). Ministry of Forests & Environment, Department of Forests, Community Forest Division. Kathmandu, Nepal.\r\n\r\nGoN. (2022 ). Forest Regulation-2079 B.E. Government of Nepal, Ministry of Forests & Environment. Singhadurbar, Kathmandu, Nepal.\r\n\r\nMoFE. (2020). Current Status of Community Based Forest Management. Ministry of Forests & Environment. Singhadurbar, Kathmandu, Nepal.\r\n\r\nRai, C. B., & Beek, R. A. (1998). Simple Participatory Forest Inventory & Data Processing:Guidelines for the Preparation of the Forest Management Plan. Swiss Agency for Development & Cooperation (SDC), Nepal Swiss Community Forestry Project. Charikot, Nepal.\r\n\r\nSharma, E. R., & Pukkala, T. (1990). Volume Tables for Forest Trees of Nepal (Publication 48). Ministry of Forests & Soil Conservation, Forest Survey & Statistics Division. Kathmandu, Nepal.\r\n\r\nTIFSC. (2002). Community Forest Inventory Guideline (Manual 1). Tree Improvement & Forest Silviculture Component, Community Forest Division, Department of Forests. Kathmandu, Nepal.\r\n\r\nYadav, N. P., Paudel, K. N., Acharya, M. H., & Subedi, R. (2001). Manual of Forest Resource Inventory & Yield Regulation for Community Forest Management. Livelihood and Forestry Program (LFP). Kathmandu, Nepal.\r\n", "References", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hello User! Please respect the creation!\r\n\r\nThank you for choosing the application Volume Estimator of the Standing Tree System (VEST System). \r\n\r\nThis application has been successfully built by innovative ideas of Mr. Ashish Shrestha (2003) and Mr. T.N. Shrestha (1972). Mr. Ashish is 10+2 passed in Computer Science (3.34 CGPA) from Hetauda School of Management (HSM) Makwanpur in 2022. He is now a student of Bachelor in Information Communication Technology Education (BICTE) from T.U. Nepal. Mr. T.N. Shrestha, enriched with years of working experience in the forestry sector, is a gold medalist with a 3.67 CGPA in Master of Science in Forestry (M.Sc. Forestry) from Agriculture and Forestry University, Bharatpur, Chitwan, Nepal.\r\n\r\nThis application 'VEST' is a Windows-based tool that works in a GUI environment. It accurately and promptly estimates different types of the volume of standing trees of 23 Nepalese tree species based upon the tree data entered. It facilitates you to estimate stem volume (over-bark), the bark volume ratio of the whole stem, stem volume (under-bark), the branch volume ratio of stem volume, total tree volume (over-bark), 10cm top diameter ratio, gross volume (over-bark) for stem thicker than 10cm top diameter, net timber volume (over-bark) in cubic meter and cubic feet and firewood volume in cubic meter and chatta (333.33 cft solid volume). Also, you can export the data and analyzed results to the Microsoft Excel program and adjust it before getting printed according to the need of your work culture.\r\n\r\nThe application is based upon volume equations of 23 Nepalese tree species which were devised by E.R.Sharma and T.Pukkala (1990). Therefore, the authors are highly indebted to Sharma & Pukkala (1990). The most important fact is that this application exactly works in line with the Annex-9 of Forest Regulation (2022) enacted by the Government of Nepal. The authors have referred to the Forest Rule-2022 in the greatest depth possible. The application can be installed either on your desktop or laptop computer and can be used without an internet connection. The authors express their heartfelt gratitude to all the authors, publishers, and institutions whom they referred to while developing this application.\r\n\r\nThis application has been dedicatedly built for use by community-based forest users, family forest users, and private forest users including users, managers, and forest technicians of all types of management regimes of national forests to save time, effort, and gain optimum accuracy in volume estimation of standing trees of given species. As the rules and regulation changes with time, the authors of this application are committed to updating it as needed.\r\n\r\nTo learn how to use the VEST System, please refer to the VEST Guideline found inside the application Setup folder. You could also refer to the Tutorial Video found public on the authors' Youtube channels.\r\n\r\nIf you have any queries about this computer application, please feel free to contact the authors in: \r\n      \r\nAshish Shrestha, BICTE (ash.shrestha0360@gmail.com)\r\nT. N. Shrestha, M.Sc. Forestry (tankanarayanshrestha2000@gmail.com)\r\n\nVEST Team\r\n\r\n", "Author's Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kryptonLabel9_Click(object sender, EventArgs e)
        {

        }


        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            String branching_patt = "";
            if (kryptonRadioButton1.Checked == true)
            {
                branching_patt = "With Branch";
            }

            else if (kryptonRadioButton2.Checked == true)
            {
                branching_patt = "Without Branch";
            }

            if (String.IsNullOrWhiteSpace(sn.Text) || String.IsNullOrWhiteSpace(mn.Text) || String.IsNullOrWhiteSpace(sp.Text) || String.IsNullOrEmpty(branching_patt) || String.IsNullOrWhiteSpace(db.Text) || String.IsNullOrWhiteSpace(dbc.Text) || String.IsNullOrWhiteSpace(hg.Text) || String.IsNullOrWhiteSpace(tc.Text))
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Add to Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!kryptonRadioButton1.Checked && !kryptonRadioButton2.Checked)
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Add to Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(forest_Name.Text) || String.IsNullOrWhiteSpace(manage.Text) || String.IsNullOrWhiteSpace(plot_Name.Text) || String.IsNullOrWhiteSpace(pv.Text) || String.IsNullOrWhiteSpace(dist.Text) || String.IsNullOrWhiteSpace(x_cor.Text) || String.IsNullOrWhiteSpace(y_cor.Text) || String.IsNullOrWhiteSpace(ham.Text) || String.IsNullOrWhiteSpace(mark_Color.Text) || String.IsNullOrWhiteSpace(palika.Text))
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrWhiteSpace(stemVol_ob.Text) || String.IsNullOrWhiteSpace(barkRatio.Text) || String.IsNullOrWhiteSpace(stemVol_ub.Text) || String.IsNullOrWhiteSpace(bran_vol_ratio.Text) || String.IsNullOrWhiteSpace(treeVol_ob.Text) || String.IsNullOrWhiteSpace(topDia.Text) || String.IsNullOrWhiteSpace(grossVol_ob.Text) || String.IsNullOrWhiteSpace(timberVol_ob.Text) || String.IsNullOrWhiteSpace(timberVol_cft.Text) || String.IsNullOrWhiteSpace(fireWood_ob.Text)
                || String.IsNullOrWhiteSpace(fireWood_cht.Text) || String.IsNullOrWhiteSpace(sm_tim_vol_ratio.Text) || String.IsNullOrWhiteSpace(sm_tim_vol.Text) || String.IsNullOrWhiteSpace(big_tim_vol.Text))
            {
                MessageBox.Show("The data is not analyzed yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                kryptonDataGridView1.Rows.Add(pv.Text, dist.Text, division.Text, sub_div.Text, palika.Text, forest_Name.Text, manage.Text, block_No.Text, plot_Name.Text, ham.Text, mark_Color.Text, fis_year.Text, mark_date.Text, sn.Text, mn.Text, x_cor.Text, y_cor.Text, sp.Text, branching_patt, db.Text, dbc.Text, dev_stat.Text, hg.Text, tc.Text, stemVol_ob.Text, barkRatio.Text, stemVol_ub.Text, bran_vol_ratio.Text, treeVol_ob.Text, topDia.Text, grossVol_ob.Text, timberVol_ob.Text, timberVol_cft.Text, fireWood_ob.Text, fireWood_cht.Text, sm_tim_vol_ratio.Text, sm_tim_vol.Text, big_tim_vol.Text);



                stemVol_ob.Text = "";
                barkRatio.Text = "";
                stemVol_ub.Text = "";
                bran_vol_ratio.Text = "";
                treeVol_ob.Text = "";
                topDia.Text = "";
                grossVol_ob.Text = "";
                timberVol_ob.Text = "";
                timberVol_cft.Text = "";
                fireWood_ob.Text = "";
                fireWood_cht.Text = "";
                sm_tim_vol_ratio.Text = "";
                sm_tim_vol.Text = "";
                big_tim_vol.Text = "";
                MessageBox.Show("Data was added to the table successfully!", "Add to table", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        private void sn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(sn.Text) || String.IsNullOrWhiteSpace(mn.Text) || String.IsNullOrWhiteSpace(sp.Text) || String.IsNullOrWhiteSpace(db.Text) || String.IsNullOrWhiteSpace(dbc.Text) || String.IsNullOrWhiteSpace(hg.Text) || String.IsNullOrWhiteSpace(tc.Text) || String.IsNullOrWhiteSpace(dev_stat.Text) || String.IsNullOrWhiteSpace(x_cor.Text) || String.IsNullOrWhiteSpace(y_cor.Text))
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Analyze the Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!kryptonRadioButton1.Checked && !kryptonRadioButton2.Checked)
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Add to Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(forest_Name.Text) || String.IsNullOrWhiteSpace(manage.Text) || String.IsNullOrWhiteSpace(plot_Name.Text) || String.IsNullOrWhiteSpace(pv.Text) || String.IsNullOrWhiteSpace(dist.Text) || String.IsNullOrWhiteSpace(ham.Text) || String.IsNullOrWhiteSpace(mark_Color.Text) || String.IsNullOrWhiteSpace(palika.Text) || String.IsNullOrWhiteSpace(sub_div.Text) || String.IsNullOrWhiteSpace(division.Text) || String.IsNullOrWhiteSpace(block_No.Text) || String.IsNullOrWhiteSpace(fis_year.Text) || String.IsNullOrWhiteSpace(mark_date.Text))
            {
                MessageBox.Show("Either the General or Data fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string usr_sp = sp.Text.ToString();
                string usr_tc = tc.Text.ToString();

                float usr_hg = float.Parse(hg.Text);
                float usr_dbh = float.Parse(db.Text);
                int usr_dbc = int.Parse(dbc.Text);
                Single usr_vol, usr_finalVol;


                Single tmp_barkRatio, usr_barkRatio, usr_stemVol_ub, usr_treeVol_ob, usr_tmp_topDia, usr_topDia, usr_tmp_grossVol_ob, usr_grossVol_ob, usr_tmp_timberVol_ob, usr_timberVol_ob, usr_tmp_timberVol_cft, usr_timberVol_cft, usr_tmp_fireWood_ob, usr_fireWood_ob, usr_tmp_fireWood_cht, usr_fireWood_cht, usr_bran_vol_ratio, usr_sm_tim_vol_ratio, usr_sm_timber_vol, usr_big_tim_vol;


                if (String.Equals(usr_sp, "Shorea robusta (Sal, Sakhuwa)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 8.156 + (-2.8365) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.4554 + (1.9026 * Math.Log(usr_dbh)) + 0.8352 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.1372 + (-0.4182) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();


                    usr_tmp_topDia = (((float)(5.2026 + (-2.4788) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.055";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.341 + (40 - usr_dbh) * 0.055) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.357 + (70 - usr_dbh) * 0.341) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.357";
                        }
                    }

                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }

                else if (String.Equals(usr_sp, "Abies pindrow (Fir)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 9.0316 + (-3.1527) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.4453 + 1.7220 * Math.Log(usr_dbh) + 1.0757 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.0552 + (-0.4804) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.4443 + (-2.6902) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.436";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.372 + (40 - usr_dbh) * 0.436) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.355 + (70 - usr_dbh) * 0.372) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.355";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Acacia catechu (Khayar)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 8.3845 + (-2.8693) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3256 + 1.6476 * Math.Log(usr_dbh) + 1.0552 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.0368 + (-0.4852) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();


                    usr_tmp_topDia = (((float)(5.4401 + (-2.491) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }

                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = float.Parse(stemVol_ob.Text);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = float.Parse(stemVol_ob.Text);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = float.Parse(stemVol_ob.Text);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = float.Parse(stemVol_ob.Text);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }



                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - treeVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Adina cordifolia (Karma, Haldu)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.6404 + (-2.6695) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();
                    usr_vol = (float)(-2.5626 + 1.8598 * Math.Log(usr_dbh) + 0.8783 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.4428 + (-0.2575) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.4681 + (-2.4398) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }

                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Albizzia spp. (Siris)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.9419 + (-2.7343) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.4284 + 1.7609 * Math.Log(usr_dbh) + 0.9662 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.3809 + ((-0.5361) * Math.Log(usr_dbh)))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.4031 + (-2.2094) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }





                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Alnus nepalensis (Uttis)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.8979 + (-2.7867) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.7761 + 1.9006 * Math.Log(usr_dbh) + 0.9428 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-1.3593 + (-0.2015) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(6.019 + (-2.7271) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.055";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.341 + (40 - usr_dbh) * 0.055) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.357 + (70 - usr_dbh) * 0.341) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.357";
                        }

                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Anogeisus latifolia (Banjhi)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.7573 + (-2.6716) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.2720 + 1.7499 * Math.Log(usr_dbh) + 0.9174 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.2515 + (-0.6053) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.9502 + (-2.3353) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();




                }
                else if (String.Equals(usr_sp, "Bombax malabaricum (Semal)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 6.4019 + (-2.3873) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3865 + 1.7414 * Math.Log(usr_dbh) + 1.0063 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(1.0876 + (-0.6846) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.5554 + (-2.3009) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Cedrela toona (Tuni)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, (7.3734 + (-2.5998) * Math.Log(usr_dbh)));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.1832 + 1.8679 * Math.Log(usr_dbh) + 0.7569 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.33 + (-0.4853) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.9705 + (-2.3436) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Dalbergia sissoo (Sissoo)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 6.8821 + (-2.44) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.1959 + 1.6567 * Math.Log(usr_dbh) + 0.9899 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.0408 + (-0.4218) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.358 + (-2.1559) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.684";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.684 + (40 - usr_dbh) * 0.684) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.684 + (70 - usr_dbh) * 0.684) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.684";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }


                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Eugenia jambolana (Jamun)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.6807 + (-2.6648) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.5693 + 1.8816 * Math.Log(usr_dbh) + 0.8498 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.1451 + (-0.3617) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.1749 + (-2.3636) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();




                }
                else if (String.Equals(usr_sp, "Hymenodictyon excelsum (Bhudkul)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 6.825 + (-2.4603) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.5850 + 1.9437 * Math.Log(usr_dbh) + 0.7902 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.4405 + (-0.4755) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.5572 + (-2.496) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Lagerstroemia parviflora (Botdhairo)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.2637 + (-2.5282) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3411 + 1.7246 * Math.Log(usr_dbh) + 0.9702 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.6336 + (-0.6531) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.3349 + (-2.4488) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();



                }
                else if (String.Equals(usr_sp, "Michelia champaca (Champ)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 6.7852 + (-2.4567) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.0152 + 1.8555 * Math.Log(usr_dbh) + 0.7630 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.1672 + (-0.4535) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(3.3499 + (-2.0161) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }

                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Pinus roxburghii (Khotesalla)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 8.5662 + (-3.0486) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.9770 + 1.9235 * Math.Log(usr_dbh) + 1.0019 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(1.1876 + (-0.7029) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(6.2696 + (-2.8252) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.189";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.256 + (40 - usr_dbh) * 0.189) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.300 + (70 - usr_dbh) * 0.256) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.300";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Pinus wallichiana (Gobresalla)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, ((8.1696 + (-2.8862) * Math.Log(usr_dbh))));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.8195 + 1.7250 * Math.Log(usr_dbh) + 1.1623 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.2438 + (-0.6214) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.7216 + (-2.6788) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.683";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.488 + (40 - usr_dbh) * 0.683) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.410 + (70 - usr_dbh) * 0.488) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.410";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Quercus spp. (Oak)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.0779 + ((-2.5739) * Math.Log(usr_dbh)));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3600 + 1.9680 * Math.Log(usr_dbh) + 0.7469 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.4146 + (-0.4193) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.8511 + (-2.4494) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.747";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.960 + (40 - usr_dbh) * 0.747) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 1.060 + (70 - usr_dbh) * 0.960) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "1.060";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Schima wallichii (Chilaune)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 8.5074 + (-2.8908) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.7385 + 1.8155 * Math.Log(usr_dbh) + 1.0072 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.9782 + (-0.5657) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(7.4617 + (-3.0676) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.520";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.186 + (40 - usr_dbh) * 0.520) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.168 + (70 - usr_dbh) * 0.186) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.168";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Terminalia tomentosa (Asna, Saj)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 7.4095 + (-2.6093) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.4616 + 1.8497 * Math.Log(usr_dbh) + 0.8800 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.0572 + (-0.4114) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.5968 + (-2.2305) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.055";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.341 + (40 - usr_dbh) * 0.055) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.357 + (70 - usr_dbh) * 0.341) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.357";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Trewia nudiflora (Gutel)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, ((7.448 + (-2.6313) * Math.Log(usr_dbh))));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.4585 + 1.8043 * Math.Log(usr_dbh) + 0.9220 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.4918 + (-0.4689) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.3475 + (-2.4774) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();

                }
                else if (String.Equals(usr_sp, "Tsuga spp.(Hemlock)"))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, (7.5935 + (-2.7629) * Math.Log(usr_dbh)));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.5293 + 1.7815 * Math.Log(usr_dbh) + 1.0369 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.2186 + (-0.4796) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.2774 + ((-2.6483) * Math.Log(usr_dbh)))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.436";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.372 + (40 - usr_dbh) * 0.436) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.355 + (70 - usr_dbh) * 0.372) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.355";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();


                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();


                }
                else if (String.Equals(usr_sp, "Miscellaneous Terai spp."))
                {
                    usr_sm_tim_vol_ratio = (float)Math.Pow(Math.E, 6.7548 + (-2.4589) * Math.Log(usr_dbh));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3993 + 1.7836 * Math.Log(usr_dbh) + 0.9546 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(0.1634 + ((-0.5581) * Math.Log(usr_dbh)))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(4.8991 + (-2.3406) * Math.Log(usr_dbh))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }

                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();

                }
                else if (String.Equals(usr_sp, "Miscellaneous Hill spp."))
                {
                    usr_sm_tim_vol_ratio = ((float)Math.Pow(Math.E, (7.0759 + (-2.5336) * Math.Log(usr_dbh))));
                    sm_tim_vol_ratio.Text = usr_sm_tim_vol_ratio.ToString();

                    usr_vol = (float)(-2.3204 + 1.8507 * Math.Log(usr_dbh) + 0.8223 * Math.Log(usr_hg));
                    usr_finalVol = (float)(Math.Pow(Math.E, usr_vol)) / 1000;
                    stemVol_ob.Text = usr_finalVol.ToString();
                    tmp_barkRatio = (((float)(-0.3878 + (-0.3159) * Math.Log(usr_dbh))));
                    usr_barkRatio = (float)(Math.Pow(Math.E, tmp_barkRatio));
                    barkRatio.Text = usr_barkRatio.ToString();
                    usr_stemVol_ub = usr_finalVol * (1 - usr_barkRatio);
                    stemVol_ub.Text = usr_stemVol_ub.ToString();

                    usr_tmp_topDia = (((float)(5.5323 + ((-2.4815) * Math.Log(usr_dbh)))));
                    usr_topDia = (float)Math.Pow(Math.E, usr_tmp_topDia);
                    topDia.Text = usr_topDia.ToString();
                    usr_tmp_grossVol_ob = usr_finalVol * (1 - usr_topDia);
                    usr_grossVol_ob = usr_tmp_grossVol_ob;
                    grossVol_ob.Text = usr_grossVol_ob.ToString();
                    if (String.Equals(usr_tc, "1"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.8);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "2"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.6);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "3"))
                    {
                        usr_tmp_timberVol_ob = (float)(usr_grossVol_ob * 0.3);
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    else if (String.Equals(usr_tc, "4"))
                    {
                        usr_tmp_timberVol_ob = usr_grossVol_ob * 0;
                        usr_timberVol_ob = usr_tmp_timberVol_ob;
                        timberVol_ob.Text = usr_timberVol_ob.ToString();
                    }
                    if (kryptonRadioButton1.Checked)
                    {
                        if (usr_dbc == 1)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                        else if (usr_dbc == 2)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 10) * 0.4 + (40 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 3)
                        {
                            usr_bran_vol_ratio = (float)(((usr_dbh - 40) * 0.4 + (70 - usr_dbh) * 0.4) / 30);
                            bran_vol_ratio.Text = usr_bran_vol_ratio.ToString();
                        }
                        else if (usr_dbc == 4)
                        {
                            bran_vol_ratio.Text = "0.4";
                        }
                    }
                    else if (kryptonRadioButton2.Checked)
                    {
                        bran_vol_ratio.Text = "0";
                    }
                    float bran_vol_ratio_tmp = float.Parse(bran_vol_ratio.Text);
                    usr_treeVol_ob = usr_finalVol * (1 + bran_vol_ratio_tmp);
                    treeVol_ob.Text = usr_treeVol_ob.ToString();

                    float timberVol_ob_tmp = float.Parse(timberVol_ob.Text);
                    usr_tmp_timberVol_cft = (float)(timberVol_ob_tmp * 35.3147);
                    usr_timberVol_cft = usr_tmp_timberVol_cft;
                    timberVol_cft.Text = usr_timberVol_cft.ToString();

                    float treeVol_ob_tmp = float.Parse(treeVol_ob.Text);
                    usr_tmp_fireWood_ob = (treeVol_ob_tmp - timberVol_ob_tmp);
                    usr_fireWood_ob = usr_tmp_fireWood_ob;
                    fireWood_ob.Text = usr_fireWood_ob.ToString();
                    usr_tmp_fireWood_cht = (float)(usr_fireWood_ob * 0.105944);
                    usr_fireWood_cht = usr_tmp_fireWood_cht;
                    fireWood_cht.Text = usr_fireWood_cht.ToString();



                    usr_sm_timber_vol = usr_grossVol_ob * usr_sm_tim_vol_ratio;
                    sm_tim_vol.Text = usr_sm_timber_vol.ToString();
                    usr_big_tim_vol = usr_grossVol_ob - usr_sm_timber_vol;
                    big_tim_vol.Text = usr_big_tim_vol.ToString();

                }
            }
        }

        private void mn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void db_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void dbc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void hg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

            if (String.Equals(msg, label_status.Text))
            {
                DialogResult res = MessageBox.Show("The table is empty!", "Clean Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (MessageBox.Show("Are you sure to clear the table?", "Clear Table", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {


                    for (int i = 0; i < kryptonDataGridView1.RowCount; i++)
                    {
                        kryptonDataGridView1.Rows.Clear();

                    }
                }
            }

        }

        string msg = "0 Data Added.";

        private void kryptonButton7_Click(object sender, EventArgs e)
        {

            if (String.Equals(msg, label_status.Text))
            {
                DialogResult res = MessageBox.Show("The table is empty!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (MessageBox.Show("Are you sure to remove the row?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.kryptonDataGridView1.SelectedRows)
                    {

                        kryptonDataGridView1.Rows.RemoveAt(item.Index);
                    }

                }
            }

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            if (String.Equals(msg, label_status.Text))
            {
                DialogResult res = MessageBox.Show("The table is empty!", "Export Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Are you sure to export the table?", "Export Table", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    for (int i = 1; i < kryptonDataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = kryptonDataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < kryptonDataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < kryptonDataGridView1.Columns.Count; j++)
                        {
                            if (kryptonDataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = kryptonDataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }
                }
            }

        }

        private void db_TextChanged(object sender, EventArgs e)
        {

            if (String.Equals(db.Text, ""))
            {
                dbc.Text = "";
            }
            else if (float.Parse(db.Text) < 10)
            {
                dbc.Text = "1";
            }
            else if (float.Parse(db.Text) < 40)
            {
                dbc.Text = "2";
            }
            else if (float.Parse(db.Text) < 70)
            {
                dbc.Text = "3";
            }
            else
                dbc.Text = "4";

            if (String.Equals(db.Text, ""))
            {
                dev_stat.Text = "";
            }
            else if (float.Parse(db.Text) < 10)
            {
                dev_stat.Text = "Seedling/Sapling";
            }
            else if (float.Parse(db.Text) >= 10 && float.Parse(db.Text) <= 19.9)
            {
                dev_stat.Text = "Small Poles";
            }
            else if (float.Parse(db.Text) >= 20 && float.Parse(db.Text) <= 29.9)
            {
                dev_stat.Text = "Big Poles";
            }
            else if (float.Parse(db.Text) >= 30 && float.Parse(db.Text) <= 39.9)
                dev_stat.Text = "Young Trees";
            else if (float.Parse(db.Text) >= 40)
            {
                dev_stat.Text = "Mature Trees";
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void sn_Click(object sender, EventArgs e)
        {
            sn.SelectAll();
        }

        private void mn_Click(object sender, EventArgs e)
        {
            mn.SelectAll();
        }



        private void db_Click(object sender, EventArgs e)
        {
            db.SelectAll();
        }

        private void dbc_Click(object sender, EventArgs e)
        {
            dbc.SelectAll();
        }

        private void hg_Click(object sender, EventArgs e)
        {
            hg.SelectAll();
        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Attributions: -\r\n\r\nThe icons used in this application are downloaded from the following websites:-\r\nhttps://icons8.com/\r\nhttps://www.flaticon.com/", "Attributions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void topDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void palika_Click(object sender, EventArgs e)
        {
            palika.SelectAll();
        }

        private void forest_Name_Click(object sender, EventArgs e)
        {
            forest_Name.SelectAll();
        }

        private void block_No_Click(object sender, EventArgs e)
        {
            block_No.SelectAll();
        }

        private void plot_Name_Click(object sender, EventArgs e)
        {
            plot_Name.SelectAll();
        }

        private void ham_Click(object sender, EventArgs e)
        {
            ham.SelectAll();
        }

        private void mark_Color_Click(object sender, EventArgs e)
        {
            mark_Color.SelectAll();
        }

        private void x_cor_Click(object sender, EventArgs e)
        {
            x_cor.SelectAll();
        }

        private void y_cor_Click(object sender, EventArgs e)
        {
            y_cor.SelectAll();
        }

        private void kryptonLabel10_Click(object sender, EventArgs e)
        {

        }

        private void fis_year_Click(object sender, EventArgs e)
        {
            fis_year.SelectAll();
        }

        private void mark_date_Click(object sender, EventArgs e)
        {
            mark_date.SelectAll();
        }



        private void Clear()
        {
            if (kryptonRadioButton1.Checked)
            {
                kryptonRadioButton1.Checked = false;

            }
            else if (kryptonRadioButton2.Checked)
            {
                kryptonRadioButton2.Checked = false;

            }
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {

            sn.Text = "";
            mn.Text = "";
            x_cor.Text = "";
            y_cor.Text = "";
            sp.SelectedIndex = -1;
            Clear();
            db.Text = "";
            dbc.Text = "";
            dev_stat.Text = "";
            hg.Text = "";
            tc.SelectedIndex = -1;
            kryptonLabel42.Text = "";
            sn.Focus();
        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void kryptonLabel39_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = kryptonDataGridView1.RowCount - 1;
            label_status.Text = count.ToString() + " Data Added.";
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonLabel26_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton9_Click_1(object sender, EventArgs e)
        {
            pv.SelectedIndex = -1;
            dist.SelectedIndex = -1;
            division.Text = "";
            sub_div.Text = "";
            palika.Text = "";
            forest_Name.Text = "";
            manage.SelectedIndex = -1;
            block_No.Text = "";
            plot_Name.Text = "";
            ham.Text = "";
            mark_Color.Text = "";
            fis_year.Text = "";
            mark_date.Text = "";
            pv.Focus();
        }

        private void kryptonLabel40_Click(object sender, EventArgs e)
        {

        }



        private void tc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (String.Equals(tc.Text, "1"))
            {
                kryptonLabel42.Text = "* >70% timber output";
            }
            else if (String.Equals(tc.Text, "2"))
            {
                kryptonLabel42.Text = "* 50%-70% timber output";
            }
            else if (String.Equals(tc.Text, "3"))
            {
                kryptonLabel42.Text = "* 10%-50% timber output";
            }
            else if (String.Equals(tc.Text, "4"))
            {
                kryptonLabel42.Text = "* <10% timber; twisted, hollow and knotty";
            }
        }



        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Acronym and Clarification: -\r\n\r\nNP: National Park\r\nWLR: Wildlife Reserve\r\nRP: Range Post\r\nFPA: Forest Protection Area\r\nCA: Conservation Area\r\nDP: Development Project\r\nAF: Avenue Forest\r\nPF: Public Forest\r\nDivision: Division Forest Office\r\nSub-Division: Sub-Division Forest Office\r\nM.N.: Chhapan Serial Number\r\nDBH: Diameter at Breast Height (1.3 m from ground level)\r\nUB: Under Bark\r\nOB: Over Bark\r\nCft: Cubic Feet\r\nCum: Cubic Meter\r\nX-Coordinate: Longitude\r\nY-Coordinate: Latitude\r\nWith Branch: Tree whose branch is present at the time of measurement\r\nWithout Branch: Tree which is branchless at the time of measurement\r\nGross Volume: Stem volume excluding 10 cm top diameter volume\r\n", "Acronym and Clarification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/15TnrRxLhF0UH64lWXzr0lbtVyz8vmwui/view?usp=share_link");
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Disclaimer: -\r\nVEST is a computer application. It stands for Volume Estimator of Standing Tree. This computer application estimates net timber and firewood volume including other volume parameters of standing trees of 23 Nepalese tree species mentioned in Forest Rule-2022 of the Government of Nepal. However, this application could estimate volumes of lodging trees too. \r\nWe, the VEST team, hereby declare that this application has not been authorized by the Government of Nepal though it facilitates the same. We are independent developers. We have made it on our effort and expenditures. We have not taken any benefits from the Government of Nepal to design, build and release this application. \r\nTherefore, We, hereby, pre-inform our users that the results calculated with this application do not necessarily represent the Government of Nepal though it works in line with Forest Rule-2022 of the government. \r\nTherefore, if any dispute takes place in the past, present, or in future, where this application was used; this application, application designer, and developer shall not be liable for any type of legal, financial, or technical loss incurred by the users due to use of this application. We shall not be responsible for those losses. You must use this application on your responsibility. Thank you! \r\nVEST Team\r\n", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
