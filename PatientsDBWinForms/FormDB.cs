using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PatientsDBWinForms
{
    public partial class FormDB : Form
    {
        public FormDB()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                App.Patients.AddPatientsRow(App.Patients.NewPatientsRow());
                patientsBindingSource.MoveLast();
                tb_surname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Patients.RejectChanges();
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            tb_surname.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            patientsBindingSource.ResetBindings(false);
            panel.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ((tb_surname.ForeColor == System.Drawing.Color.Black) && (tb_first_name.ForeColor == System.Drawing.Color.Black) && (tb_second_name.ForeColor == System.Drawing.Color.Black))
            {
                try
                {
                    patientsBindingSource.EndEdit();
                    App.Patients.AcceptChanges();
                    App.Patients.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                    panel.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    App.Patients.RejectChanges();
                }
            }
            else MessageBox.Show("Поля прізвище, імя, по батькові мають бути заповнені та помилки повинні бути виправлені перед збереженням!");
            

        }

        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.Patients.ReadXml(fileName);
            patientsBindingSource.DataSource = App.Patients;
            panel.Enabled = false;
        }

        private void dGVPatients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (MessageBox.Show("Ви впевнені щодо видалення цього запису?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    patientsBindingSource.RemoveCurrent();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені щодо видалення цього запису?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                patientsBindingSource.RemoveCurrent();

        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені щодо видалення всіх записів бази даних?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                for (int i = 0; i < patientsBindingSource.Count; i++) patientsBindingSource.RemoveAt(i);
            for (int i = 0; i < patientsBindingSource.Count; i++) patientsBindingSource.RemoveAt(i);
            patientsBindingSource.RemoveCurrent();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            patientsBindingSource.Sort = "surname";

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                System.IO.File.Copy(open.FileName, open.FileName.Split('.')[0] + "_Copy." + open.FileName.Split('.')[1]);
                string imagename = open.SafeFileName;
                pictureBox.Image = img.GetThumbnailImage(340, 165, null, new IntPtr());
                open.RestoreDirectory = true;
            }
        }

        

        private void tb_surname_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_surname.Text.Length; i++)
            {
                if ((tb_surname.Text[i] >= '0' && tb_surname.Text[i] <= '9') || tb_surname.Text[i] == '!' || tb_surname.Text[i] == '@' || tb_surname.Text[i] == '#' || tb_surname.Text[i] == '$' || tb_surname.Text[i] == '%' || tb_surname.Text[i] == '^' || tb_surname.Text[i] == '&' || tb_surname.Text[i] == '*' || tb_surname.Text[i] == '?' || tb_surname.Text[i] == '+' || tb_surname.Text[i] == '=' || tb_surname.Text[i] == ',' || tb_surname.Text[i] == '.' || tb_surname.Text[i] == '/' || tb_surname.Text[i] == '₴' || tb_surname.Text[i] == ':' || tb_surname.Text[i] == ';')
                {
                    tb_surname.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_surname.ForeColor = System.Drawing.Color.Black;
        }

       
        private void tb_first_name_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_first_name.Text.Length; i++)
            {
                if ((tb_first_name.Text[i] >= '0' && tb_first_name.Text[i] <= '9') || tb_first_name.Text[i] == '!' || tb_first_name.Text[i] == '@' || tb_first_name.Text[i] == '#' || tb_first_name.Text[i] == '$' || tb_first_name.Text[i] == '%' || tb_first_name.Text[i] == '^' || tb_first_name.Text[i] == '&' || tb_first_name.Text[i] == '*' || tb_first_name.Text[i] == '?' || tb_first_name.Text[i] == '+' || tb_first_name.Text[i] == '=' || tb_first_name.Text[i] == ',' || tb_first_name.Text[i] == '.' || tb_first_name.Text[i] == '/' || tb_first_name.Text[i] == '₴' || tb_first_name.Text[i] == ':' || tb_first_name.Text[i] == ';')
                {
                    tb_first_name.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_first_name.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_second_name_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_second_name.Text.Length; i++)
            {
                if ((tb_second_name.Text[i] >= '0' && tb_second_name.Text[i] <= '9') || tb_second_name.Text[i] == '!' || tb_second_name.Text[i] == '@' || tb_second_name.Text[i] == '#' || tb_second_name.Text[i] == '$' || tb_second_name.Text[i] == '%' || tb_second_name.Text[i] == '^' || tb_second_name.Text[i] == '&' || tb_second_name.Text[i] == '*' || tb_second_name.Text[i] == '?' || tb_second_name.Text[i] == '+' || tb_second_name.Text[i] == '=' || tb_second_name.Text[i] == ',' || tb_second_name.Text[i] == '.' || tb_second_name.Text[i] == '/' || tb_second_name.Text[i] == '₴' || tb_second_name.Text[i] == ':' || tb_second_name.Text[i] == ';')
                {
                    tb_second_name.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_second_name.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_nationality_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_gender.Text.Length; i++)
            {
                if ((tb_gender.Text[i] >= '0' && tb_gender.Text[i] <= '9') || tb_gender.Text[i] == '!' || tb_gender.Text[i] == '@' || tb_gender.Text[i] == '#' || tb_gender.Text[i] == '$' || tb_gender.Text[i] == '%' || tb_gender.Text[i] == '^' || tb_gender.Text[i] == '&' || tb_gender.Text[i] == '*' || tb_gender.Text[i] == '?' || tb_gender.Text[i] == '+' || tb_gender.Text[i] == '=' || tb_gender.Text[i] == ',' || tb_gender.Text[i] == '.' || tb_gender.Text[i] == '/' || tb_gender.Text[i] == '₴' || tb_gender.Text[i] == ':' || tb_gender.Text[i] == ';')
                {
                    tb_gender.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_gender.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_height_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_height.Text.Length; i++)
            {
                if (!((tb_height.Text[i] >= '0' && tb_height.Text[i] <= '9') || tb_height.Text[i] == ','))
                {
                    tb_height.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_height.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_weight_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_weight.Text.Length; i++)
            {
                if (!((tb_weight.Text[i] >= '0' && tb_weight.Text[i] <= '9') || tb_weight.Text[i] == ',')) 
                {
                    tb_weight.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_weight.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_street_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_street.Text.Length; i++)
            {
                if ((tb_street.Text[i] >= '0' && tb_street.Text[i] <= '9') || tb_street.Text[i] == '!' || tb_street.Text[i] == '@' || tb_street.Text[i] == '#' || tb_street.Text[i] == '$' || tb_street.Text[i] == '%' || tb_street.Text[i] == '^' || tb_street.Text[i] == '&' || tb_street.Text[i] == '*' || tb_street.Text[i] == '?' || tb_street.Text[i] == '+' || tb_street.Text[i] == '=' || tb_street.Text[i] == ',' || tb_street.Text[i] == '.' || tb_street.Text[i] == '/' || tb_street.Text[i] == '₴' || tb_street.Text[i] == ':' || tb_street.Text[i] == ';')
                {
                    tb_street.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_street.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_house_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_house.Text.Length; i++)
            {
                if (tb_house.Text[i] == '!' || tb_house.Text[i] == '@' || tb_house.Text[i] == '#' || tb_house.Text[i] == '$' || tb_house.Text[i] == '%' || tb_house.Text[i] == '^' || tb_house.Text[i] == '&' || tb_house.Text[i] == '*' || tb_house.Text[i] == '?' || tb_house.Text[i] == '+' || tb_house.Text[i] == '=' || tb_house.Text[i] == ',' || tb_house.Text[i] == '.' || tb_house.Text[i] == '/' || tb_house.Text[i] == '₴' || tb_house.Text[i] == ':' || tb_house.Text[i] == ';')
                {
                    tb_house.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_house.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_flat_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_flat.Text.Length; i++)
            {
                if (!(tb_flat.Text[i] >= '0' && tb_flat.Text[i] <= '9'))
                {
                    tb_flat.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_house.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_district_number_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_district_number.Text.Length; i++)
            {
                if (!(tb_district_number.Text[i] >= '0' && tb_district_number.Text[i] <= '9'))
                {
                    tb_district_number.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_district_number.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_med_card_number_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_med_card_number.Text.Length; i++)
            {
                if (!(tb_med_card_number.Text[i] >= '0' && tb_med_card_number.Text[i] <= '9'))
                {
                    tb_med_card_number.ForeColor = System.Drawing.Color.Red;
                    mark++;
                }
            }
            if (mark == 0) tb_med_card_number.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_disease_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_disease.Text.Length; i++)
            {
                if ((tb_disease.Text[i] >= '0' && tb_disease.Text[i] <= '9') || tb_disease.Text[i] == '!' || tb_disease.Text[i] == '@' || tb_disease.Text[i] == '#' || tb_disease.Text[i] == '$' || tb_disease.Text[i] == '%' || tb_disease.Text[i] == '^' || tb_disease.Text[i] == '&' || tb_disease.Text[i] == '*' || tb_disease.Text[i] == '?' || tb_disease.Text[i] == '+' || tb_disease.Text[i] == '=' || tb_disease.Text[i] == ',' || tb_disease.Text[i] == '.' || tb_disease.Text[i] == '/' || tb_disease.Text[i] == '₴' || tb_disease.Text[i] == ':' || tb_disease.Text[i] == ';')
                {
                    tb_disease.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_disease.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_blood_type_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_blood_type.Text.Length; i++)
            {
                if (tb_blood_type.Text[i] == '!' || tb_blood_type.Text[i] == '@' || tb_blood_type.Text[i] == '#' || tb_blood_type.Text[i] == '$' || tb_blood_type.Text[i] == '%' || tb_blood_type.Text[i] == '^' || tb_blood_type.Text[i] == '&' || tb_blood_type.Text[i] == '*' || tb_blood_type.Text[i] == '?' || tb_blood_type.Text[i] == '=' || tb_blood_type.Text[i] == ',' || tb_blood_type.Text[i] == '.' || tb_blood_type.Text[i] == '/' || tb_blood_type.Text[i] == '₴' || tb_blood_type.Text[i] == ':' || tb_blood_type.Text[i] == ';')
                {
                    tb_blood_type.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_blood_type.ForeColor = System.Drawing.Color.Black;
        }

        private void tb_gender_TextChanged(object sender, EventArgs e)
        {
            int mark = 0;
            for (int i = 0; i < tb_nationality.Text.Length; i++)
            {
                if ((tb_nationality.Text[i] >= '0' && tb_nationality.Text[i] <= '9') || tb_nationality.Text[i] == '!' || tb_nationality.Text[i] == '@' || tb_nationality.Text[i] == '#' || tb_nationality.Text[i] == '$' || tb_nationality.Text[i] == '%' || tb_nationality.Text[i] == '^' || tb_nationality.Text[i] == '&' || tb_nationality.Text[i] == '*' || tb_nationality.Text[i] == '?' || tb_nationality.Text[i] == '+' || tb_nationality.Text[i] == '=' || tb_nationality.Text[i] == ',' || tb_nationality.Text[i] == '.' || tb_nationality.Text[i] == '/' || tb_nationality.Text[i] == '₴' || tb_nationality.Text[i] == ':' || tb_nationality.Text[i] == ';')
                {
                    tb_nationality.ForeColor = System.Drawing.Color.Red;
                    mark++;

                }
            }
            if (mark == 0) tb_nationality.ForeColor = System.Drawing.Color.Black;
        }
    }
}
