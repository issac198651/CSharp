using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace codeRep
{
    class Program
    {
        static int Main(string[] args)
        {
            #region
            #endregion

            #region returnValue
            //=======================================================================================
            // check if only one instance is running
            string mutex_id = Process.GetCurrentProcess().ProcessName;
            using (Mutex mutex = new Mutex(false, mutex_id))
            {
                if (!mutex.WaitOne(0, false))
                {
                    Console.WriteLine("{0} is already running!", mutex_id);
                    return 1;
                }
            
                Console.WriteLine("{0} starts running successfully!", mutex_id);
                Thread.Sleep(20000);
                return 0;
            }
            //=======================================================================================
            #endregion

            #region File manipulation
            //=======================================================================================
            // using File.Create() will occupy the file access control 
            //FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\" + Process.GetCurrentProcess().ProcessName + @".lck", FileMode.Create);
            //fs.Close();
            //Thread.Sleep(5000);
            //File.Delete(Directory.GetCurrentDirectory() + @"\" + Process.GetCurrentProcess().ProcessName + @".lck");
            //=======================================================================================
            #endregion

            #region MySql manipulation
            //=======================================================================================
            //string cs = @"server=sz400pzc;userid=charm_root;password=charmroot;database=charm_db";
            //
            //MySqlConnection conn = null;
            //
            //try
            //{
            //    conn = new MySqlConnection(cs);
            //    conn.Open();
            //    Console.WriteLine("MySQL version: {0}", conn.ServerVersion);
            //
            //    MySqlCommand getIdCMD = new MySqlCommand();
            //    
            //    getIdCMD.Connection = conn;
            //    getIdCMD.CommandText = "SELECT id_num FROM charm";
            //    
            //    MySqlDataReader reader = getIdCMD.ExecuteReader();
            //    
            //    List<int> id_num_list = new List<int>();
            //    int id_num_temp;
            //    
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            id_num_temp = reader.GetInt32(0);
            //            Console.WriteLine(id_num_temp);
            //            id_num_list.Add(id_num_temp);
            //        }
            //    }
            //    
            //    foreach(var m in id_num_list)
            //    {
            //        Console.Write(m);
            //    }
            //    
            //}
            //catch (MySqlException ex)
            //{
            //    Console.WriteLine("Error: {0}", ex.ToString());
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //}
            //=======================================================================================
            #endregion

        }
    }
}
