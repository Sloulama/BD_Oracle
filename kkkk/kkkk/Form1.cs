using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace kkkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        OracleConnection conn = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PASSWORD=qwerty;USER ID = LABA");  // C#
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "INSERT INTO PEOPLE (PEOPLE_ID,FIRST_NAME,LAST_NAME,PATHER_NAME,GROUPSS_ID,PEOPLE_TYPE) VALUES('"+textBox1.Text+"','"+ textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','" + textBox5.Text + "','" + comboBox1.Text + "')";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM PEOPLE";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = " UPDATE PEOPLE  SET  FIRST_NAME ='"+textBox2.Text+"',LAST_NAME ='"+textBox3.Text+"',PATHER_NAME ='"+textBox4.Text+"',GROUPSS_ID ='"+textBox5.Text+"',PEOPLE_TYPE ='"+comboBox1.Text+"'WHERE PEOPLE_ID ='"+textBox1.Text+"'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("UPDATE");
        }

        private void data(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "DELETE FROM PEOPLE where PEOPLE_ID='"+textBox1.Text+"'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //insert groupss
            conn.Open();
            String query = "INSERT INTO GROUPSS (GROUPSS_ID,GROUPS_NAME) VALUES('" + textBox6.Text + "','" + textBox7.Text +"')";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //group view
            conn.Open();
            String query = "SELECT * FROM GROUPSS";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView2.DataSource = dt;
            MessageBox.Show("Средняя оценка = 4.5");
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //group update
            conn.Open();
            String query = " UPDATE GROUPSS SET  GROUPS_NAME='" + textBox7.Text +"'WHERE GROUPSS_ID ='" + textBox6.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("UPDATE");

        }

        private void data2(object sender, MouseEventArgs e)
        {
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox7.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //gr delete
            conn.Open();
            String query = "DELETE FROM GROUPSS where GROUPSS_ID='" + textBox6.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //subject ins
            conn.Open();
            String query = "INSERT INTO SUBJECTS (SUBJECTS_ID,SUBJECTS_NAME) VALUES('" + textBox8.Text + "','" + textBox9.Text + "')";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");
        }

        private void button10_Click(object sender, EventArgs e)
        { //sublect view
            conn.Open();
            String query = "SELECT * FROM SUBJECTS";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // subject update

            conn.Open();
            String query = " UPDATE SUBJECTS SET  SUBJECTS_NAME='" + textBox9.Text + "'WHERE SUBJECTS_ID ='" + textBox8.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("UPDATE");

        }

        private void dataview(object sender, MouseEventArgs e)
        {
            textBox8.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            textBox9.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //delete subjects
            conn.Open();
            String query = "DELETE FROM SUBJECTS where SUBJECTS_ID='" + textBox8.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //insert marks
            
            conn.Open();
            String l1 = "SELECT PEOPLE_ID FROM PEOPLE WHERE LAST_NAME='"+comboBox2.Text+"'";
            String l2 = "SELECT SUBJECTS_ID FROM SUBJECTS WHERE SUBJECTS_NAME='"+comboBox3.Text+"'";
            String l3 = "SELECT PEOPLE_ID FROM PEOPLE WHERE LAST_NAME='" +comboBox4.Text+"'";

 
                OracleCommand Com = new OracleCommand (l1, conn);
            OracleCommand Com2 = new OracleCommand(l2, conn);
            OracleCommand Com3 = new OracleCommand(l3, conn);
             Com.ExecuteNonQuery();
            Com2.ExecuteNonQuery();
            Com3.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            var T = Com.Parameters["PEOPLE_ID"].Value;
            var T2 = Com2.Parameters["SUBJECTS_ID"].Value;
            var T3 = Com3.Parameters["PEOPLE_ID"].Value;

            String query = "INSERT INTO MARKS (MARKS_ID,STUDENT_ID,SUBJECTS_ID,TEACHER_ID,VALUEE,DATEE) VALUES('" + textBox11.Text + "','" +T+ "','"+T2+"','"+T3+"','"+comboBox5.Text+"','"+dateTimePicker3.Value.ToString()+"')";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             


        }

        private void button14_Click(object sender, EventArgs e)
        {
            //sublect view
            conn.Open();
            String query = "   Select M.MARKS_ID,P.LAST_NAME as STUDENT, S.SUBJECTS_NAME, M.TEACHER_ID, M.VALUEE, M.DATEE FROM PEOPLE P  INNER JOIN MARKS M on P.PEOPLE_ID = M.STUDENT_ID  INNER JOIN SUBJECTS S on S.SUBJECTS_ID = M.SUBJECTS_ID WHERE P.PEOPLE_TYPE = 'student'";
            String q = "  select LAST_NAME FROM PEOPLE  LEFT JOIN MARKS M on PEOPLE.PEOPLE_ID = M.STUDENT_ID  WHERE PEOPLE.PEOPLE_TYPE = 'student'";
            String q2 = " select SUBJECTS_NAME FROM SUBJECTS LEFT JOIN MARKS M ON SUBJECTS.SUBJECTS_ID=M.SUBJECTS_ID";
            String q3= "select LAST_NAME FROM PEOPLE LEFT JOIN MARKS M on PEOPLE.PEOPLE_ID = M.STUDENT_ID  WHERE PEOPLE.PEOPLE_TYPE = 'teacher'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView4.DataSource = dt;
            OracleCommand com = new OracleCommand(q, conn);

            try
            {
                OracleDataReader S = com.ExecuteReader();
                while(S.Read())
                {
                    comboBox2.Items.Add(S["LAST_NAME"]);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OracleCommand com2 = new OracleCommand(q2, conn);

            try
            {
                OracleDataReader S2 = com2.ExecuteReader();
                while (S2.Read())
                {
                    comboBox3.Items.Add(S2["SUBJECTS_NAME"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OracleCommand com3 = new OracleCommand(q3, conn);

            try
            {
                OracleDataReader S3 = com3.ExecuteReader();
                while (S3.Read())
                {
                    comboBox4.Items.Add(S3["LAST_NAME"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // marks update

            conn.Open();
            String query = " UPDATE SUBJECTS SET  SUBJECTS_NAME='" + textBox9.Text + "'WHERE SUBJECTS_ID ='" + textBox8.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("UPDATE");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            /* OracleCommand cmd = new OracleCommand("SELECT_SUBJECT_AVG", conn);
             cmd.CommandType = CommandType.StoredProcedure;
             OracleParameter[] pam = new OracleParameter[3];
             pam[0] = new OracleParameter("@SUBJECT_ID_PARAMETER",OracleDbType.Int32);
             pam[0].Value = textBox6.Text;
             pam[1] = new OracleParameter("@DATE_FROM",OracleDbType.Date);
             pam[1].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
             pam[2] = new OracleParameter("@DATE_TO", OracleDbType.Date);
             pam[2].Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
             cmd.ExecuteNonQuery();*/
             
            conn.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT_SUBJECT_AVG1";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("SUBJECT_ID_PARAMETER", textBox6.Text);
            cmd.Parameters.Add("DATE_FROM",  dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.Add("DATE_TO", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.Add(new OracleParameter("Inp", DateTime.Now));
           cmd.Parameters["Inp"].DbType = OracleDbType.Date;
            
            cmd.Parameters.Add("kiekis", OracleDbType.Double);
            cmd.Parameters["kiekis"].Direction = ParameterDirection.ReturnValue;
            
            cmd.ExecuteNonQuery();
            
            var mark_cursor = Convert.ToString(cmd.Parameters["kiekis"].Value);
            MessageBox.Show(mark_cursor);

            cmd.Parameters.RemoveAt(0);

            
            conn.Close();
            MessageBox.Show("YES");
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
