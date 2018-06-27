using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCalibrationSystem.DataAccess
{
    public class DAO
    {
        //查询数据库中当前点序号，从1开始
        public static int SelectCurnumFromMaster()
        {
            int num = 1;
            string sql = @" select num from divider_process ";
            DataBase db = new DataBase();
            DataTable dt = db.ExecuteQuery(sql);
            if (dt != null)
            {
                num = int.Parse(dt.Rows[0]["num"].ToString());
            }
            return num;
        }
        //查询数据库源输入、温湿度等数据
        public static bool FillDividerDataFromMaster(DividerProcess dividerProcess,DividerData dividerData)
        {
            string table = "";
            List<DividerItem> list = null;
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    list = dividerData.voltageACData;
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    list = dividerData.voltageDCPData;
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    list = dividerData.voltageDCNData;
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    list = dividerData.frequencyData;
                    break;
            }
            int index = dividerProcess.curNum + 1;
            string sql = @"select input,temperature,humidity from " + table + " where id = "+index;
            DataBase db = new DataBase();
            DataTable dt = db.ExecuteQuery(sql);
            float standOut = float.Parse(dt.Rows[0]["input"].ToString());
            float temperature = float.Parse(dt.Rows[0]["temperature"].ToString());
            float humidity = float.Parse(dt.Rows[0]["humidity"].ToString());
            if (dt != null)
            {
                list[dividerProcess.curNum].StandOut = standOut;
                list[dividerProcess.curNum].Temperature = temperature;
                list[dividerProcess.curNum].Humidity = humidity;
            }
            if( standOut < 0.00001 || temperature < 0.00001)
                return false;
            else
                return true;
        }
        //查询分压器监测状态数据
        public static int QueryDividerState(DividerProcess dividerProcess)
        {
            string table = "";
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    break;
            }
            string sql = @" select state from " + table + " where id = (select num from divider_process)";
            DataBase db = new DataBase();
            DataTable dt = db.ExecuteQuery(sql);
            int state = 0;
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    state = int.Parse(dt.Rows[0]["state"].ToString());
                }
            }
            return state;    
        }
        //更新分压器监测状态数据
        public static void UpdateDividerState(DividerProcess dividerProcess,int state)
        {
            string table = "";
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    break;
            }
            int index = dividerProcess.curNum + 1;
            string sql = @" update " + table + " set temperature = " + state + " where id = " + index;
            DataBase db = new DataBase();
            db.ExecuteQuery(sql);
        }
        //更新温湿度数据
        public static void UpdateDividerTandH(DividerProcess dividerProcess, float temp, float humidity)
        {
            string table = "";
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    break;
            }
            int index = dividerProcess.curNum + 1;
            string sql = @"update " + table + " set temperature = " + temp + ", humidity = " + humidity + " where id = " + index;
            DataBase db = new DataBase();
            db.ExecuteQuery(sql);
        }
        //更新分压器输入
        public static void UpdateDividerSourceInput(DividerProcess dividerProcess, float source)
        {
            string table = "";
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    break;
            }
            string sql = @"update " + table + " set input = " + source + " where id = " + dividerProcess.curNum + 1;
            DataBase db = new DataBase();
            db.ExecuteQuery(sql);
        }
        //分压器监测时初始化获取数据到dividerData
        public static List<DividerItem> GetDividerDataFromSql(EnumMode mode)
        {
            string table = "";
            string strMode="";
            switch (mode)
            {
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    strMode = "AC";
                    break;
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    strMode = "DCP";
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    strMode = "DCN";
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    strMode = "F";
                    break;
            }
            string sql = @"select * from "+ table;
            DataBase db = new DataBase();
            DataTable dt = db.ExecuteQuery(sql);
            if (dt == null)
                return null;
            List<DividerItem> list = new List<DividerItem>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DividerItem item = new DividerItem(strMode);
                item.Source = float.Parse(dt.Rows[i]["source"].ToString());
                item.Frequency = float.Parse(dt.Rows[i]["frequency"].ToString());
                list.Add(item);
            }
            return list;            
        }
        //重置分压器监测数据库实时表数据
        public static void ResetDividerNowTable(bool modeMeasType,EnumMode mode)
        {
            DataBase db = new DataBase();
            string table = "";
            string sql = @"update " + table + " set input = 0, state = 0 ";
            switch (mode)
            {
                case EnumMode.Divider_V_DCP:
                    table = "divider_now_dcp";
                    db.ExecuteQuery(sql);
                    if(modeMeasType)
                    {
                        goto case EnumMode.Divider_V_DCN;
                    }
                    break;
                case EnumMode.Divider_V_DCN:
                    table = "divider_now_dcn";
                    db.ExecuteQuery(sql);
                    if(modeMeasType)
                    {
                        goto case EnumMode.Divider_V_AC;
                    }
                    break;
                case EnumMode.Divider_V_AC:
                    table = "divider_now_ac";
                    db.ExecuteQuery(sql);
                    if(modeMeasType)
                    {
                        goto case EnumMode.Divider_F;
                    }
                    break;
                case EnumMode.Divider_F:
                    table = "divider_now_f";
                    break;
            } 
        }
        public static void AddRow2TableCali(DataTable dt, List<CaliItem> list, string mode,int instruId) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["mode"] = mode;
                row["instrument_id"] = instruId;
                row["source"] = list[i].Source;
                row["stand_out"] = list[i].StandOut;
                row["test_out"] = list[i].TestOut;                
                dt.Rows.Add(row);
            }
        }
        public static void AddRow2TableDivider(DataTable dt, List<DividerItem> list, int dividerId)
        {
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["divider_id"] = dividerId;
                row["source_volt"] = list[i].Source;
                row["source_freq"] = list[i].Frequency;
                row["stand_divider_volt"] = list[i].StandOut;
                row["test_divider_volt"] = list[i].TestOut;
                row["temperature"] = list[i].Temperature;
                row["humidity"] = list[i].Humidity;
                dt.Rows.Add(row);
            }
        }
        //批量插入校准数据到cali_data表
        public static bool SaveCaliDataAll(CaliData caliData) 
        {
            DataBase db = new DataBase();
            DataTable sourceTable = new DataTable();
            sourceTable.TableName = "cali_data";
            //sourceTable.Columns.Add("id",typeof(int));
            sourceTable.Columns.Add("instrument_id", typeof(int));
            sourceTable.Columns.Add("mode", typeof(string));
            sourceTable.Columns.Add("source", typeof(float));
            sourceTable.Columns.Add("stand_out", typeof(float));
            sourceTable.Columns.Add("test_out", typeof(float));

            int instruId = 1;
            List<CaliItem> list = null;            
            list = caliData.iaciData;
            AddRow2TableCali(sourceTable, list, "IACI", instruId);
            
            list = caliData.iacfData;
            AddRow2TableCali(sourceTable, list, "IACF", instruId);
            
            list = caliData.idcData;
            AddRow2TableCali(sourceTable, list, "IDC", instruId);
            
            list = caliData.vacfData;
            AddRow2TableCali(sourceTable, list, "VACF", instruId);
            
            list = caliData.vacvData;
            AddRow2TableCali(sourceTable, list, "VACV", instruId);
            
            list = caliData.vdcData;
            AddRow2TableCali(sourceTable, list, "VDC", instruId);
            
            try {
                BulkInsert(sourceTable);
            }
            catch (Exception)
            {
                return false;
            }
            return true;          
        }
        //根据测量模式批量插入分压器数据到divider_data表
        public static bool SaveDividerDataByMode(DividerData dividerData,EnumMode mode)
        {
            DataBase db = new DataBase();
//            string sql = "ALTER TABLE `divider_data` AUTO_INCREMENT = MAX(id) + 1";
//            db.ExecuteQuery(sql);
            DataTable sourceTable = new DataTable();
            sourceTable.TableName = "divider_data";
            sourceTable.Columns.Add("divider_id", typeof(int));
            sourceTable.Columns.Add("source_volt", typeof(float));
            sourceTable.Columns.Add("source_freq", typeof(float));
            sourceTable.Columns.Add("stand_divider_volt", typeof(float));
            sourceTable.Columns.Add("test_divider_volt", typeof(float));
            sourceTable.Columns.Add("temperature", typeof(float));
            sourceTable.Columns.Add("humidity", typeof(float));


            List<DividerItem> list = null;
            switch (mode)
            {
                case EnumMode.Divider_V_DCP:
                    list = dividerData.voltageDCPData;
                    break;
                case EnumMode.Divider_V_DCN:
                    list = dividerData.voltageDCNData;
                    break;
                case EnumMode.Divider_V_AC:
                    list = dividerData.voltageACData;
                    break;
                case EnumMode.Divider_F:
                    list = dividerData.frequencyData;
                    break;
            }
            AddRow2TableDivider(sourceTable, list, dividerData.dividerId);
            try
            {
                BulkInsert(sourceTable);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //所有模式批量插入分压器数据到divider_data表
        public static bool SaveDividerDataAll(DividerData dividerData)
        {
            DataBase db = new DataBase();
            DataTable sourceTable = new DataTable();
            sourceTable.TableName = "divider_data";
            sourceTable.Columns.Add("divider_id", typeof(int));
            sourceTable.Columns.Add("source_volt", typeof(float));
            sourceTable.Columns.Add("source_freq", typeof(float));
            sourceTable.Columns.Add("stand_divider_volt", typeof(float));
            sourceTable.Columns.Add("test_divider_volt", typeof(float));
            sourceTable.Columns.Add("temperature", typeof(float));
            sourceTable.Columns.Add("humidity", typeof(float));

            List<DividerItem> list = null;
            list = dividerData.voltageDCPData;
            AddRow2TableDivider(sourceTable, list, dividerData.dividerId);

            list = dividerData.voltageDCNData;
            AddRow2TableDivider(sourceTable, list, dividerData.dividerId);

            list = dividerData.voltageACData;
            AddRow2TableDivider(sourceTable, list, dividerData.dividerId);

            list = dividerData.frequencyData;
            AddRow2TableDivider(sourceTable, list, dividerData.dividerId);

            try
            {
                BulkInsert(sourceTable);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        ///大批量数据插入,返回成功插入行数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="table">数据表</param>
        /// <returns>返回成功插入行数</returns>
        public static int BulkInsert(DataTable table)
        {
            if (string.IsNullOrEmpty(table.TableName)) 
                throw new Exception("请给DataTable的TableName属性附上表名称");
            if (table.Rows.Count == 0) 
                return 0;
            int insertCount = 0;
            string tmpPath = Path.GetTempFileName();
            string csv = DataTableToCsv(table);
            File.WriteAllText(tmpPath, csv);
            using (MySqlConnection conn = new MySqlConnection(DataBase.connString))
            {
                MySqlTransaction tran = null;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    MySqlBulkLoader bulk = new MySqlBulkLoader(conn)
                    {
                        FieldTerminator = ",",
                        FieldQuotationCharacter = '"',
                        EscapeCharacter = '"',
                        LineTerminator = "\r\n",
                        FileName = tmpPath,
                        NumberOfLinesToSkip = 0,
                        TableName = table.TableName,
                    };
                    bulk.Columns.AddRange(table.Columns.Cast<DataColumn>().Select(colum => colum.ColumnName).ToList());
                    insertCount = bulk.Load();
                    tran.Commit();
                }
                catch (MySqlException ex)
                {
                    if (tran != null) tran.Rollback();
                    throw ex;
                }
            }
            File.Delete(tmpPath);
            return insertCount;
        }

        /// <summary>
        ///将DataTable转换为标准的CSV
        /// </summary>
        /// <param name="table">数据表</param>
        /// <returns>返回标准的CSV</returns>
        private static string DataTableToCsv(DataTable table)
        {
            //以半角逗号（即,）作分隔符，列为空也要表达其存在。
            //列内容如存在半角逗号（即,）则用半角引号（即""）将该字段值包含起来。
            //列内容如存在半角引号（即"）则应替换成半角双引号（""）转义，并用半角引号（即""）将该字段值包含起来。
            StringBuilder sb = new StringBuilder();
            DataColumn colum;
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    colum = table.Columns[i];
                    if (i != 0) sb.Append(",");
                    if (colum.DataType == typeof(string) && row[colum].ToString().Contains(","))
                    {
                        sb.Append("\"" + row[colum].ToString().Replace("\"", "\"\"") + "\"");
                    }
                    else sb.Append(row[colum].ToString());
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        //根据时间范围获取历史数据
        public static DataTable SelectDividerDataByTime(DateTime start,DateTime end,int dividerId) {
            //字符串前加@可以随意换行
            string sql = @"select source_volt,source_freq,stand_divider_volt,test_divider_volt,temperature,humidity,save_time from divider_data 
                                 where divider_id = ?divider_id and save_time >= ?start_time and save_time <= ?end_time";
            MySqlDateTime startTime = new MySqlDateTime(start);
            MySqlDateTime endTime = new MySqlDateTime(end);

            MySqlParameter[] Params = new MySqlParameter[]
            {
                new MySqlParameter("?divider_id",dividerId),                
                new MySqlParameter("?start_time",startTime),
                new MySqlParameter("?end_time",endTime)
            };
            DataBase db = new DataBase();
            DataTable dt = db.ExecuteQuery(sql,Params);
            if (dt != null)
            {
                Console.WriteLine(dt.Rows[0][0].ToString());
            }
            return dt;
        }
    }
}
