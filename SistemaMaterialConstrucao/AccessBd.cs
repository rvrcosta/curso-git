using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.IO;
//using Encryption;
using System.Windows.Forms;
using System.Collections;


namespace SistemaMaterialConstrucao
{
    class AccessBd
    {        
        //OleDb
        private OleDbConnection conn;
        private OleDbDataAdapter adp;
        private OleDbCommandBuilder ocb;
        //ODBC*/
        /*  1 Ole Db
         *  2 ODBC
         * 
         */
        /*private int bd = 1;
        private OdbcConnection conn;
        private OdbcDataAdapter adp;
        private OdbcCommandBuilder ocb;//*/
        private DataSet ds;
        private string sqlStr;
        private DataRow novaRow = null;
        String dir = System.IO.Directory.GetCurrentDirectory();
        String connStr = "";


        public AccessBd()
        {
            string dados_arquivo = dir + "\\denificoes.txt";

            //string dados = System.IO.File.ReadAllText(dados_arquivo);
            string dados = System.IO.File.ReadAllText(@"" + dir + "\\definicoes.txt");
            String[] dados1 = dados.Split(';');
            if (dados1[0].ToString().ToUpper().Equals("ACCESS"))
            {
                String provider = dados1[1];
                String nomeBase = dados1[2];
                //connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + "\\tr.prg";
                connStr = provider + ";Data Source=" + dir + "\\" + nomeBase;
                
            }
            else
            {
                String ip = dados1[1];
                String db = dados1[2];
                String login = dados1[3];
                String senha = dados1[4];
                
                //Provider=SQLXMLOLEDB.4.0;Data Provider=SQLNCLI10
                //connStr = "Provider=SQLXMLOLEDB.4.0;Data Provider=SQLNCLI10;Data Source=" + ip + ";Initial Catalog=" + db + ";User ID=" + login + ";Password=" + senha + ";";
                connStr = "Provider=sqloledb;Data Source=" + ip + ";Initial Catalog=" + db + ";User ID=" + login + ";Password=" + senha + ";";

                //connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + "\\tr.prg";
            }
        }
        
        public void carregaDados()
        {
            //efetua conexao com o banco de dados banco.mdb  
            //String dir = System.IO.Directory.GetCurrentDirectory();
            //string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + "\\rios_ac_97.mdb";
            //string connStr = "{Microsoft Access Driver (*.mdb)};Dbq=" + dir + "\\rios_ac_97.mdb;Uid=Admin;Pwd=;"; 
            //string connStr = "Provider=MySQLProv;ip=192.168.0.2;Port=3306;Data Source=bancorios;User Id=rios;Password=;";
            //string connStr = "Driver={MySQL ODBC 3.51 Driver};Server=192.168.0.2;Port=3306;Database=bancorios;User=rios; Password=;Option=3;";
            //string connStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=192.168.0.2,1433; Network Library=TCP/IP; Initial Catalog=bancoRios1; User ID=rios; Password=123456";
            //string connStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=192.168.0.200,1433; Jet OLEDB:System Database=bancoRios1; User ID=rios; Password=123456"; 

            try
            {
                //OleDb                
                conn = new OleDbConnection(connStr);
                //ODBC
                //conn = new OdbcConnection(connStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar a base de dados : " + e.ToString());
                //this.Dispose();
            }
        }        
        public void desaloca(Boolean desalocatDataset)
        {
            if (desalocatDataset == false)
            {
                ds.Dispose();
            }
            else
            {
                ds.Dispose();
            }
            ocb.Dispose();
            adp.Dispose();
            conn.Dispose();
        }
        public void inicioFunc(String tabela,Boolean newDataset)
        {
            /*try
            {*/
                if (newDataset == true)
                {
                    ds = new DataSet();
                }
                if ((sqlStr == null) || (sqlStr.Equals("")))
                {
                    sqlStr = "SELECT * FROM " + tabela;
                }
                //OleDb
                adp = new OleDbDataAdapter(sqlStr, conn);
                adp.SelectCommand.CommandText = sqlStr;
                ocb = new OleDbCommandBuilder(adp);
                //ODBC*/
                /*adp = new OdbcDataAdapter(sqlStr, conn);
                adp.SelectCommand.CommandText = sqlStr;
                ocb = new OdbcCommandBuilder(adp);//*/
                adp.Fill(ds, tabela);
            /*}
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar a base de dados : " + e.Message.ToString() + "" + sqlStr.ToString());
                //this.desaloca(true);
            }*/
        }
        public void insereAtualizaInicio(String tabela)
        {
            this.carregaDados();
            this.inicioFunc(tabela,true);
        }
        public void insereAtualizaInicio(String tabela, String sql)
        {
            sqlStr = sql;
            this.carregaDados();
            this.inicioFunc(tabela, false);
        }
        public void insereAtualizaFim(String tabela, Boolean inserindo, Boolean mostraMessageBox)
        {
            if (inserindo == true)
            {
                ds.Tables[tabela].Rows.Add(novaRow);
            }
            adp.Update(ds, tabela);
            this.desaloca(true);
            if (inserindo == true)
            {
                if (mostraMessageBox == true)
                {                    
                    MessageBox.Show("Registro incluido com sucesso!");
                }
            }
            else
            {
                if (mostraMessageBox == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
            }
        }
        public void insereAtualizaFim(String tabela, Boolean inserindo, Boolean mostraMessageBox, DataSet ds2)
        {
            ds = ds2;
            /*if (inserindo == true)
            {
                ds.Tables[tabela].Rows.Add(novaRow);
            }*/
            adp.Update(ds, tabela);
            this.desaloca(true);
            if (inserindo == true)
            {
                if (mostraMessageBox == true)
                {
                    MessageBox.Show("Registro incluido com sucesso!");
                }
            }
            else
            {
                if (mostraMessageBox == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
            }
        }
        public void insereAtualizaFim(String tabela, Boolean inserindo, DataRow novaRow, Boolean mostraMessageBox)
        {
            if (inserindo == true)
            {
                ds.Tables[tabela].Rows.Add(novaRow);
            }
            adp.Update(ds, tabela);
            this.desaloca(true);
            if (inserindo == true)
            {
                if (mostraMessageBox == true)
                {
                    //MessageBox.Show("Registro incluido com sucesso!");
                }
            }
            else
            {
                if (mostraMessageBox == true)
                {
                    //MessageBox.Show("Registro alterado com sucesso!");
                }
            }
        }
        public DataSet insereAtualizaFim(String tabela, Boolean inserindo, Boolean mostraMessageBox, Boolean desalocarDataset)
        {
            if (inserindo == true)
            {
                ds.Tables[tabela].Rows.Add(novaRow);
            }
            adp.Update(ds, tabela);
            this.desaloca(false);
            if (inserindo == true)
            {
                if (mostraMessageBox == true)
                {
                    MessageBox.Show("Registro incluido com sucesso!");
                }
            }
            else
            {
                if (mostraMessageBox == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
            }
            return ds;
        }
        public void deleta(String tabela)
        {
            this.carregaDados();
            this.inicioFunc(tabela, true);
            ds.Tables[tabela].Rows[0].Delete();
            adp.Update(ds, tabela);
            this.desaloca(true);
            MessageBox.Show("Registro excluido com sucesso.!");
        }
        public void deleta(String tabela, DataSet dataSet, int Row)
        {
            //this.carregaDados();
            //this.inicioFunc(tabela);
            dataSet.Tables[tabela].Rows[Row].Delete();
            //adp.Update(ds, tabela);
            //this.desaloca(true);
            //MessageBox.Show("Registro excluido com sucesso.!");
        }
        public DataSet retornaDataSet(String tabela)
        {
            this.carregaDados();
            this.insereAtualizaInicio(tabela);
            return this.insereAtualizaFim(tabela, false, false, false);
        }
        public static byte[] GetFile(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;
        }
        public String retornaFileName(String FileName)
        {
            String aux = null;
            Boolean achou = false;
            int i = FileName.Length - 1;
            while ((i > 0) && (achou == false))
            {
                if (FileName.Substring(i, 1) == "\\")
                {
                    achou = true;
                }
                else
                {
                    aux = FileName.Substring(i, 1) + aux;
                    i = i - 1;
                }
            }
            return aux;
        }
        public void setSql(String sql)
        {
            this.sqlStr = sql;
        }
        public void setDataset(DataSet ds)
        {
            this.ds = ds;
        }
        public DataSet getDataSet(){
            return this.ds;
        }
        public void PreencheComboBox(ComboBox comboBoxPreencher, String tabela, String campo, Boolean sqlStrTodosCampos)
        {
            comboBoxPreencher.Items.Clear();            
            this.carregaDados();

            if (sqlStrTodosCampos == true)
            {
                sqlStr = "SELECT * FROM " + tabela + " ORDER BY "+campo;
            }

            this.inicioFunc(tabela, true);            
            for (int i = 0; i < ds.Tables[tabela].Rows.Count; i++)
            {
                comboBoxPreencher.Items.Add(ds.Tables[tabela].Rows[i][campo]);
            }
            if (ds.Tables[tabela].Rows.Count > 0)
            {
                comboBoxPreencher.SelectedIndex = 0;
            }
            else
            {
                comboBoxPreencher.Text = "";
            }


            this.desaloca(true);
        }
        public void PreencheComboBox(ComboBox comboBoxPreencher, String tabela, String campo,String campoSelectValue, String orderby, Boolean sqlStrTodosCampos)
        {
            DataTable dtblDataSource = new DataTable();
            dtblDataSource.Columns.Add("DisplayMember");
            dtblDataSource.Columns.Add("ValueMember");
                        

            comboBoxPreencher.Items.Clear();
            this.carregaDados();

            if (sqlStrTodosCampos == true)
            {
                sqlStr = "SELECT * FROM " + tabela + " ORDER BY " + orderby;
            }

            this.inicioFunc(tabela, true);
            
            for (int i = 0; i < ds.Tables[tabela].Rows.Count; i++)
            {
                dtblDataSource.Rows.Add(ds.Tables[tabela].Rows[i][campo],ds.Tables[tabela].Rows[i][campoSelectValue]);      
            }

            comboBoxPreencher.Items.Clear();
            comboBoxPreencher.DataSource = dtblDataSource;
            comboBoxPreencher.DisplayMember = "DisplayMember";
            comboBoxPreencher.ValueMember = "ValueMember";

            if (ds.Tables[tabela].Rows.Count > 0)
            {
                comboBoxPreencher.SelectedIndex = 0;
            }
            else
            {
                comboBoxPreencher.Text = "";
            }


            this.desaloca(true);
        }
        public void PreencheComboBox(ComboBox comboBoxPreencher, String tabela, String campo, String campo2, Boolean sqlStrTodosCampos)
        {
            comboBoxPreencher.Items.Clear();
            this.carregaDados();

            if (sqlStrTodosCampos == true)
            {
                sqlStr = "SELECT * FROM " + tabela;
            }

            this.inicioFunc(tabela, true);
            for (int i = 0; i < ds.Tables[tabela].Rows.Count; i++)
            {
                comboBoxPreencher.Items.Add(Convert.ToInt16(ds.Tables[tabela].Rows[i][campo].ToString(),10).ToString("D6") + "      " + ds.Tables[tabela].Rows[i][campo2]);
            }
            if (ds.Tables[tabela].Rows.Count > 0)
            {
                comboBoxPreencher.SelectedIndex = 0;
            }
            else
            {
                comboBoxPreencher.Text = "";
            }
            this.desaloca(true);
        }
        public void PreencheComboBox(ComboBox comboBoxPreencher, String tabela, ArrayList arrayIndexComboBox, String campo, String campo2, Boolean sqlStrTodosCampos)
        {
            comboBoxPreencher.Items.Clear();
            this.carregaDados();
            arrayIndexComboBox.Clear();

            if (sqlStrTodosCampos == true)
            {
                sqlStr = "SELECT * FROM " + tabela;
            }

            this.inicioFunc(tabela, true);
            for (int i = 0; i < ds.Tables[tabela].Rows.Count; i++)
            {
                comboBoxPreencher.Items.Add(ds.Tables[tabela].Rows[i][campo2]);
                arrayIndexComboBox.Add(ds.Tables[tabela].Rows[i][campo].ToString());
            }
            if (ds.Tables[tabela].Rows.Count > 0)
            {
                comboBoxPreencher.SelectedIndex = 0;
            }
            else
            {
                comboBoxPreencher.Text = "";
            }
            this.desaloca(true);
        }
        public DataSet PreencheDataGridView(DataGridView datagridView, String tabela)
        {
            datagridView.Rows.Clear();
            if (sqlStr == null || sqlStr == "")
            {
                sqlStr = "SELECT * FROM " + tabela;
            }
            this.insereAtualizaInicio(tabela);
            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                int iaux = datagridView.Rows.Add();
                for (int i = 0; i < datagridView.Columns.Count; i++)
                {
                    if(ds.Tables[0].Columns.Contains(datagridView.Columns[i].Name.ToUpper()))
                    {
                        
                        datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value = ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString();                        
                    }                    
                }
            }
            datagridView.Update();
            return this.insereAtualizaFim(tabela, false, false, false);
        }
        public DataSet PreencheDataGridView(DataGridView datagridView, String tabela, DataSet dataSet, DataSet dataSet2)
        {
            datagridView.Rows.Clear();
            for (System.Int32 iRow = 0; iRow < dataSet.Tables[0].Rows.Count; iRow++)
            {
                int iaux = datagridView.Rows.Add();
                for (int i = 0; i < datagridView.Columns.Count; i++)
                {
                    if (dataSet.Tables[0].Columns.Contains(datagridView.Columns[i].Name.ToUpper()))
                    {
                        datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value = dataSet.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString();
                    }
                    else
                    {
                        if (dataSet2.Tables[0].Columns.Contains(datagridView.Columns[i].Name.ToUpper()))
                        {
                            datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value = dataSet2.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString();
                        }
                    }
                }
            }
            return dataSet;            
        }
        public void PreencheDataGridView(GroupBox groupBox, DataGridView datagridView, String tabela)
        {


        }
        public void incluirDataGridView(DataGridView datagridView, DataSet ds2, String tabela)
        {
            novaRow = ds2.Tables[tabela].NewRow();

            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                int iaux = datagridView.Rows.Add();
                for (int i = 0; i < datagridView.Columns.Count; i++)
                {
                    if (ds2.Tables[0].Columns.Contains(datagridView.Columns[i].Name.ToUpper()))
                    {

                        //DataGridViewRow r = datagridView.Rows[iaux];

                        //datagridView.Rows[0].Cells["ICO_IDENTIFICADOR_MCO"].Value = 21;
                        //datagridView.Rows[1].Cells[datagridView.Columns[i].Name.ToUpper()].Value = 21;
                        //r.SetValues(ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString());
                        datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value = ds2.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString();

                    }
                }
            }
            
            
            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                for (int i = 0; i < datagridView.Rows[iRow].Cells.Count; i++)
                {
                    if (datagridView.Columns[i].Name.ToUpper().Equals(ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()]))
                    {
                        novaRow[datagridView.Columns[i].Name.ToUpper()] = datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value;
                    }
                }
            }
            
        }
        public void alterarDataGridView(DataGridView dataGridView, DataSet ds2, int iRow, String tabela)
        {
            for (int i = 0; i < dataGridView.Rows[iRow].Cells.Count; i++)
            {
                if (dataGridView.Columns[i].Name.ToUpper().Equals(ds.Tables[0].Rows[iRow][dataGridView.Columns[i].Name.ToUpper()]))
                {
                    ds2.Tables[0].Rows[iRow][dataGridView.Columns[i].Name.ToUpper()] = dataGridView.Rows[iRow].Cells[dataGridView.Columns[i].Name.ToUpper()].Value;
                }
            }
        }
        public void excluirDataGridView(DataGridView dataGridView, DataSet ds2, int iRow, String tabela)
        {
            ds2.Tables[tabela].Rows[iRow].Delete();
        }
        public void preencheDataSetAlterar(Panel panel, String tabela)
        {
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    if ((panel.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ds.Tables[tabela].Rows[0][aux] = ((TextBox)panel.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((panel.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ds.Tables[tabela].Rows[0][aux] = ((ComboBox)panel.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void preencheDataSetAlterar(DataGridView dataGridView, String tabela, DataSet dataSet)
        {
            novaRow = dataSet.Tables[tabela].NewRow();

            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                for (int i = 0; i < dataGridView.Rows[i].Cells.Count; i++)
                {
                    if (dataSet.Tables[0].Columns.Contains(dataGridView.Columns[i].Name.ToUpper()))
                    {
                        dataSet.Tables[0].Rows[iRow][dataGridView.Columns[i].Name.ToUpper()] = dataGridView.Rows[iRow].Cells[dataGridView.Columns[i].Name.ToUpper()].Value;
                    }
                }
            }
        
            
        }
        public void preencheDataSetAlterar(GroupBox groupBox, String tabela)
        {
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < groupBox.Controls.Count; i++)
                {
                    if ((groupBox.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ds.Tables[tabela].Rows[0][aux] = ((TextBox)groupBox.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((groupBox.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ds.Tables[tabela].Rows[0][aux] = ((ComboBox)groupBox.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void preencheDataSetAlterar(Form form, String tabela)
        {
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < form.Controls.Count; i++)
                {
                    if ((form.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ds.Tables[tabela].Rows[0][aux] = ((TextBox)form.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((form.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ds.Tables[tabela].Rows[0][aux] = ((ComboBox)form.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void IncluirDataSet(String tabela, String campo, String campoAlterar)
        {
            novaRow[campo] = campoAlterar;
        }
        public void IncluirDataSet(String tabela, String campo, int campoAlterar)
        {
            novaRow[campo] = campoAlterar;
        }
        public DataRow IncluirDataSet(String tabela)
        {
            novaRow = ds.Tables[tabela].NewRow();
            return novaRow;
        }
        public void IncluirDataSetNewRowIni(String tabela)
        {
            novaRow = ds.Tables[tabela].NewRow();            
        }
        public void IncluirDataSetNewRowFim(String tabela)
        {
            ds.Tables[tabela].Rows.Add(novaRow);
        }       
        public void AlterarDataSet(String tabela, String campo, String campoAlterar)
        {
            ds.Tables[tabela].Rows[0][campo] = campoAlterar;
        }
        public void AlterarDataSet(String tabela, String campo, int campoAlterar)
        {
            ds.Tables[tabela].Rows[0][campo] = campoAlterar;
        }
        public void AlterarDataSet(String tabela, int Row, String campo, String campoAlterar)
        {
            ds.Tables[tabela].Rows[Row][campo] = campoAlterar;
        }
        public void AlterarDataSet(String tabela, int Row, String campo, int campoAlterar)
        {
            ds.Tables[tabela].Rows[Row][campo] = campoAlterar;
        }
        public void IncluirDataSet(Panel panel, String tabela)
        {
            novaRow = ds.Tables[tabela].NewRow();            
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    if ((panel.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            novaRow[aux] = ((TextBox)panel.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((panel.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                novaRow[aux] = ((ComboBox)panel.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void IncluirDataSet(DataGridView dataGridView, String tabela, DataSet dataSet)
        {
            novaRow = dataSet.Tables[tabela].NewRow();

            for (System.Int32 iCol = 0; iCol < dataGridView.Columns.Count; iCol++)
            {

                if (dataSet.Tables[0].Columns.Contains(dataGridView.Columns[iCol].Name.ToUpper()))
                {

                    //DataGridViewRow r = datagridView.Rows[iaux];

                    //datagridView.Rows[0].Cells["ICO_IDENTIFICADOR_MCO"].Value = 21;
                    //datagridView.Rows[1].Cells[datagridView.Columns[i].Name.ToUpper()].Value = 21;
                    //r.SetValues(ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString());
                    if(dataGridView.Rows[dataGridView.Rows.Count-1].Cells[dataGridView.Columns[iCol].Name.ToUpper()].Value.Equals("")==false){
                        novaRow[dataGridView.Columns[iCol].Name.ToUpper()] = dataGridView.Rows[dataGridView.Rows.Count-1].Cells[dataGridView.Columns[iCol].Name.ToUpper()].Value;                        
                    }
                }

            }
            dataSet.Tables[tabela].Rows.Add(novaRow);
        }
        public void IncluirDataSet(DataGridView dataGridView, String tabela)
        {
            novaRow = ds.Tables[tabela].NewRow();

            for (System.Int32 iCol = 0; iCol < dataGridView.Columns.Count; iCol++)
            {
                if (ds.Tables[0].Columns.Contains(dataGridView.Columns[iCol].Name.ToUpper()))
                {
                    if (dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[dataGridView.Columns[iCol].Name.ToUpper()].Value!=null && dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[dataGridView.Columns[iCol].Name.ToUpper()].Value.Equals("") == false)
                    {
                        novaRow[dataGridView.Columns[iCol].Name.ToUpper()] = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[dataGridView.Columns[iCol].Name.ToUpper()].Value;
                    }
                }
            }            
        }
        public void IncluirDataSet(GroupBox groupBox, String tabela)
        {            
            novaRow = ds.Tables[tabela].NewRow();
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < groupBox.Controls.Count; i++)
                {
                    if ((groupBox.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {                            
                            
                            if (ds.Tables[tabela].Columns[aux].DataType.Name.ToUpper().Equals("DOUBLE") || ds.Tables[tabela].Columns[aux].DataType.Name.ToUpper().Equals("INTEGER"))
                            {
                                if(((TextBox)groupBox.Controls[i]).Text.Trim().Equals("")==false){
                                    novaRow[aux] = ((TextBox)groupBox.Controls[i]).Text; 
                                }
                            }
                            else
                            {                                
                                novaRow[aux] = ((TextBox)groupBox.Controls[i]).Text;
                            }
                        }
                    }
                    else
                    {
                        if ((groupBox.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                novaRow[aux] = ((ComboBox)groupBox.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void IncluirDataSet(GroupBox groupBox, String tabela, Boolean Cliente)
        {
            novaRow = ds.Tables[tabela].NewRow();
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < groupBox.Controls.Count; i++)
                {
                    if ((groupBox.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {

                            if (ds.Tables[tabela].Columns[aux].DataType.Name.ToUpper().Equals("DOUBLE") || ds.Tables[tabela].Columns[aux].DataType.Name.ToUpper().Equals("INTEGER"))
                            {
                                if (((TextBox)groupBox.Controls[i]).Text.Trim().Equals("") == false)
                                {
                                    novaRow[aux] = ((TextBox)groupBox.Controls[i]).Text;
                                }
                            }
                            else
                            {
                                if (((TextBox)groupBox.Controls[i]).Text.Trim().Equals("") == false)
                                {
                                    novaRow[aux] = ((TextBox)groupBox.Controls[i]).Text;
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((groupBox.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                novaRow[aux] = ((ComboBox)groupBox.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }
        }
        public void IncluirDataSet(Form form, String tabela)
        {            
            novaRow = ds.Tables[tabela].NewRow();           
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < form.Controls.Count; i++)
                {
                    if ((form.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            novaRow[aux] = ((TextBox)form.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((form.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                novaRow[aux] = ((ComboBox)form.Controls[i]).SelectedItem.ToString();
                            }
                        }
                    }
                }
            }            
        }
        public void preencheCamposPainel(Panel panel, String tabela)
        {
            if (sqlStr == null || sqlStr == "")
            {
                sqlStr = "SELECT * FROM " + tabela;
            }
            this.insereAtualizaInicio(tabela);  
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    if ((panel.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ((TextBox)panel.Controls[i]).Text = ds.Tables[tabela].Rows[0][aux].ToString();
                        }
                    }
                    else
                    {
                        if ((panel.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)panel.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ((ComboBox)panel.Controls[i]).SelectedItem = ds.Tables[tabela].Rows[0][aux].ToString();
                            }
                        }
                    }
                }
            }
            this.insereAtualizaFim(tabela, false, false);  
        }
        public void incluirItemPreencheCamposDataGridGroupBox(GroupBox groupBox, DataGridView dataGridView)
        {
            dataGridView.Rows.Add();
            for (System.Int32 iCol = 0; iCol < dataGridView.Columns.Count; iCol++)
            {
                String aux = dataGridView.Columns[iCol].Name.ToUpper();
                for (int i = 0; i < groupBox.Controls.Count; i++)
                {
                    if ((groupBox.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            dataGridView.Rows[dataGridView.Rows.Count-1].Cells[aux].Value = ((TextBox)groupBox.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((groupBox.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                dataGridView.Rows[dataGridView.Rows.Count-1].Cells[aux].Value = ((ComboBox)groupBox.Controls[i]).SelectedItem;
                            }
                        }
                    }
                }
            }            
        }
        public void incluirItemPreencheCamposDataGridGroupBox(Form f, DataGridView dataGridView)
        {
            dataGridView.Rows.Add();
            for (System.Int32 iCol = 0; iCol < dataGridView.Columns.Count; iCol++)
            {
                String aux = dataGridView.Columns[iCol].Name.ToUpper();
                for (int i = 0; i < f.Controls.Count; i++)
                {
                    if ((f.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)f.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[aux].Value = ((TextBox)f.Controls[i]).Text;
                        }
                    }
                    else
                    {
                        if ((f.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)f.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[aux].Value = ((ComboBox)f.Controls[i]).SelectedItem;
                            }
                        }
                    }
                }
            }
            dataGridView.Update();
        }
        public void incluirItemPreencheCamposDataGridGroupBox(DataGridView dataGridView)
        {

            






            //novaRow = ds2.Tables[tabela].NewRow();

            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                //int iaux = dataGridView.Rows.Add();
                //int linha = dataGridView.Rows.Add();
                dataGridView.Rows.Insert(0, 1);
                //DataRow dr = 
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (ds.Tables[0].Columns.Contains(dataGridView.Columns[i].Name.ToUpper()))
                    {

                        //DataGridViewRow r = datagridView.Rows[iaux];

                        //datagridView.Rows[0].Cells["ICO_IDENTIFICADOR_MCO"].Value = 21;
                        //datagridView.Rows[1].Cells[datagridView.Columns[i].Name.ToUpper()].Value = 21;
                        //r.SetValues(ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString(), ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()].ToString());
                        dataGridView.Rows[0].Cells[dataGridView.Columns[i].Name.ToUpper()].Value = ds.Tables[0].Rows[iRow][dataGridView.Columns[i].Name.ToUpper()].ToString();
                        
                    }
                    //dataGridView.Rows.Add();
                }
            }

            /*
            for (System.Int32 iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
            {
                for (int i = 0; i < datagridView.Rows[iRow].Cells.Count; i++)
                {
                    if (datagridView.Columns[i].Name.ToUpper().Equals(ds.Tables[0].Rows[iRow][datagridView.Columns[i].Name.ToUpper()]))
                    {
                        novaRow[datagridView.Columns[i].Name.ToUpper()] = datagridView.Rows[iRow].Cells[datagridView.Columns[i].Name.ToUpper()].Value;
                    }
                }
            }
            )
             * */
            
            
            dataGridView.Update();
        }
        public void IncluirDataGridCampo(DataGridView dataGridView, String Cell, String valorCell)
        {
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[Cell].Value = valorCell;
        }
        public void AlterarDataGridCampo(DataGridView dataGridView, DataSet dataSet, String tabela, int Row, String Cell)
        {
            dataSet.Tables[tabela].Rows[Row][Cell] = dataGridView.Rows[Row].Cells[Cell].Value;
        }
        public void preencheCamposGroupBox(GroupBox groupBox, String tabela)
        {            
            if (sqlStr == null || sqlStr == "")
            {
                sqlStr = "SELECT * FROM " + tabela;
            }
            this.insereAtualizaInicio(tabela);                      
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < groupBox.Controls.Count; i++)
                {
                    if ((groupBox.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ((TextBox)groupBox.Controls[i]).Text = ds.Tables[tabela].Rows[0][aux].ToString();
                        }
                    }
                    else
                    {
                        if ((groupBox.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)groupBox.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ((ComboBox)groupBox.Controls[i]).SelectedItem = ds.Tables[tabela].Rows[0][aux].ToString();
                            }
                        }
                    }
                }
            }
            this.insereAtualizaFim(tabela, false, false);  
        }
        public void preencheCamposForm(Form form, String tabela)
        {
            if (sqlStr == null || sqlStr == "")
            {
                sqlStr = "SELECT * FROM " + tabela;
            }
            this.insereAtualizaInicio(tabela);  
            this.insereAtualizaFim(tabela, false, false);
            for (System.Int32 iCol = 0; iCol < ds.Tables[0].Columns.Count; iCol++)
            {
                String aux = ds.Tables[0].Columns[iCol].ColumnName;
                for (int i = 0; i < form.Controls.Count; i++)
                {
                    if ((form.Controls[i].GetType()).Name.Equals("TextBox"))
                    {
                        if (((TextBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToString().ToUpper()))
                        {
                            ((TextBox)form.Controls[i]).Text = ds.Tables[tabela].Rows[0][aux].ToString();
                        }
                    }
                    else
                    {
                        if ((form.Controls[i].GetType()).Name.Equals("ComboBox"))
                        {
                            if (((ComboBox)form.Controls[i]).Name.ToUpper().Contains(aux.ToUpper()))
                            {
                                ((ComboBox)form.Controls[i]).SelectedItem = ds.Tables[tabela].Rows[0][aux].ToString();
                            }
                        }
                    }
                }
            }
            this.insereAtualizaFim(tabela, false, false);  
        }
        public int retornaIdCampo(String tabela, String campoRetornar, String campoProcurar, int idProcurar)
        {
            sqlStr = "SELECT * "
            + "FROM " + tabela + " WHERE " + campoProcurar + "=" + idProcurar;

            insereAtualizaInicio(tabela);

            int id = Convert.ToInt32(ds.Tables[tabela].Rows[0][campoRetornar].ToString(), 10);

            insereAtualizaFim(tabela, false, false);
            return id;
        }
        public String retornaCampo(String tabela, String campoRetornar, String campoProcurar, String stringProcurar)
        {
            sqlStr = "SELECT * "
            + "FROM " + tabela + " WHERE " + campoProcurar + "= '" + stringProcurar + "'";

            insereAtualizaInicio(tabela);

            String stringRetornar = ds.Tables[tabela].Rows[0][campoRetornar].ToString();

            insereAtualizaFim(tabela, false, false);
            return stringRetornar;
        }
        public String retornaCampo(String tabela,String campoRetornar, String sql)
        {
            
            sqlStr = sql;
            insereAtualizaInicio(tabela);
            String stringRetornar = "";
            if (ds.Tables[tabela].Rows.Count > 0)
            {
                stringRetornar = ds.Tables[tabela].Rows[0][campoRetornar].ToString();
            }
            insereAtualizaFim(tabela, false, false);
            return stringRetornar;
        }
        public String retornaCampo(String tabela, String campoRetornar, String campoProcurar, int intProcurar)
        {
            sqlStr = "SELECT * "
            + "FROM " + tabela + " WHERE " + campoProcurar + "= " + intProcurar + "";

            insereAtualizaInicio(tabela);

            String stringRetornar = ds.Tables[tabela].Rows[0][campoRetornar].ToString();

            insereAtualizaFim(tabela, false, false);
            return stringRetornar;
        }
       
    }
}
