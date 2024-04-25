using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DrinkType : DAL<DAL_DrinkType, DrinkType, int>
    {
        public override void Create(DrinkType newElement)
        {
            SqlCommand cmd = new SqlCommand("InsertDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = newElement.id;
            cmd.Parameters.AddWithValue("Name", SqlDbType.NVarChar).Value = newElement.name;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int deleteDrinkTypeID)
        {
            SqlCommand cmd = new SqlCommand("DeleteDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = deleteDrinkTypeID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(DrinkType updateElement, int oldDrinkTypeID)
        {
            SqlCommand cmd = new SqlCommand("UpdateDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = updateElement.id;
            cmd.Parameters.AddWithValue("Name", SqlDbType.NVarChar).Value = updateElement.name;
            cmd.Parameters.AddWithValue("OldId", SqlDbType.Int).Value = oldDrinkTypeID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
    }
}
